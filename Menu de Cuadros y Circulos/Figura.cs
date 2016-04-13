using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Menu_de_Cuadros_y_Circulos
{
    abstract class Figura
    {
        protected int X, Y;
        protected Pen pluma;
        protected int ancho, largo;

        public Figura(int x, int y)
        {
            X = x;
            Y = y;

            pluma = new Pen(Color.Red, 2);
            ancho = 20;
            largo = 20;
        }

        public abstract void Dibuja(Form f);

    }

    class Rectangulo : Figura
    {
        public Rectangulo(int x, int y) : base(x, y)
        {
        }
        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, X, Y, ancho, largo);
        }
    }

    class Circulo : Figura
    {
        public Circulo(int x, int y)
            : base(x, y)
        {
        }
        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawEllipse(pluma, X, Y, ancho, largo);
        }
    }
}