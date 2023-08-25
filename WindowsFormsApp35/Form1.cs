using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cEmployee sam = new cEmployee();
            sam.firstname = "ali";
            sam.lastname = "rezaee";
            sam.identity = "002745632";
            label1.Text = sam.Concatinate();
        }
    }
}
