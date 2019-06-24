using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Simples
{
    public class Calculadora
    {
        private bool ligada;
        private double[] vetOp;

        public bool Ligada
        {
            get { return ligada; }
            set { ligada = value; }
        }

        public double[] VetOp
        {
            get { return vetOp; }
            set { vetOp = value; }
        }

        public Calculadora()
        {
            ligada = false;

            vetOp = new double[1];
            vetOp[0] = 0;
        }

        public void LigarZerarDesligar(int botao)
        {
            vetOp[0] = 0;

            if (botao == 1 && ligada == false)  //Botão 1 => ON/C
                ligada = true;
            else if (botao == 0)    //Botão 0 => OFF
                ligada = false;
        }

        public void Operacao(int op, double num)
        {
            if (op == 1)    //Soma
                vetOp[0] += num;
            else if (op == 2)   //Subtração
                vetOp[0] -= num;
            else if (op == 3)   //Multiplicação
                vetOp[0] *= num;
            else if (op == 4)   //Divisão
                vetOp[0] /= num;
            else if (op == 5)   //Radiciação
                vetOp[0] = Math.Sqrt(num);
            else if (op == 6)   //Porcentagem
                vetOp[0] = num / 100;
        }
    }
}
