using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hex2string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            Convert_();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Convert_();
        }

        void Convert_()
        {
            output.Text = "";
            string str = input.Text.Replace(" ", "");

            try
            {
                for (int i = 0; i < str.Length; i += 2)
                {
                    string hs = string.Empty;

                    hs = str.Substring(i, 2);
                    ulong decval = Convert.ToUInt64(hs, 16);
                    long deccc = Convert.ToInt64(hs, 16);
                    char character = Convert.ToChar(deccc);
                    output.Text += character;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }
    }
}
