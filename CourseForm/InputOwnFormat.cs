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
    public partial class InputOwnFormat : Form
    {
        public string Choice {  get; private set; }
        public InputOwnFormat()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) => Choice = $"{numericUpDown1.Value}x{numericUpDown2.Value}";
    }
}
