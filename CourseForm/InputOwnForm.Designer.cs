﻿namespace CourseForm
{
    partial class InputOwnForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.ChoiceTextBox = new System.Windows.Forms.TextBox();
            this.ChoiceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(275, 40);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 30);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ChoiceTextBox
            // 
            this.ChoiceTextBox.Location = new System.Drawing.Point(142, 12);
            this.ChoiceTextBox.Name = "ChoiceTextBox";
            this.ChoiceTextBox.Size = new System.Drawing.Size(223, 22);
            this.ChoiceTextBox.TabIndex = 1;
            this.ChoiceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ChoiceLabel
            // 
            this.ChoiceLabel.AutoSize = true;
            this.ChoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceLabel.ForeColor = System.Drawing.Color.Black;
            this.ChoiceLabel.Location = new System.Drawing.Point(14, 11);
            this.ChoiceLabel.Name = "ChoiceLabel";
            this.ChoiceLabel.Size = new System.Drawing.Size(122, 25);
            this.ChoiceLabel.TabIndex = 2;
            this.ChoiceLabel.Text = "your genre:";
            // 
            // InputOwnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 74);
            this.Controls.Add(this.ChoiceLabel);
            this.Controls.Add(this.ChoiceTextBox);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputOwnForm";
            this.Text = "Personal choice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox ChoiceTextBox;
        public System.Windows.Forms.Label ChoiceLabel;
    }
}