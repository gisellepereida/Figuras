using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApplication2
{
    class Figura: IComparable
    {
        protected int X, Y;
        protected Pen pluma;
        protected Brush brocha;
        protected Color color_cont, color_rell;
        protected int ancho, largo;

        public int Figura(int x, int y)
        {

            X = x;
            Y = y;

            pluma = new Pen(Color.Black, 2);
            ancho = 50;
        }
        public abstract void Dibuja(Form f);

        class Rectangulo : Figura
        { public Rectangulo(int x, int y) : base(x y)
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
            public Circulo(int x, int y): base  (x,y)
            {
                Graphics g = f.CreateGraphics();
                g.DrawEllipse(pluma, X, Y, ancho, largo);
            }
        }


    }
}
