using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memoria_1._0._0
{
    public class Objeto
    {
        public int ID;
        public string nome;
        public int tipo;
        public Image imagem;
     
        public List<Objeto> listaObj;

        public int tempo = 0;
        public int jogadas = 0;

        string aplicacao = Application.StartupPath;

        public Objeto()
        {
            try
            {
                listaObj = new List<Objeto>()
                {
                    new Objeto(1, "Abacaxi", 0, Image.FromFile(aplicacao + @"\Frutas\abacaxi.png")),
                    new Objeto(2, "Ameixa", 0, Image.FromFile(aplicacao + @"\Frutas\ameixa.png")),
                    new Objeto(3, "Banana", 0, Image.FromFile(aplicacao + @"\Frutas\banana.png")),
                    new Objeto(4, "Cereja", 0, Image.FromFile(aplicacao + @"\Frutas\cereja.png")),
                    new Objeto(5, "Coco", 0, Image.FromFile(aplicacao + @"\Frutas\coco.png")),
                    new Objeto(6, "Kiwi", 0, Image.FromFile(aplicacao + @"\Frutas\kiwi.png")),
                    new Objeto(7, "Laranja", 0, Image.FromFile(aplicacao + @"\Frutas\laranja.png")),
                    new Objeto(8, "Limão", 0, Image.FromFile(aplicacao + @"\Frutas\limão.png")),
                    new Objeto(9, "Maçã", 0, Image.FromFile(aplicacao + @"\Frutas\maça.png")),
                    new Objeto(10, "Manga", 0, Image.FromFile(aplicacao + @"\Frutas\manga.png")),
                    new Objeto(11, "Melancia", 0, Image.FromFile(aplicacao + @"\Frutas\melancia.png")),
                    new Objeto(12, "Morango", 0, Image.FromFile(aplicacao + @"\Frutas\morango.png")),
                    new Objeto(13, "Pêra", 0, Image.FromFile(aplicacao + @"\Frutas\pera.png")),
                    new Objeto(14, "Pêssego", 0, Image.FromFile(aplicacao + @"\Frutas\pessego.png")),
                    new Objeto(15, "Uva", 0, Image.FromFile(aplicacao + @"\Frutas\uva.png")),

                    new Objeto(16, "Alce", 1, Image.FromFile(aplicacao + @"\Animais\alce.png")),
                    new Objeto(17, "Avestruz", 1, Image.FromFile(aplicacao + @"\Animais\avestruz.png")),
                    new Objeto(18, "Baleia", 1, Image.FromFile(aplicacao + @"\Animais\baleia.png")),
                    new Objeto(19, "Bode", 1, Image.FromFile(aplicacao + @"\Animais\bode.png")),
                    new Objeto(20, "Cachorro", 1, Image.FromFile(aplicacao + @"\Animais\cachorro.png")),
                    new Objeto(21, "Camarão", 1, Image.FromFile(aplicacao + @"\Animais\camarao.png")),
                    new Objeto(22, "Carneiro", 1, Image.FromFile(aplicacao + @"\Animais\carneiro.png")),
                    new Objeto(23, "Castor", 1, Image.FromFile(aplicacao + @"\Animais\castor.png")),
                    new Objeto(24, "Cavalo", 1, Image.FromFile(aplicacao + @"\Animais\cavalo.png")),
                    new Objeto(25, "Cobra", 1, Image.FromFile(aplicacao + @"\Animais\cobra.png")),
                    new Objeto(26, "Coelho", 1, Image.FromFile(aplicacao + @"\Animais\coelho.png")),
                    new Objeto(27, "Coruja", 1, Image.FromFile(aplicacao + @"\Animais\coruja.png")),
                    new Objeto(28, "Elefante", 1, Image.FromFile(aplicacao + @"\Animais\elefante.png")),
                    new Objeto(29, "Esquilo", 1, Image.FromFile(aplicacao + @"\Animais\esquilo.png")),
                    new Objeto(30, "Foca", 1, Image.FromFile(aplicacao + @"\Animais\foca.png")),
                    new Objeto(31, "Galinha", 1, Image.FromFile(aplicacao + @"\Animais\galinha.png")),
                    new Objeto(32, "Galo", 1, Image.FromFile(aplicacao + @"\Animais\galo.png")),
                    new Objeto(33, "Gato", 1, Image.FromFile(aplicacao + @"\Animais\gato.png")),
                    new Objeto(34, "Girafa", 1, Image.FromFile(aplicacao + @"\Animais\girafa.png")),
                    new Objeto(35, "Golfinho", 1, Image.FromFile(aplicacao + @"\Animais\golfinho.png")),
                    new Objeto(36, "Hipopótamo", 1, Image.FromFile(aplicacao + @"\Animais\hipopotamo.png")),
                    new Objeto(37, "Jacaré", 1, Image.FromFile(aplicacao + @"\Animais\jacare.png")),
                    new Objeto(38, "Lagarta", 1, Image.FromFile(aplicacao + @"\Animais\lagarta.png")),
                    new Objeto(39, "Leão", 1, Image.FromFile(aplicacao + @"\Animais\leão.png")),
                    new Objeto(40, "Lêmure", 1, Image.FromFile(aplicacao + @"\Animais\lemure.png")),
                    new Objeto(41, "Macaco", 1, Image.FromFile(aplicacao + @"\Animais\macaco.png")),
                    new Objeto(42, "Morcego", 1, Image.FromFile(aplicacao + @"\Animais\morcego.png")),
                    new Objeto(43, "Ovelha", 1, Image.FromFile(aplicacao + @"\Animais\ovelha.png")),
                    new Objeto(44, "Panda", 1, Image.FromFile(aplicacao + @"\Animais\panda.png")),
                    new Objeto(45, "Passarinho", 1, Image.FromFile(aplicacao + @"\Animais\passarinho.png")),
                    new Objeto(46, "Pássaro Azul", 1, Image.FromFile(aplicacao + @"\Animais\passaroazul.png")),
                    new Objeto(47, "Pássaro Branco", 1, Image.FromFile(aplicacao + @"\Animais\passarobranco.png")),
                    new Objeto(48, "Pato", 1, Image.FromFile(aplicacao + @"\Animais\pato.png")),
                    new Objeto(49, "Pavão", 1, Image.FromFile(aplicacao + @"\Animais\pavao.png")),
                    new Objeto(50, "Peixe", 1, Image.FromFile(aplicacao + @"\Animais\peixe.png")),
                    new Objeto(51, "Peixe Bola", 1, Image.FromFile(aplicacao + @"\Animais\peixebola.png")),
                    new Objeto(52, "Peru", 1, Image.FromFile(aplicacao + @"\Animais\peru.png")),
                    new Objeto(53, "Pinguim", 1, Image.FromFile(aplicacao + @"\Animais\pinguim.png")),
                    new Objeto(54, "Porco", 1, Image.FromFile(aplicacao + @"\Animais\porco.png")),
                    new Objeto(55, "Rato", 1, Image.FromFile(aplicacao + @"\Animais\rato.png")),
                    new Objeto(56, "Rinoceronte", 1, Image.FromFile(aplicacao + @"\Animais\rinoceronte.png")),
                    new Objeto(57, "Sapo", 1, Image.FromFile(aplicacao + @"\Animais\sapo.png")),
                    new Objeto(58, "Tigre", 1, Image.FromFile(aplicacao + @"\Animais\tigre.png")),
                    new Objeto(59, "Touro", 1, Image.FromFile(aplicacao + @"\Animais\touro.png")),
                    new Objeto(60, "Tubarão", 1, Image.FromFile(aplicacao + @"\Animais\tubarao.png")),
                    new Objeto(61, "Tucano", 1, Image.FromFile(aplicacao + @"\Animais\tucano.png")),
                    new Objeto(62, "Urso", 1, Image.FromFile(aplicacao + @"\Animais\urso.png")),
                    new Objeto(63, "Urso Polar", 1, Image.FromFile(aplicacao + @"\Animais\ursopolar.png")),
                    new Objeto(64, "Vaca", 1, Image.FromFile(aplicacao + @"\Animais\vaca.png")),
                    new Objeto(65, "Veado", 1, Image.FromFile(aplicacao + @"\Animais\veado.png")),
                    new Objeto(66, "Zebra", 1, Image.FromFile(aplicacao + @"\Animais\zebra.png"))

                };

                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
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
