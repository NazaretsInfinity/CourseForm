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
        ColorDialog book_color = new ColorDialog();
        Book mybook = new Book();

        SaveFileDialog saver = new SaveFileDialog();
        OpenFileDialog opener = new OpenFileDialog();
 
        
        public MainForm()
        {
            InitializeComponent();
            saver.Filter = opener.Filter = "JSON Files (*.json)|*.json";

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

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = char.IsLetter(e.KeyChar);
        

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string saving;
            if(saver.ShowDialog() == DialogResult.OK & saver.FileName != "")
            {
                mybook.Title = TextBoxName.Text;
                mybook.Author = TextBoxAuthor.Text;
                mybook.Genre = ComboBoxGenre.Text.ToString();
                mybook.Color = ChooseColorButton.ForeColor;
                mybook.Format = FormatComboBox.Text.ToString();
                mybook.Binding = BookBindingComboBox.Text.ToString();
                mybook.PageAmount = Convert.ToInt32(PageNumeric.Value);
                mybook.Data = ReleaseDatePicker.Value;

                if(PriceTextBox.Text != "")
                mybook.Price = Convert.ToInt32(PriceTextBox.Text);
                mybook.Weight = maskedTextBox1.Text.Remove(6, 3); 

                saving = JsonConvert.SerializeObject(mybook, Formatting.Indented);
                File.WriteAllText(saver.FileName,saving );
            }

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if(opener.ShowDialog() == DialogResult.OK  & opener.FileName != "")
            {
               string json = File.ReadAllText(opener.FileName);
               Book book = JsonConvert.DeserializeObject<Book>(json);
                TextBoxName.Text = book.Title;
                TextBoxAuthor.Text = book.Author;
                ComboBoxGenre.Text = book.Genre;
                ChooseColorButton.ForeColor = book.Color;
                FormatComboBox.Text = book.Format;
                BookBindingComboBox.Text = book.Binding;
                PageNumeric.Value = Convert.ToDecimal(book.PageAmount);
                ReleaseDatePicker.Value = (DateTime)book.Data;
                PriceTextBox.Text = book.Price.ToString();
                maskedTextBox1.Text = $"{book.Weight}";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => SaveButton_Click(sender, e);
        private void loadToolStripMenuItem_Click(object sender, EventArgs e) => LoadButton_Click(sender, e);

        private void helpToolStripMenuItem_Click(object sender, EventArgs e) => new AboutProgram().Show();
        private void programToolStripMenuItem_Click(object sender, EventArgs e) => new AboutProgram().Show();

        private void maskedTextBox1_Enter(object sender, EventArgs e) => maskedTextBox1.Clear();
    }
}
