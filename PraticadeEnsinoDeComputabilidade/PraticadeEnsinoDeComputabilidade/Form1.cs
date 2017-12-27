using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PraticadeEnsinoDeComputabilidade
{
    public partial class Form1 : Form
    {
        public Dictionary<char, int> Propriedades { get; set; }
        public static readonly Dictionary<char, int> Operadores = new Dictionary<char, int>() { { '+', 2 }, { '-', 2 }, { '/', 2 }, { '*', 3 } };
        public const string Variaveis = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string Parenteses = "()";
        public string Valores { get; set; }

        public Form1()
        {
            InitializeComponent();
        }



        private void btnConverterPosFixa_Click(object sender, EventArgs e)
        {
            SalvarVariaveis(txtFormaInfixa.Text);
            this.txtFormaPosfixa.Text = ConverterPosFixa(txtFormaInfixa.Text);
        }

        private void btnConverterInfixa_Click(object sender, EventArgs e)
        {
            this.txtFormaInfixa.Text = ConverterInfixa(this.txtFormaPosfixa.Text);
        }

        private void btnCalcularInfixa_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularPosfixa_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularIndefinada_Click(object sender, EventArgs e)
        {

        }

        private void btnConverterFormaIndefinida_Click(object sender, EventArgs e)
        {
            this.txtFormaIndefinida.Text = ConverterFormaIndefinida(this.txtFormaIndefinida.Text);
        }

        private void btnCalcularResultado_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text = this.AvaliarExpressao(this.txtFormaInfixa.Text);
        }


        #region Helpers

        private bool IsOperando(char caracter)
        {
            return (Variaveis.Contains(caracter));
        }

        private bool IsOperador(char caracter)
        {
            return (Operadores.ContainsKey(caracter));
        }

        private string PegarValor(char letra)
        {
            return Propriedades[letra].ToString();
        }

        #endregion

        private string ConverterPosFixa(string formInfixa)
        {
            string resultado = null;
            Stack pilha = new Stack();

            foreach (char caracter in formInfixa)
            {
                if (IsOperando(caracter))
                {
                    resultado += caracter;
                }
                else if (IsOperador(caracter))
                {
                    int prioridade = ObterPrioridade(caracter);

                    while ((pilha.Count != 0) && (ObterPrioridade(Convert.ToChar(pilha.Peek())) >= prioridade))
                    {
                        resultado += pilha.Pop().ToString();
                    }

                    pilha.Push(caracter);
                }
                else if ('(' == caracter)
                {
                    pilha.Push(caracter);
                }
                else if (')' == caracter)
                {
                    string item = pilha.Pop().ToString();

                    while (!item.Equals("("))
                    {
                        resultado += item;
                        item = pilha.Pop().ToString();
                    }
                }
            }

            while (pilha.Count != 0)
            {
                resultado += pilha.Pop().ToString();
            }

            return resultado;
        }

        private String AvaliarExpressao(string expInfixa)
        {
            string expPosfixa = ConverterPosFixa(expInfixa);
            Stack pilha = new Stack();

            foreach (char caracter in expPosfixa)
            {
                if (IsOperando(caracter))
                {
                    pilha.Push(PegarValor(caracter));
                }
                else
                {
                    if (IsOperador(caracter))
                    {
                        double y = Convert.ToDouble(pilha.Pop());
                        double x = Convert.ToDouble(pilha.Pop());

                        pilha.Push(ResolvaAContinha(caracter,x,y));
                    }
                }
            }
            return pilha.Pop().ToString();
        }

        private string ResolvaAContinha(char caracter, double x, double y)
        {
            string resultOperacao = null;

            switch (caracter)
            {
                case '+':
                    resultOperacao = Convert.ToString(x + y);
                    break;
                case '-':
                    resultOperacao = Convert.ToString(x - y);
                    break;
                case '/':
                    resultOperacao = Convert.ToString(x / y);
                    break;
                case '*':
                    resultOperacao = Convert.ToString(x * y);
                    break;
            }

            return resultOperacao;
        }
        private int ObterPrioridade(char caracter)
        {
            try
            {
                return Operadores[caracter];
            }
            catch (KeyNotFoundException e)
            {
                return 1;
            }
        }

        private void SalvarVariaveis(string variaveis)
        {
            string varia = variaveis.Where(item => IsOperando(item)).Aggregate("", (current, item) => current + item);

            string[] valores = this.txtValoresVariaveis.Text.Split(',');

            this.Propriedades = new Dictionary<char, int>();

            for (int i = 0; i < varia.Count(); i++)
            {
                Propriedades.Add(varia[i], Convert.ToInt32(valores[i]));
            }
        }

        private string ConverterInfixa(string formPosfixa)
        {
            string resultado = null;
            Stack pilha = new Stack();

            foreach (char caracter in formPosfixa)
            {
                if (IsOperando(caracter))
                {
                    pilha.Push(caracter);
                }
                else if (IsOperador(caracter))
                {
                    //int prioridade = ObterPrioridade(caracter);
                    string operadorAux1 = pilha.Pop().ToString();
                    string operadorAux2 = pilha.Pop().ToString();

                    pilha.Push("("+operadorAux2+caracter+operadorAux1+")");
                }
            }

            while (pilha.Count != 0)
            {
                resultado += pilha.Pop().ToString();
            }

            return resultado;
        }

        public string ConverterFormaIndefinida(string texto)
        {
            int operandoCount = 0;
            int operadorCount = 0;
            int stringLength = 0;
            string text = texto;

            while (stringLength < this.txtFormaIndefinida.Text.Length && operandoCount <= 1 && operadorCount <= 1)
            {
                if (IsOperando(text[stringLength]))
                {
                    if (operadorCount <= 1)
                    {
                        operadorCount = 0;
                    }
                    operandoCount++;
                }
                else if (IsOperador(text[stringLength]))
                {
                    if (operandoCount <= 1)
                    {
                        operandoCount = 0;
                    }
                    operadorCount++;
                }
                stringLength++;
            }

            if (operadorCount > 1 || operandoCount > 1)
            {
                return ConverterInfixa(this.txtFormaIndefinida.Text);
            }
            else
            {
                return ConverterPosFixa(this.txtFormaIndefinida.Text);
            }
        }
    }
}
