using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project2_crossroad
{
    public partial class CrossRoad : Form
    {
        Tablero tablero;
        Personaje personaje;
        Carro carro;
        public void CreaTablero()
        {

            tablero = new Tablero(12, 10);
            tablero.piezas = new List<Pieza>();
            tablero.carros = new List<Carro>();
            //llenar tablero
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Pieza pieza = new Pieza("Pasto", x, y);
                    tablero.piezas.Add(pieza);
                }
            }

            for (int x = 0; x < 10; x++)
            {
                Pieza pieza = new Pieza("Carretera", x, 2);
                tablero.piezas.Add(pieza);
            }
            for (int x = 0; x < 10; x++)
            {
                Pieza pieza = new Pieza("Carreteraabajo", x, 3);
                tablero.piezas.Add(pieza);
            }
            for (int x = 0; x < 10; x++)
            {
                for (int y = 4; y < 6; y++)
                {
                    Pieza pieza = new Pieza("Pasto", x, y);
                    tablero.piezas.Add(pieza);
                }
            }
            for (int x = 0; x < 10; x++)
            {
                Pieza pieza = new Pieza("Carretera", x, 6);
                tablero.piezas.Add(pieza);
            }
            for (int x = 0; x < 10; x++)
            {
                Pieza pieza = new Pieza("Carreteraabajo", x, 7);
                tablero.piezas.Add(pieza);
            }
            for (int x = 0; x < 10; x++)
            {
                for (int y = 8; y < 10; y++)
                {
                    Pieza pieza = new Pieza("Pasto", x, y);
                    tablero.piezas.Add(pieza);
                }
            }

            personaje = new Personaje("Kirito", 6, 9);
            tablero.piezas.Add(personaje);

            carro = new Carro("Azul", 9, 2);
            carro.direccion = "Izquierda";
            tablero.piezas.Add(carro);
            //dibujar tablero
            foreach (Pieza pieza in tablero.piezas)
            {
                int posX = 10 + (pieza.posX * 60);
                int posY = 40 + (pieza.posY * 50);
                pieza.figura.Location = new Point(posX, posY);
                this.Controls.Add(pieza.figura);
                if (pieza.tipo == "Personaje")
                {
                    pieza.figura.BackColor = Color.Transparent;
                    pieza.figura.BringToFront();
                }
                if (pieza.tipo == "Carro")
                {
                    pieza.figura.BackColor = Color.Transparent;
                    pieza.figura.BringToFront();
                }
            }



            //this.Controls.Add(pieza.figura);
        }
        public CrossRoad()
        {
            InitializeComponent();
            CreaTablero();

        }
        private void dibujarCarro(Carro carro)
        {
            int posX = 10 + (carro.posX * 60);
            int posY = 40 + (carro.posY * 50);
            carro.figura.Location = new Point(posX, posY);
            carro.figura.BackColor = Color.Transparent;
            carro.figura.BringToFront();
        }
        private void dibujarPersonaje(int x, int y)
        {
            int posX = 10 + (x * 60);
            int posY = 40 + (y * 50);
            personaje.figura.Location = new Point(posX, posY);
            personaje.figura.BackColor = Color.Transparent;
            personaje.figura.BringToFront();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            personaje.moverAdelante();
            dibujarPersonaje(personaje.posX, personaje.posY);

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            personaje.moverIzquierda();
            dibujarPersonaje(personaje.posX, personaje.posY);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            personaje.moverDerecha();
            dibujarPersonaje(personaje.posX, personaje.posY);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            personaje.moverAtras();
            dibujarPersonaje(personaje.posX, personaje.posY);
        }
        void avanzarCarroAsync(Carro carro)
        {
            for (int x = 0; x < 2; x++)
            {
                carro.avanzar();
                dibujarCarro(carro);

            }

        }

        private void timerCarro1_Tick(object sender, EventArgs e)
        {
            avanzarCarroAsync(carro);
        }


    }
}
