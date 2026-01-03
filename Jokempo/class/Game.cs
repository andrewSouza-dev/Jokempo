using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokempo
{
    class Game
    {
        public enum Resultado 
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")
        };

        public Image ImgPc {  get; private set; }

        public Image ImgPlayer { get; private set; }

        public Resultado Jogar(int player)
        {
            int pc = JogadaPC();

            ImgPlayer = images[player];
            ImgPc = images[pc];

            if (player == pc)
            {
                return Resultado.Empatar;
            } 
            else if ((player == 0 && pc == 1) || (player == 1 && pc == 2) || (player == 2 && pc == 0))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }

            
        }

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0;
            } 
            else if (mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
