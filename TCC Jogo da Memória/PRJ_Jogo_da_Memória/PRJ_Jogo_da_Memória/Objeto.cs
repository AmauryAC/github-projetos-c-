using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_Jogo_da_Memória
{
    public class Objeto
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public int tipo { get; set; }
        public Image imagem { get; set; }

        public List<Objeto> listaObj;

        public int tempo = 0;
        public int tentativas = 0;

        public Objeto()
        {
            listaObj = new List<Objeto>()
            {
                new Objeto(1, "Abacaxi", 0, Properties.Resources.abacaxi),
                new Objeto(2, "Banana", 0, Properties.Resources.banana),
                new Objeto(3, "Bode", 1, Properties.Resources.bode),
                new Objeto(4, "Burro", 1, Properties.Resources.burro),
                new Objeto(5, "Cereja", 0, Properties.Resources.cereja),
                new Objeto(6, "Elefante", 1, Properties.Resources.elefante),
                new Objeto(7, "Girafa", 1, Properties.Resources.girafa),
                new Objeto(8, "Hipopótamo", 1, Properties.Resources.hipopótamo),
                new Objeto(9, "Laranja", 0, Properties.Resources.laranja),
                new Objeto(10, "Maça", 0, Properties.Resources.maçã),
                new Objeto(11, "Melancia", 0, Properties.Resources.melancia),
                new Objeto(12, "Morango", 0, Properties.Resources.morango),
                new Objeto(13, "Porco", 1, Properties.Resources.porco),
                new Objeto(14, "Uva", 0, Properties.Resources.uva),
                new Objeto(15, "Vaca", 1, Properties.Resources.vaca),
                new Objeto(16, "Zebra", 1, Properties.Resources.zebra)
            };
        }

        public Objeto(int _ID, string n, int t, Image img)
        {
            ID = _ID;
            nome = n;
            tipo = t;
            imagem = img;
        }
    }
}
