using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Menu_de_Cuadros_y_Circulos
{
    abstract class Figura:IComparable
    {
        protected int X, Y;
        protected Pen pluma;
        protected int ancho, largo;
        protected SolidBrush brocha;

        public Figura(int x, int y)
        {
            X = x;
            Y = y;
            SolidBrush b = new SolidBrush(Color.Blue);
            // pluma = new Pen(Color.Red, 2);
            pluma = new Pen(Color.Aqua,2);
            Random rnd = new Random();
            ancho = rnd.Next(10,80);
            largo = ancho;
        }

        public abstract void Dibuja(Form f);

        public int CompareTo(object obj)
        {
            return this.largo.CompareTo(((Figura)obj).largo);
        }
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
            // g.FillRectangle(brocha, X, Y, ancho, largo);
            

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
          // g.FillEllipse(brocha, X, Y, ancho, largo);
        }
    }
}