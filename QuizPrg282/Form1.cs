using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizPrg282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText("Test.txt");
            listbox1.Items.Add(text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
