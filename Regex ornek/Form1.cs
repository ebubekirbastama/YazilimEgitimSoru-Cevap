using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Regex_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = richTextBox1.Text.Split('*');
            for (int i = 0; i < dizi.Length; i++)
            {
                listBox1.Items.Add(dizi[i].ToString());
            }

        }
    }
}
