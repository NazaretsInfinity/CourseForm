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
    public partial class InputOwnForm : Form
    {
        public string Choice {get; private set;}
        
        
        public InputOwnForm()
        {
            InitializeComponent();
        }
        private void OKButton_Click(object sender, EventArgs e) => Choice = (ChoiceTextBox.Text == ""? null : ChoiceTextBox.Text);
    }
}
