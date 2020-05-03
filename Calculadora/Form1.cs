﻿using System;
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
            tb_pricipal.Text += "1";
            OP = true;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += "2";
            OP = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += "3";
            OP = true;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += "4";
            OP = true;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += "5";
            OP = true;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += "6";
            OP = true;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += "7";
            OP = true;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += "8";
            OP = true;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += "9";
            OP = true;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += "0";
            OP = true;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (DOT && !LT) 
            {
                tb_pricipal.Text += ".";
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
            tb_pricipal.Text = "Ainda não programei";
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
                tb_pricipal.Text += "+";
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
                tb_pricipal.Text += "-";
                OP = false;
            }
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            if (OP && !LT)
            {
                tb_pricipal.Text += "x";
                OP = false;
            }
        }
        private void btn_divid_Click(object sender, EventArgs e)
        {
            if (OP && !LT) 
            {
                tb_pricipal.Text += "/";
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
            tb_pricipal.Text += "(";
        }

        private void btn_par2_Click(object sender, EventArgs e)
        {
            if (LT)
            {
                tb_pricipal.Text = "";
                LT = false;
            }
            tb_pricipal.Text += ")";
        }
    }
}
