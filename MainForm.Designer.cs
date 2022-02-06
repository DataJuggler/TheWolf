namespace TheWolf
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CleanButton = new DataJuggler.Win.Controls.Button();
            this.PathControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.MaxFilesControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.ExtensionsControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CleanButton
            // 
            this.CleanButton.BackColor = System.Drawing.Color.Transparent;
            this.CleanButton.ButtonText = "Clean";
            this.CleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CleanButton.Location = new System.Drawing.Point(624, 310);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(128, 44);
            this.CleanButton.TabIndex = 0;
            this.CleanButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // PathControl
            // 
            this.PathControl.BackColor = System.Drawing.Color.Transparent;
            this.PathControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.PathControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.PathControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("PathControl.ButtonImage")));
            this.PathControl.ButtonWidth = 48;
            this.PathControl.DarkMode = false;
            this.PathControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.PathControl.Editable = true;
            this.PathControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.PathControl.Filter = null;
            this.PathControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathControl.HideBrowseButton = false;
            this.PathControl.LabelBottomMargin = 0;
            this.PathControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.PathControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PathControl.LabelText = "Folder:";
            this.PathControl.LabelTopMargin = 0;
            this.PathControl.LabelWidth = 120;
            this.PathControl.Location = new System.Drawing.Point(31, 78);
            this.PathControl.Name = "PathControl";
            this.PathControl.OnTextChangedListener = null;
            this.PathControl.OpenCallback = null;
            this.PathControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PathControl.SelectedPath = null;
            this.PathControl.Size = new System.Drawing.Size(721, 32);
            this.PathControl.StartPath = null;
            this.PathControl.TabIndex = 1;
            this.PathControl.TextBoxBottomMargin = 0;
            this.PathControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.PathControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.PathControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathControl.TextBoxTopMargin = 0;
            this.PathControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MaxFilesControl
            // 
            this.MaxFilesControl.BackColor = System.Drawing.Color.Transparent;
            this.MaxFilesControl.BottomMargin = 0;
            this.MaxFilesControl.Editable = true;
            this.MaxFilesControl.Encrypted = false;
            this.MaxFilesControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxFilesControl.LabelBottomMargin = 0;
            this.MaxFilesControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MaxFilesControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxFilesControl.LabelText = "Max Files:";
            this.MaxFilesControl.LabelTopMargin = 0;
            this.MaxFilesControl.LabelWidth = 100;
            this.MaxFilesControl.Location = new System.Drawing.Point(532, 238);
            this.MaxFilesControl.MultiLine = false;
            this.MaxFilesControl.Name = "MaxFilesControl";
            this.MaxFilesControl.OnTextChangedListener = null;
            this.MaxFilesControl.PasswordMode = false;
            this.MaxFilesControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MaxFilesControl.Size = new System.Drawing.Size(220, 32);
            this.MaxFilesControl.TabIndex = 2;
            this.MaxFilesControl.TextBoxBottomMargin = 0;
            this.MaxFilesControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.MaxFilesControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.MaxFilesControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxFilesControl.TextBoxTopMargin = 0;
            this.MaxFilesControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(31, 405);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(745, 23);
            this.Graph.TabIndex = 3;
            this.Graph.Visible = false;
            // 
            // ExtensionsControl
            // 
            this.ExtensionsControl.BackColor = System.Drawing.Color.Transparent;
            this.ExtensionsControl.BottomMargin = 0;
            this.ExtensionsControl.Editable = true;
            this.ExtensionsControl.Encrypted = false;
            this.ExtensionsControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExtensionsControl.LabelBottomMargin = 0;
            this.ExtensionsControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ExtensionsControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExtensionsControl.LabelText = "Extensions:";
            this.ExtensionsControl.LabelTopMargin = 0;
            this.ExtensionsControl.LabelWidth = 120;
            this.ExtensionsControl.Location = new System.Drawing.Point(31, 158);
            this.ExtensionsControl.MultiLine = false;
            this.ExtensionsControl.Name = "ExtensionsControl";
            this.ExtensionsControl.OnTextChangedListener = null;
            this.ExtensionsControl.PasswordMode = false;
            this.ExtensionsControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExtensionsControl.Size = new System.Drawing.Size(721, 32);
            this.ExtensionsControl.TabIndex = 4;
            this.ExtensionsControl.TextBoxBottomMargin = 0;
            this.ExtensionsControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ExtensionsControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ExtensionsControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExtensionsControl.TextBoxTopMargin = 0;
            this.ExtensionsControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(30, 379);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(746, 23);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheWolf.Properties.Resources.BlackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ExtensionsControl);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.MaxFilesControl);
            this.Controls.Add(this.PathControl);
            this.Controls.Add(this.CleanButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Wolf";
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.Button CleanButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl PathControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl MaxFilesControl;
        private ProgressBar Graph;
        private DataJuggler.Win.Controls.LabelTextBoxControl ExtensionsControl;
        private Label StatusLabel;
    }
}