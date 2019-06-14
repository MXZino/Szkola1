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
    public partial class AddNewSubject : Form
    {
        public string name;
        public int v1, v2;

  

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToInt32(numericUpDown1.Value);
            v2 = Convert.ToInt32(numericUpDown2.Value);
            name = textBox1.Text;
        }
  
        public AddNewSubject()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

       

    }
}
