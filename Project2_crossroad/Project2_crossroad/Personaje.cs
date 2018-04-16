using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_crossroad
{
    class Personaje : Pieza
    {
        string nombre;

        public Personaje (string nombre, int posX, int posY)
        {
            this.nombre = nombre;
            this.tipo = "Personaje";
            this.posX = posX;
            this.posY = posY;
            if (nombre == "Kirito")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/personaje1.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }
        }

        public void moverAdelante()
        {
            if (posY == 0)
            {
                posY = 0;
            }
            else
            {
                posY = posY - 1;
            }
        }

        public void moverIzquierda()
        {
            if (posX == 0)
            {
                posX = 0;
            }
            else
            {
                posX = posX - 1;
            }
        }

        public void moverDerecha()
        {
            if (posX == 9)
            {
                posX = 9;
            }
            else
            {
                posX = posX + 1;
            }
        }

        public void moverAtras()
        {
            if (posY == 9)
            {
                posY = 9;
            }
            else
            {
                posY = posY + 1;
            }
        }
    }
}
