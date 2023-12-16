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
    public partial class Convert : Form
    {
        public Convert()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Convert_to_Click(object sender, EventArgs e)
        {

            double inp;
            bool flag = double.TryParse(txt_Value.Text,out inp);
            if (flag == false)
            {
                MessageBox.Show("Value Must be double .. ");
            }
            if (Kilo_Convert.Checked || Mile_Convert.Checked || Meter_Convert.Checked)
            {
                if (Kilo_Convert.Checked && flag == true)
                {
                    txt_Result.Text = (inp / 1000).ToString();
                }
                if (Mile_Convert.Checked && flag == true)
                {
                    txt_Result.Text = (inp / 1600).ToString();
                }
                if (Meter_Convert.Checked && flag == true)
                {
                    txt_Result.Text = (inp * 1600).ToString();
                }
            }
            else
            {
                MessageBox.Show("You Must Choose Any Unit..");
            }



        }
    }
}
