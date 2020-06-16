using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Fazly_PA9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                double amount, converted, usRate = 0.74, jpRate = 81.97, ringgitRate = 3.01;
                amount = double.Parse(txt_Amount.Text);
                if (!(amount < 0))
                {
                    if (rb_US.Checked)
                    {
                        converted = amount * usRate;
                        txt_Converted.Text = converted.ToString();
                    }
                    else if (rb_Yen.Checked)
                    {
                        converted = amount * jpRate;
                        txt_Converted.Text = converted.ToString();
                    }
                    else if (rb_Ringgit.Checked)
                    {
                        converted = amount * ringgitRate;
                        txt_Converted.Text = converted.ToString();
                    } 
                }
                else
                {
                    txt_Converted.Text = "Cannot convert negative amount";
                }
            }
            catch (FormatException)
            {
                txt_Converted.Text = "Please enter a valid amount";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Text = "";
            txt_Converted.Text = "";
            rb_US.Checked = false;
            rb_Yen.Checked = false;
            rb_Ringgit.Checked = false;
        }
    }
}
