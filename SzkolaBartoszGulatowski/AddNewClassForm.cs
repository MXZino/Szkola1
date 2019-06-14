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
    public partial class AddNewClassForm : Form
    {
        public string text;
        public AddNewClassForm()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           text = textBox1.Text;         
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}
