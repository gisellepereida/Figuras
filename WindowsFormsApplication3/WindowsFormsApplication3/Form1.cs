using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        enum TipoFigura { Rectangulo, Circulo };
        private TipoFigura figura_actual;
        private List<Figura> rectangulos;
        private List<Figura> circulos;


        public Form1()
        {
            figura_actual = TipoFigura.Circulo;
            rectangulos = new List<Figura>();
            circulos = new List<Figura>();
            InitializeComponent();
            circulosToolStripMenuItem.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                contextMenuStrip1.Show(this, e.X, e.Y);
            }
            else if (MouseButtons.Left == e.Button)
            {
                if (figura_actual == TipoFigura.Circulo)
                {
                    Circulo c = new Circulo(e.X, e.Y);
                    c.Dibuja(this);
                    circulos.Add(c);

                }
                else if (figura_actual == TipoFigura.Rectangulo)
                {
                    Rectangulo r = new Rectangulo(e.X, e.Y);
                    r.Dibuja(this);
                    rectangulos.Add(r);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Polimorfismo
            foreach (Figura r in rectangulos)
                r.Dibuja(this);
        }

        
    }
}
