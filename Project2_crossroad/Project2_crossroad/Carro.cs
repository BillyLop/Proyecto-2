using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_crossroad
{
    class Carro : Pieza
    {
        string nombre;
        public string direccion { get; set; }

        public Carro (string nombre, int posX, int posY)
        {
            this.nombre = nombre;
            this.tipo = "Carro";
            this.posX = posX;
            this.posY = posY;
            if (nombre == "Azul")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/azul.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }

            if (nombre == "Azulregreso")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/azulregreso.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }
        }

        public void avanzar()
        {
            if (direccion == "Izquierda")
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
            else
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
            
        }

    }
}
