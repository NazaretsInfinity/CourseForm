using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseForm
{
    public partial class MainForm : Form
    {
        ColorDialog book_color;
        
        public MainForm()
        {
            InitializeComponent();
            book_color = new ColorDialog();
           
        }

        private void ChooseColor_Click(object sender, EventArgs e)
        {
            if (book_color.ShowDialog() == DialogResult.OK)
                ChooseColorButton.ForeColor = book_color.Color;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }


        private void PersonalGenreButton_Click(object sender, EventArgs e)
        {
            InputOwnForm yourgenre = new InputOwnForm();
            if (yourgenre.ShowDialog() == DialogResult.OK & yourgenre.Choice != null)
            {
                ComboBoxGenre.Items.Add(yourgenre.Choice);
                ComboBoxGenre.SelectedItem = (ComboBoxGenre.Items[ComboBoxGenre.Items.Count - 1]);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void OwnFormatButton_Click(object sender, EventArgs e)
        {
            InputOwnFormat yourformat = new InputOwnFormat();
            if(yourformat.ShowDialog() == DialogResult.OK)
            {
                FormatComboBox.Items.Add(yourformat.Choice);
                FormatComboBox.SelectedItem = (FormatComboBox.Items[FormatComboBox.Items.Count-1]);
            }
        }

        private void OwnBindingButton_Click(object sender, EventArgs e)
        {
            InputOwnForm yourbinding = new InputOwnForm();
            yourbinding.ChoiceLabel.Text = "new binding: ";
            if (yourbinding.ShowDialog() == DialogResult.OK)
            {
                BookBindingComboBox.Items.Add(yourbinding.Choice);
                BookBindingComboBox.SelectedItem = (BookBindingComboBox.Items[BookBindingComboBox.Items.Count - 1]);
            }
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))e.Handled = true;
            if(e.KeyChar == '.' && PriceTextBox.Text.Contains('.'))e.Handled =true;
        }

    }
}
