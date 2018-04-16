using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_crossroad
{
    class Tablero
    {
        int tamanoX;
        int tamanoY;
        public List<Pieza> piezas { get; set; }
        public List<Carro> carros { get; set; }

        public Tablero(int tamanoX, int tamanoY)
        {
            this.tamanoX = tamanoX;
            this.tamanoY = tamanoY;
        }



    }
}
