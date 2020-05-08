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
        public bool LT = true, DOT = true, OP = true, Fnegative = false;
        public F_Principal()
        {
            InitializeComponent();
            SepararValores("0+0".ToArray());
        }

        // Botões digitos

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
        private void btn_3_Click(object sender, EventArgs e)
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

        // Botões de operadores

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

        // Botões CE 

        private void btn_CE_Click(object sender, EventArgs e)
        {
            tb_pricipal.Text = "0";
            LT = true;
            DOT=true;
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            char[] charArr = tb_pricipal.Text.ToCharArray();
            SepararValores(charArr);

            LT = true;
            DOT = true;
        }

        private void btn_elevado_Click(object sender, EventArgs e)
        {
            float valor;
            if(float.TryParse(tb_pricipal.Text, out valor))
            {
                valor *= valor;
                tb_pricipal.Text=valor.ToString();
            }
            LT = true;
            DOT=true;
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            float valor;
            if (float.TryParse(tb_pricipal.Text, out valor))
            {
                valor /= 100;
                tb_pricipal.Text = valor.ToString();
            }
            LT = true;
            DOT = true;
        }

        private void btn_fatorial_Click(object sender, EventArgs e) 
        {
            int fator = 0;

            if(int.TryParse(tb_pricipal.Text, out fator))
            {
                if (fator < 0)
                    tb_pricipal.Text = "Syntax ERROR";
                else
                    Fatorial(fator);
            }
            else
            {
                tb_pricipal.Text="Syntax ERROR";
            }

            LT = true;
            DOT=true;
        }

        // Método para Calcular

        public void Fatorial(int fator)
        {
            if (fator == 0 | fator == 1) 
            {
                tb_pricipal.Text = "1";
            }
            else if (fator > 1 && fator < 17)
            {
                int f = fator - 1;
                while (f > 0)
                {
                    fator *= f;
                    f--;
                }
                tb_pricipal.Text = fator.ToString();
            }
            else 
            {
                tb_pricipal.Text = "Valor muito grande";
            }
        }

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
            {
                Val[0] *= -1;
                Fnegative = true;
            }
            Calcular(Val);
            
        }
        public void Calcular(params float[] ControlStr)
        {
            var Operadores = new Dictionary<int, char>();
            var prior = new List<float>();
            char[] charArr = tb_pricipal.Text.ToCharArray();
            float Resultante = 0;
            int i = 0, x = 0;
            bool Organizador = true, Aux = false; 

            if (Fnegative)
            {
                charArr[0] = ' ';
            }

            foreach (char ch in charArr)
            {
                if (ch == 'x' || ch == '-' || ch == '+' || ch == '÷')
                {
                    Operadores.Add(i, ch);
                    i++;
                }
            }

            for (i = 0; i < Operadores.Count; i++)
            {
                switch (Operadores[i])
                {
                    case 'x':
                        if (Organizador)
                        {
                            Resultante = ControlStr[i] * ControlStr[i + 1];
                            Organizador = false;
                            Aux = true;
                        }
                        else
                        {
                            Resultante = Resultante * ControlStr[i + 1];
                        }
                        break;
                    case '÷':
                        if (Organizador)
                        {
                            Resultante = ControlStr[i] / ControlStr[i + 1];
                            Organizador = false;
                            Aux = false;
                        }
                        else
                        {
                            Resultante = Resultante / ControlStr[i + 1];
                        }
                        break;
                    case '-':
                        Organizador = true;
                        if(Aux)
                        {
                            prior.Insert(x, Resultante);
                            Resultante = 0;
                            x++;
                        }
                        break;
                    case '+':
                        Organizador = true;
                        if (Aux)
                        {
                            prior.Insert(x, Resultante);
                            Resultante = 0;
                            x++;
                        }
                        break;
                }
                if (Operadores[Operadores.Count - 1] == 'x' | Operadores[Operadores.Count - 1] == '÷')
                {
                    prior.Insert(x, Resultante);
                }
            }

            Resultante = 0;
            x = 0;

            try 
            {
                for (i = 0; i < Operadores.Count; i++)
                {
                    switch (Operadores[i])
                    {
                        case 'x':
                        case '÷':
                            if (i == 0)
                            {
                                Resultante += prior[x];
                                x++;
                            }
                            if (i>0)
                            {
                                if (Operadores[i - 1] == '+') 
                                {// 1+4*3-2 123
                                    Resultante += prior[x];
                                    x++;
                                }
                                if (Operadores[i - 1] == '-') 
                                {
                                    Resultante -= prior[x];
                                    x++;
                                }
                            }
                            break;

                        case '-':
                            if (i == 0)
                            {
                                if (Operadores.Count > 1) 
                                {
                                   if (Operadores[i + 1] == 'x' | Operadores[i + 1] == '÷') 
                                   {
                                       Resultante += ControlStr[i];
                                   }
                                   else
                                   {
                                       Resultante = ControlStr[i] - ControlStr[i + 1];
                                   }
                                }
                                else
                                {
                                Resultante = ControlStr[i] - ControlStr[i + 1];
                                }
                            }
                            else
                            {
                                if (i < Operadores.Count - 1)
                                {
                                    if (Operadores[i + 1] == 'x' | Operadores[i + 1] == '÷') 
                                    {
                                        
                                    }
                                    else
                                    {
                                        Resultante -= ControlStr[i+1];
                                    }
                                }
                                else
                                {
                                    Resultante -= ControlStr[i+1];
                                }
                            }
                            break;

                        case '+':
                            if (i == 0)
                            {
                                if (Operadores.Count > 1) 
                                {
                                    if (Operadores[i + 1] == 'x' | Operadores[i + 1] == '÷') 
                                    {
                                        Resultante += ControlStr[i];
                                    }
                                    else
                                    {
                                        Resultante = ControlStr[i] + ControlStr[i + 1];
                                    }
                                }
                                else
                                {
                                    Resultante = ControlStr[i] + ControlStr[i + 1];
                                }
                            }
                            else
                            {
                                if (i < Operadores.Count - 1)
                                {
                                    if (Operadores[i + 1] == 'x' | Operadores[i + 1] == '÷') 
                                    {

                                    }
                                    else
                                    {
                                        Resultante += ControlStr[i+1];
                                    }
                                }
                                else
                                {
                                    Resultante += ControlStr[i+1];
                                }
                            }
                            break;
                    }
                }
                    Fnegative = false;
                    tb_pricipal.Text = Convert.ToString(Resultante);
            }
            catch(Exception e)
            {
                tb_pricipal.Text = "ERROR!";
                Console.WriteLine(e);
            }
        }
    }
}
