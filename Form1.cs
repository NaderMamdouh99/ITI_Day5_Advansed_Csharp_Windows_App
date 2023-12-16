using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Characters_Least.Hide();
            Email_Least.Hide();
            Hoppy_Least.Hide();
            Valid_Log.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {

            //if (Username_Log.Text.Length < 5 &&
            //    !(Email_Log.Text.Contains("@")) &&
            //    !(Football_choes.Checked || Tennis_choes.Checked || Swimming_choes.Checked))
            //{
            //    Characters_Least.Show();
            //    Email_Least.Show();
            //    Hoppy_Least.Show();
            //}
            //else
            //{
            //    Characters_Least.Hide();
            //    Email_Least.Hide();
            //    Hoppy_Least.Hide();
            //    Valid_Log.Show();
            //}
            if (Username_Log.Text.Length < 5)
            {
                Characters_Least.Show();
            }
            else
            {
                Characters_Least.Hide();
            }
            if (!Email_Log.Text.Contains("@"))
            {
                Email_Least.Show();
            }
            else
            {
                Email_Least.Hide();
            }
            if (!Football_choes.Checked || Tennis_choes.Checked || Swimming_choes.Checked)
            {
                Hoppy_Least.Show();
            }
            else
            {
                Hoppy_Least.Hide();
            }
            if (Username_Log.Text.Length > 5 &&
               (Email_Log.Text.Contains("@")) &&
               (Football_choes.Checked || Tennis_choes.Checked || Swimming_choes.Checked))
            {
                Valid_Log.Show();
            }
            else
            {
                Valid_Log.Hide();
            }

        }
    }
}
