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
        /// Botões de digitos
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
        // Botões 

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
        // Botões + - * /
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
        // Botões CE ( )
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
        private void btn_result_Click(object sender, EventArgs e)
        {
            char[] charArr = tb_pricipal.Text.ToCharArray();
            SepararValores(charArr);

            LT = true;
            DOT = true;
        }

        // Método para Calcular

        public void SepararValores(params char[] ControleStr)
        {
            var Valores = new LinkedList<float>();
            var Control = new LinkedList<char>(ControleStr);
            string Separador = "";

                for (LinkedListNode<char> ch = Control.First; ch != null; ch = ch.Next)
                {
                    if (char.IsDigit(ch.Value))
                    {
                        Separador += ch.Value;
                    }
                    if (ch.Next == null)
                    {
                        Valores.AddLast(float.Parse(Separador));
                    }
                    if (!char.IsDigit(ch.Value) && Separador != "")
                    {
                        Valores.AddLast(float.Parse(Separador));
                        Separador = "";
                    }
                }

            float[] Val = Valores.ToArray();
            if (ControleStr[0] == '-')
                Val[0] *= -1;
            //tb_pricipal.Text = Convert.ToString(Val[0]);
            Calcular(Val);
            
        }
        public void Calcular(params float[]ControlStr)
        {
            Dictionary<int, char> Operadores = new Dictionary<int, char>();
            char[] charArr = tb_pricipal.Text.ToCharArray();
            int i = 0;

            foreach(char ch in charArr)
            {
                if (ch == 'x' || ch == '-' || ch == '+' || ch == '÷')
                {
                    Operadores.Add(i, ch);
                    i++;
                }
            }
            if (!Operadores.ContainsValue('x'))
            {

            }
            if (!Operadores.ContainsValue('÷'))
            {

            }
        }
    }
}
