using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzkolaBartoszGulatowski
{
    public partial class AddNewTeacherForm : Form
    {
        public string firstName;
        public string secondName;
        public AddNewTeacherForm()
        {
            InitializeComponent();
            AddButton.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            firstName = textBox1.Text;
            secondName = textBox2.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text)) && (!String.IsNullOrEmpty(textBox2.Text)))
                AddButton.Enabled = true;
            else
                AddButton.Enabled = false;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text)) && (!String.IsNullOrEmpty(textBox2.Text)))
                AddButton.Enabled = true;
            else
                AddButton.Enabled = false;
        }
    }
}
