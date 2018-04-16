using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_crossroad
{
    class Pieza
    {
        public string tipo { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public PictureBox figura {get; set;}

        public Pieza() { }

        public Pieza (string tipo, int posX, int posY)
        {
            this.tipo = tipo;
            this.posX = posX;
            this.posY = posY;
            if (tipo == "Pasto")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/pasto.png");
                figura.Size = new Size(60, 50);

            }
            else 
            {
                if (tipo == "Carretera")
                { 
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/carretera.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    figura = new PictureBox();
                    figura.Image = Image.FromFile("../../imagenes/carreteraabajo.png");
                    figura.Size = new Size(60, 50);
                    figura.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
