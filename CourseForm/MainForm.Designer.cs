namespace CourseForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlBooks = new System.Windows.Forms.TabControl();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PersonalGenreButton = new System.Windows.Forms.Button();
            this.ComboBoxGenre = new System.Windows.Forms.ComboBox();
            this.TextBoxAuthor = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.PersonalPage = new System.Windows.Forms.TabPage();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ChooseColorButton = new System.Windows.Forms.Button();
            this.CustomPage = new System.Windows.Forms.TabPage();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PageAmountLabel = new System.Windows.Forms.Label();
            this.PageNumeric = new System.Windows.Forms.NumericUpDown();
            this.BookFormatLabel = new System.Windows.Forms.Label();
            this.FormatComboBox = new System.Windows.Forms.ComboBox();
            this.OwnFormatButton = new System.Windows.Forms.Button();
            this.BindingLabel = new System.Windows.Forms.Label();
            this.BookBindingComboBox = new System.Windows.Forms.ComboBox();
            this.OwnBindingButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ReleaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TabControlBooks.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.PersonalPage.SuspendLayout();
            this.CustomPage.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlBooks
            // 
            this.TabControlBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlBooks.Controls.Add(this.GeneralPage);
            this.TabControlBooks.Controls.Add(this.PersonalPage);
            this.TabControlBooks.Controls.Add(this.CustomPage);
            this.TabControlBooks.Location = new System.Drawing.Point(15, 69);
            this.TabControlBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabControlBooks.Name = "TabControlBooks";
            this.TabControlBooks.SelectedIndex = 0;
            this.TabControlBooks.Size = new System.Drawing.Size(482, 444);
            this.TabControlBooks.TabIndex = 0;
            // 
            // GeneralPage
            // 
            this.GeneralPage.Controls.Add(this.GenreLabel);
            this.GeneralPage.Controls.Add(this.AuthorLabel);
            this.GeneralPage.Controls.Add(this.NameLabel);
            this.GeneralPage.Controls.Add(this.PersonalGenreButton);
            this.GeneralPage.Controls.Add(this.ComboBoxGenre);
            this.GeneralPage.Controls.Add(this.TextBoxAuthor);
            this.GeneralPage.Controls.Add(this.TextBoxName);
            this.GeneralPage.Location = new System.Drawing.Point(4, 27);
            this.GeneralPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GeneralPage.Size = new System.Drawing.Size(474, 413);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "General";
            this.GeneralPage.UseVisualStyleBackColor = true;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(36, 111);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(59, 18);
            this.GenreLabel.TabIndex = 6;
            this.GenreLabel.Text = "Genre:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(36, 66);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(62, 18);
            this.AuthorLabel.TabIndex = 5;
            this.AuthorLabel.Text = "Author:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(36, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 18);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Title:";
            // 
            // PersonalGenreButton
            // 
            this.PersonalGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalGenreButton.Location = new System.Drawing.Point(126, 139);
            this.PersonalGenreButton.Name = "PersonalGenreButton";
            this.PersonalGenreButton.Size = new System.Drawing.Size(188, 26);
            this.PersonalGenreButton.TabIndex = 3;
            this.PersonalGenreButton.Text = "Cannot find the genre?";
            this.PersonalGenreButton.UseVisualStyleBackColor = true;
            this.PersonalGenreButton.Click += new System.EventHandler(this.PersonalGenreButton_Click);
            // 
            // ComboBoxGenre
            // 
            this.ComboBoxGenre.FormattingEnabled = true;
            this.ComboBoxGenre.Items.AddRange(new object[] {
            "novel",
            "detective",
            "horror",
            "fantasy",
            "science",
            "drama",
            "comedy",
            "scince-fiction(sci-fi)",
            "historical novel "});
            this.ComboBoxGenre.Location = new System.Drawing.Point(126, 107);
            this.ComboBoxGenre.Name = "ComboBoxGenre";
            this.ComboBoxGenre.Size = new System.Drawing.Size(188, 26);
            this.ComboBoxGenre.TabIndex = 2;
            // 
            // TextBoxAuthor
            // 
            this.TextBoxAuthor.Location = new System.Drawing.Point(126, 63);
            this.TextBoxAuthor.Name = "TextBoxAuthor";
            this.TextBoxAuthor.Size = new System.Drawing.Size(188, 24);
            this.TextBoxAuthor.TabIndex = 1;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(126, 25);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(188, 24);
            this.TextBoxName.TabIndex = 0;
            // 
            // PersonalPage
            // 
            this.PersonalPage.Controls.Add(this.OwnBindingButton);
            this.PersonalPage.Controls.Add(this.BookBindingComboBox);
            this.PersonalPage.Controls.Add(this.BindingLabel);
            this.PersonalPage.Controls.Add(this.OwnFormatButton);
            this.PersonalPage.Controls.Add(this.FormatComboBox);
            this.PersonalPage.Controls.Add(this.BookFormatLabel);
            this.PersonalPage.Controls.Add(this.PageNumeric);
            this.PersonalPage.Controls.Add(this.PageAmountLabel);
            this.PersonalPage.Controls.Add(this.ColorLabel);
            this.PersonalPage.Controls.Add(this.ChooseColorButton);
            this.PersonalPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalPage.Location = new System.Drawing.Point(4, 27);
            this.PersonalPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PersonalPage.Name = "PersonalPage";
            this.PersonalPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PersonalPage.Size = new System.Drawing.Size(474, 413);
            this.PersonalPage.TabIndex = 1;
            this.PersonalPage.Text = "Personal";
            this.PersonalPage.UseVisualStyleBackColor = true;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(23, 26);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(105, 20);
            this.ColorLabel.TabIndex = 1;
            this.ColorLabel.Text = "Book color:";
            // 
            // ChooseColorButton
            // 
            this.ChooseColorButton.Location = new System.Drawing.Point(134, 21);
            this.ChooseColorButton.Name = "ChooseColorButton";
            this.ChooseColorButton.Size = new System.Drawing.Size(133, 30);
            this.ChooseColorButton.TabIndex = 0;
            this.ChooseColorButton.Text = "Color ▉▉▉";
            this.ChooseColorButton.UseVisualStyleBackColor = true;
            this.ChooseColorButton.Click += new System.EventHandler(this.ChooseColor_Click);
            // 
            // CustomPage
            // 
            this.CustomPage.Controls.Add(this.PriceTextBox);
            this.CustomPage.Controls.Add(this.maskedTextBox1);
            this.CustomPage.Controls.Add(this.ReleaseDatePicker);
            this.CustomPage.Controls.Add(this.WeightLabel);
            this.CustomPage.Controls.Add(this.DateLabel);
            this.CustomPage.Controls.Add(this.PriceLabel);
            this.CustomPage.Location = new System.Drawing.Point(4, 27);
            this.CustomPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomPage.Name = "CustomPage";
            this.CustomPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomPage.Size = new System.Drawing.Size(474, 413);
            this.CustomPage.TabIndex = 2;
            this.CustomPage.Text = "Custom";
            this.CustomPage.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(138, 515);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 29);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(261, 515);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(115, 28);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "load";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.programToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(512, 30);
            this.MainMenuStrip.TabIndex = 3;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.programToolStripMenuItem.Text = "About";
            // 
            // PageAmountLabel
            // 
            this.PageAmountLabel.AutoSize = true;
            this.PageAmountLabel.Location = new System.Drawing.Point(23, 262);
            this.PageAmountLabel.Name = "PageAmountLabel";
            this.PageAmountLabel.Size = new System.Drawing.Size(135, 20);
            this.PageAmountLabel.TabIndex = 2;
            this.PageAmountLabel.Text = "Page quantity: ";
            // 
            // PageNumeric
            // 
            this.PageNumeric.Location = new System.Drawing.Point(164, 259);
            this.PageNumeric.Name = "PageNumeric";
            this.PageNumeric.Size = new System.Drawing.Size(103, 27);
            this.PageNumeric.TabIndex = 3;
            this.PageNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BookFormatLabel
            // 
            this.BookFormatLabel.AutoSize = true;
            this.BookFormatLabel.Location = new System.Drawing.Point(23, 85);
            this.BookFormatLabel.Name = "BookFormatLabel";
            this.BookFormatLabel.Size = new System.Drawing.Size(80, 20);
            this.BookFormatLabel.TabIndex = 4;
            this.BookFormatLabel.Text = "Format: ";
            // 
            // FormatComboBox
            // 
            this.FormatComboBox.FormattingEnabled = true;
            this.FormatComboBox.Items.AddRange(new object[] {
            "A4 (20x29)",
            "A5 (14x20)",
            "A6 (10x14)",
            "B5 (17x24)",
            "Square(20x20)"});
            this.FormatComboBox.Location = new System.Drawing.Point(134, 81);
            this.FormatComboBox.Name = "FormatComboBox";
            this.FormatComboBox.Size = new System.Drawing.Size(133, 28);
            this.FormatComboBox.TabIndex = 5;
            // 
            // OwnFormatButton
            // 
            this.OwnFormatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnFormatButton.Location = new System.Drawing.Point(134, 111);
            this.OwnFormatButton.Name = "OwnFormatButton";
            this.OwnFormatButton.Size = new System.Drawing.Size(133, 22);
            this.OwnFormatButton.TabIndex = 6;
            this.OwnFormatButton.Text = "cannot find";
            this.OwnFormatButton.UseVisualStyleBackColor = true;
            this.OwnFormatButton.Click += new System.EventHandler(this.OwnFormatButton_Click);
            // 
            // BindingLabel
            // 
            this.BindingLabel.AutoSize = true;
            this.BindingLabel.Location = new System.Drawing.Point(23, 163);
            this.BindingLabel.Name = "BindingLabel";
            this.BindingLabel.Size = new System.Drawing.Size(78, 20);
            this.BindingLabel.TabIndex = 7;
            this.BindingLabel.Text = "Binding:";
            // 
            // BookBindingComboBox
            // 
            this.BookBindingComboBox.FormattingEnabled = true;
            this.BookBindingComboBox.Items.AddRange(new object[] {
            "Case bound",
            "Board bound",
            "Perfect bound",
            "Saddle stitched",
            "Coil binding",
            "Wire-O"});
            this.BookBindingComboBox.Location = new System.Drawing.Point(134, 159);
            this.BookBindingComboBox.Name = "BookBindingComboBox";
            this.BookBindingComboBox.Size = new System.Drawing.Size(133, 28);
            this.BookBindingComboBox.TabIndex = 8;
            // 
            // OwnBindingButton
            // 
            this.OwnBindingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnBindingButton.Location = new System.Drawing.Point(134, 193);
            this.OwnBindingButton.Name = "OwnBindingButton";
            this.OwnBindingButton.Size = new System.Drawing.Size(133, 22);
            this.OwnBindingButton.TabIndex = 9;
            this.OwnBindingButton.Text = "cannot find";
            this.OwnBindingButton.UseVisualStyleBackColor = true;
            this.OwnBindingButton.Click += new System.EventHandler(this.OwnBindingButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(38, 42);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(57, 18);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price: ";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(22, 78);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(88, 18);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Released: ";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(36, 114);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(60, 18);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "Weight";
            // 
            // ReleaseDatePicker
            // 
            this.ReleaseDatePicker.CustomFormat = "yyyy";
            this.ReleaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReleaseDatePicker.Location = new System.Drawing.Point(119, 76);
            this.ReleaseDatePicker.Name = "ReleaseDatePicker";
            this.ReleaseDatePicker.Size = new System.Drawing.Size(68, 24);
            this.ReleaseDatePicker.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(119, 111);
            this.maskedTextBox1.Mask = "00,000 kg";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(93, 24);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(119, 42);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(93, 24);
            this.PriceTextBox.TabIndex = 7;
            this.PriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTextBox_KeyPress);
     
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 561);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TabControlBooks);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Books";
            this.TabControlBooks.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.GeneralPage.PerformLayout();
            this.PersonalPage.ResumeLayout(false);
            this.PersonalPage.PerformLayout();
            this.CustomPage.ResumeLayout(false);
            this.CustomPage.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlBooks;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage PersonalPage;
        private System.Windows.Forms.TabPage CustomPage;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button PersonalGenreButton;
        private System.Windows.Forms.ComboBox ComboBoxGenre;
        private System.Windows.Forms.TextBox TextBoxAuthor;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button ChooseColorButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown PageNumeric;
        private System.Windows.Forms.Label PageAmountLabel;
        private System.Windows.Forms.ComboBox FormatComboBox;
        private System.Windows.Forms.Label BookFormatLabel;
        private System.Windows.Forms.Button OwnFormatButton;
        private System.Windows.Forms.ComboBox BookBindingComboBox;
        private System.Windows.Forms.Label BindingLabel;
        private System.Windows.Forms.Button OwnBindingButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.DateTimePicker ReleaseDatePicker;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}

