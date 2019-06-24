//Programa que utiliza os conceitos de Algoritmos em Grafos, para definir distância entre cidades.
//Desenvolvedores: Amaury Alexandrino da Costa - 499960
//-----------------Felipe Henrique Rocha - 495779
//-----------------João Fernando - 499972
//Data de desenvolvimento: 21/09/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_Distancia_entre_Cidades
{
    static class Program
    {
        //-----Declaração da variável G do tipo Grafo.
        public static Grafo G; 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Entrada());
        }
    }
}
