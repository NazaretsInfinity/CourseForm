using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace CourseForm
{
    public partial class MainForm : Form
    {
        ColorDialog book_color;
        Book mybook = new Book();

        SaveFileDialog saver;
 
        
        public MainForm()
        {
            InitializeComponent();
            book_color = new ColorDialog();
            saver = new SaveFileDialog();
            saver.Filter = "JSON Files (*.json)|*.json";

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void ChooseColor_Click(object sender, EventArgs e)
        {
            if (book_color.ShowDialog() == DialogResult.OK)
                ChooseColorButton.ForeColor = book_color.Color;
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

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e) // no letters
        {
            if(char.IsLetter(e.KeyChar))e.Handled = true;
            if(e.KeyChar == '.' && PriceTextBox.Text.Contains('.'))e.Handled =true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string saving;
            if(saver.ShowDialog() == DialogResult.OK & saver.FileName != "")
            {
                mybook.Title = TextBoxName.Text;
                mybook.Author = TextBoxAuthor.Text;
                mybook.Genre = ComboBoxGenre.SelectedItem.ToString();
                mybook.Color = ChooseColorButton.ForeColor;
                mybook.Format = FormatComboBox.SelectedItem.ToString();
                mybook.Binding = BookBindingComboBox.SelectedItem.ToString();
                mybook.PageAmount = Convert.ToInt32(PageNumeric.Value);
                mybook.Data = ReleaseDatePicker.Value;
                mybook.Weight = Convert.ToSingle(maskedTextBox1.Text.Remove(6,3)); 

                saving = JsonConvert.SerializeObject(mybook, Formatting.Indented);
                File.WriteAllText(saver.FileName,saving );
            }

        }


        private void LoadButton_Click(object sender, EventArgs e)
        {

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => SaveButton_Click(sender, e);
    }
}
