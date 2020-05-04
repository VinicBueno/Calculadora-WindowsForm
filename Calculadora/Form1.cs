using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class F_Principal : Form
    {
        public bool LT = true, DOT = true, OP = true;
        public F_Principal()
        {
            InitializeComponent();
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            if(LT)
            { 
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_1.Text;
            OP = true;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_2.Text;
            OP = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_3.Text;
            OP = true;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_4.Text;
            OP = true;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_5.Text;
            OP = true;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_6.Text;
            OP = true;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_7.Text;
            OP = true;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_8.Text;
            OP = true;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_9.Text;
            OP = true;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_0.Text;
            OP = true;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (DOT && !LT) 
            {
                tb_pricipal.Text += btn_dot.Text;
                DOT = false;
            }
            else if (LT)
            {
                tb_pricipal.Text = "0.";
                LT = false;
                DOT = false;
            }
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            tb_pricipal.Text = "Não sei converter string ainda";
            if (LT)
            {
                tb_pricipal.Text = "0";
            }
            LT = true;
            DOT = true;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (OP && !LT)
            {
                tb_pricipal.Text += btn_plus.Text;
                OP = false;
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            if (OP)
            {
                tb_pricipal.Text += btn_minus.Text;
                OP = false;
            }
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            if (OP && !LT)
            {
                tb_pricipal.Text += btn_times.Text;
                OP = false;
            }
        }
        private void btn_divid_Click(object sender, EventArgs e)
        {
            if (OP && !LT) 
            {
                tb_pricipal.Text += btn_divid.Text;
                OP = false;
            }
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            tb_pricipal.Text = "0";
            LT = true;
            DOT=true;
        }

        private void btn_par1_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += btn_par1.Text;
        }

        private void btn_par2_Click(object sender, EventArgs e)
        {
            if (OP && !LT)
            {
                tb_pricipal.Text += btn_par2.Text;
            }
        }
    }
}
