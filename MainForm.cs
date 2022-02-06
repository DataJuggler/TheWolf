

#region using statements

using DataJuggler.Win.Controls;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using System.IO;

#endregion

namespace TheWolf
{

    #region class MainForm
    /// <summary>
    /// This class [Enter Class Description]
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Init
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region CleanButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CleanButton' is clicked.
            /// </summary>
            private void CleanButton_Click(object sender, EventArgs e)
            {
                // starting with files
                List<string> extensions = TextHelper.GetWordsAsStrings(ExtensionsControl.Text);

                // get the files
                List<string> files = FileHelper.GetFilesRecursively(PathControl.Text, ref extensions);

                // locals
                int filesDeleted = 0;
                int foldersDeleted = 0;
                int maxFiles = MaxFilesControl.IntValue;

                // Get the directories
                List<string> directories = Directory.GetDirectories(PathControl.Text).ToList();

                // if there are directories
                if (ListHelper.HasOneOrMoreItems(directories))
                {
                    // Iterate the collection of string objects
                    foreach (string directory in directories)
                    {
                        try
                        {
                            // Delete everything
                            Directory.Delete(directory, true);

                            // Increment the value for foldersDeleted
                            foldersDeleted++;
                        }
                        catch (Exception error)
                        {   
                            // for debugging only for now
                            DebugHelper.WriteDebugError("CleanButton_Click", "MainForm.cs", error);
                        }
                    }
                }

                // If the files collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(files))
                {
                    // Show the graph and label
                    Graph.Visible = true;
                    StatusLabel.Visible = true;
                    StatusLabel.Text = "Anallyzing files, please wait...";
                    
                    // Setup the graph
                    Graph.Maximum = files.Count;

                    // Get the current time
                    DateTime now = DateTime.Now;

                    // Iterate the collection of string objects
                    foreach (string file in files)
                    {
                        FileInfo fileInfo = new FileInfo(file);

                        // get the age of the file
                        TimeSpan age = now - fileInfo.LastAccessTime;

                        // if older than 1 day old
                        if (age.TotalDays > 1)
                        {
                            try
                            {
                                // try and delete this file
                                File.Delete(fileInfo.FullName);

                                // Increment the value for filesDeleted
                                filesDeleted++;

                                // if we are done
                                if (filesDeleted >= maxFiles)                                
                                {
                                    // break out of loop
                                    break;
                                }

                                // refresh every 100
                                if (filesDeleted % 100 == 0)
                                {
                                    // Display status
                                    StatusLabel.Text = "Files Deleted: " + filesDeleted + "    Done.";
                                    Graph.Visible = false;

                                    // Refresh 
                                    Refresh();
                                    Application.DoEvents();
                                }
                            }
                            catch (Exception error)
                            {
                                // for debugging only for now
                                DebugHelper.WriteDebugError("CleanButton_Click", "MainForm.cs", error);
                            }
                        }
                        else
                        {
                            // Show a message nothing found
                            StatusLabel.Text = "No files found.";
                        }

                        // Set the file
                        Graph.Value++;
                    }

                    // Display status
                    StatusLabel.Text = "Files Deleted: " + filesDeleted + "    Folders: " + foldersDeleted + "    Done.";
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // use this for startup folder, change to whatever you want. This will change.
                // This is just a proof of concept test.
                PathControl.Text = Path.GetTempPath();                
                MaxFilesControl.Text = "10000";
            }
            #endregion
            
        #endregion

        #region Properties

        #endregion
        
    }
    #endregion

}
