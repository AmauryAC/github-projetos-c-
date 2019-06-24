using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogos_Educativos___3_em_1
{
    public class Memoria
    {
        public int ID;
        public string nome;
        public int tipo;
        public Image imagem;

        public List<Memoria> listaImagens = new List<Memoria>()
        {                    
                    new Memoria(1, "Abacaxi", 0, Image.FromFile(Application.StartupPath + @"\Frutas\abacaxi.png")),
                    new Memoria(2, "Ameixa", 0, Image.FromFile(Application.StartupPath + @"\Frutas\ameixa.png")),
                    new Memoria(3, "Banana", 0, Image.FromFile(Application.StartupPath + @"\Frutas\banana.png")),
                    new Memoria(4, "Cereja", 0, Image.FromFile(Application.StartupPath + @"\Frutas\cereja.png")),
                    new Memoria(5, "Coco", 0, Image.FromFile(Application.StartupPath + @"\Frutas\coco.png")),
                    new Memoria(6, "Kiwi", 0, Image.FromFile(Application.StartupPath + @"\Frutas\kiwi.png")),
                    new Memoria(7, "Laranja", 0, Image.FromFile(Application.StartupPath + @"\Frutas\laranja.png")),
                    new Memoria(8, "Limão", 0, Image.FromFile(Application.StartupPath + @"\Frutas\limão.png")),
                    new Memoria(9, "Maçã", 0, Image.FromFile(Application.StartupPath + @"\Frutas\maça.png")),
                    new Memoria(10, "Manga", 0, Image.FromFile(Application.StartupPath + @"\Frutas\manga.png")),
                    new Memoria(11, "Melancia", 0, Image.FromFile(Application.StartupPath + @"\Frutas\melancia.png")),
                    new Memoria(12, "Morango", 0, Image.FromFile(Application.StartupPath + @"\Frutas\morango.png")),
                    new Memoria(13, "Pêra", 0, Image.FromFile(Application.StartupPath + @"\Frutas\pera.png")),
                    new Memoria(14, "Pêssego", 0, Image.FromFile(Application.StartupPath + @"\Frutas\pessego.png")),
                    new Memoria(15, "Uva", 0, Image.FromFile(Application.StartupPath + @"\Frutas\uva.png")),

                    new Memoria(16, "Alce", 1, Image.FromFile(Application.StartupPath + @"\Animais\alce.png")),
                    new Memoria(17, "Avestruz", 1, Image.FromFile(Application.StartupPath + @"\Animais\avestruz.png")),
                    new Memoria(18, "Baleia", 1, Image.FromFile(Application.StartupPath + @"\Animais\baleia.png")),
                    new Memoria(19, "Bode", 1, Image.FromFile(Application.StartupPath + @"\Animais\bode.png")),
                    new Memoria(20, "Cachorro", 1, Image.FromFile(Application.StartupPath + @"\Animais\cachorro.png")),
                    new Memoria(21, "Camarão", 1, Image.FromFile(Application.StartupPath + @"\Animais\camarao.png")),
                    new Memoria(22, "Carneiro", 1, Image.FromFile(Application.StartupPath + @"\Animais\carneiro.png")),
                    new Memoria(23, "Castor", 1, Image.FromFile(Application.StartupPath + @"\Animais\castor.png")),
                    new Memoria(24, "Cavalo", 1, Image.FromFile(Application.StartupPath + @"\Animais\cavalo.png")),
                    new Memoria(25, "Cobra", 1, Image.FromFile(Application.StartupPath + @"\Animais\cobra.png")),
                    new Memoria(26, "Coelho", 1, Image.FromFile(Application.StartupPath + @"\Animais\coelho.png")),
                    new Memoria(27, "Coruja", 1, Image.FromFile(Application.StartupPath + @"\Animais\coruja.png")),
                    new Memoria(28, "Elefante", 1, Image.FromFile(Application.StartupPath + @"\Animais\elefante.png")),
                    new Memoria(29, "Esquilo", 1, Image.FromFile(Application.StartupPath + @"\Animais\esquilo.png")),
                    new Memoria(30, "Foca", 1, Image.FromFile(Application.StartupPath + @"\Animais\foca.png")),
                    new Memoria(31, "Galinha", 1, Image.FromFile(Application.StartupPath + @"\Animais\galinha.png")),
                    new Memoria(32, "Galo", 1, Image.FromFile(Application.StartupPath + @"\Animais\galo.png")),
                    new Memoria(33, "Gato", 1, Image.FromFile(Application.StartupPath + @"\Animais\gato.png")),
                    new Memoria(34, "Girafa", 1, Image.FromFile(Application.StartupPath + @"\Animais\girafa.png")),
                    new Memoria(35, "Golfinho", 1, Image.FromFile(Application.StartupPath + @"\Animais\golfinho.png")),
                    new Memoria(36, "Hipopótamo", 1, Image.FromFile(Application.StartupPath + @"\Animais\hipopotamo.png")),
                    new Memoria(37, "Jacaré", 1, Image.FromFile(Application.StartupPath + @"\Animais\jacare.png")),
                    new Memoria(38, "Lagarta", 1, Image.FromFile(Application.StartupPath + @"\Animais\lagarta.png")),
                    new Memoria(39, "Leão", 1, Image.FromFile(Application.StartupPath + @"\Animais\leão.png")),
                    new Memoria(40, "Lêmure", 1, Image.FromFile(Application.StartupPath + @"\Animais\lemure.png")),
                    new Memoria(41, "Macaco", 1, Image.FromFile(Application.StartupPath + @"\Animais\macaco.png")),
                    new Memoria(42, "Morcego", 1, Image.FromFile(Application.StartupPath + @"\Animais\morcego.png")),
                    new Memoria(43, "Ovelha", 1, Image.FromFile(Application.StartupPath + @"\Animais\ovelha.png")),
                    new Memoria(44, "Panda", 1, Image.FromFile(Application.StartupPath + @"\Animais\panda.png")),
                    new Memoria(45, "Passarinho", 1, Image.FromFile(Application.StartupPath + @"\Animais\passarinho.png")),
                    new Memoria(46, "Pássaro Azul", 1, Image.FromFile(Application.StartupPath + @"\Animais\passaroazul.png")),
                    new Memoria(47, "Pássaro Branco", 1, Image.FromFile(Application.StartupPath + @"\Animais\passarobranco.png")),
                    new Memoria(48, "Pato", 1, Image.FromFile(Application.StartupPath + @"\Animais\pato.png")),
                    new Memoria(49, "Pavão", 1, Image.FromFile(Application.StartupPath + @"\Animais\pavao.png")),
                    new Memoria(50, "Peixe", 1, Image.FromFile(Application.StartupPath + @"\Animais\peixe.png")),
                    new Memoria(51, "Peixe Bola", 1, Image.FromFile(Application.StartupPath + @"\Animais\peixebola.png")),
                    new Memoria(52, "Peru", 1, Image.FromFile(Application.StartupPath + @"\Animais\peru.png")),
                    new Memoria(53, "Pinguim", 1, Image.FromFile(Application.StartupPath + @"\Animais\pinguim.png")),
                    new Memoria(54, "Porco", 1, Image.FromFile(Application.StartupPath + @"\Animais\porco.png")),
                    new Memoria(55, "Rato", 1, Image.FromFile(Application.StartupPath + @"\Animais\rato.png")),
                    new Memoria(56, "Rinoceronte", 1, Image.FromFile(Application.StartupPath + @"\Animais\rinoceronte.png")),
                    new Memoria(57, "Sapo", 1, Image.FromFile(Application.StartupPath + @"\Animais\sapo.png")),
                    new Memoria(58, "Tigre", 1, Image.FromFile(Application.StartupPath + @"\Animais\tigre.png")),
                    new Memoria(59, "Touro", 1, Image.FromFile(Application.StartupPath + @"\Animais\touro.png")),
                    new Memoria(60, "Tubarão", 1, Image.FromFile(Application.StartupPath + @"\Animais\tubarao.png")),
                    new Memoria(61, "Tucano", 1, Image.FromFile(Application.StartupPath + @"\Animais\tucano.png")),
                    new Memoria(62, "Urso", 1, Image.FromFile(Application.StartupPath + @"\Animais\urso.png")),
                    new Memoria(63, "Urso Polar", 1, Image.FromFile(Application.StartupPath + @"\Animais\ursopolar.png")),
                    new Memoria(64, "Vaca", 1, Image.FromFile(Application.StartupPath + @"\Animais\vaca.png")),
                    new Memoria(65, "Veado", 1, Image.FromFile(Application.StartupPath + @"\Animais\veado.png")),
                    new Memoria(66, "Zebra", 1, Image.FromFile(Application.StartupPath + @"\Animais\zebra.png"))
        };

        public int tempo;
        public int jogadas;

        public Memoria()
        {
        }

        public Memoria(int _ID, string n, int t, Image img)
        {
            ID = _ID;
            nome = n;
            tipo = t;
            imagem = img;
        }
    }
}
