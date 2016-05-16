using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        enum TipoFigura { REctangulo, Circulo };
        private TipoFigura figura_act;
        private List<Figura> rectangulos;

        public Form1()
        {
            figura_act = TipoFigura.Circulo;
            rectangulos = new List<Figura>();
            InitializeComponent();
            circuloToolStripMenuItem.Checked = true;
        }
    
}
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
