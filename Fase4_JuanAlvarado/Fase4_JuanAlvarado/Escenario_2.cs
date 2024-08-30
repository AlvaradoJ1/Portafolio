using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4_JuanAlvarado
{
    public partial class Escenario_2 : Form
    {
        public Escenario_2()
        {
            InitializeComponent();
        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //diseño del nodo raiz
            Graphics nodo;
            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.Black, 320, 30, 35, 35);
            nodo.DrawString("18", Font, Brushes.White, 330, 40);
            Pen myNodoRaiz = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodoRaiz, 320, 30, 35, 35);

            //diseño del nodo 1
            nodo.FillEllipse(Brushes.Black, 200, 80, 35, 35);
            nodo.DrawString("9", Font, Brushes.White, 210, 90);
            Pen myNodo1z = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo1z, 200, 80, 35, 35);

            //diseño del nodo 2
            nodo.FillEllipse(Brushes.Black, 440, 80, 35, 35);
            nodo.DrawString("25", Font, Brushes.White, 450, 90);
            Pen myNodo1d = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo1d, 440, 80, 35, 35);

            //diseño de los nodos del segundo piso
            nodo.FillEllipse(Brushes.Black, 125, 160, 35, 35);
            nodo.DrawString("7", Font, Brushes.White, 135, 170);
            Pen myNodo2zz = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo2zz, 125, 160, 35, 35);

            nodo.FillEllipse(Brushes.Black, 275, 160, 35, 35);
            nodo.DrawString("12", Font, Brushes.White, 285, 170);
            Pen myNodo2 = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo2, 275, 160, 35, 35);

            nodo.FillEllipse(Brushes.Black, 375, 160, 35, 35);
            nodo.DrawString("23", Font, Brushes.White, 385, 170);
            Pen myNodo2d = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo2d, 375, 160, 35, 35);

            nodo.FillEllipse(Brushes.Black, 525, 160, 35, 35);
            nodo.DrawString("29", Font, Brushes.White, 535, 170);
            Pen myNodo2dd = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo2dd, 525, 160, 35, 35);

            //diseño de los nodos del tercer piso
            nodo.FillEllipse(Brushes.Black, 100, 220, 35, 35);
            nodo.DrawString("2", Font, Brushes.White, 112, 230);
            Pen myNodo3z = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo3z, 100, 220, 35, 35);

            nodo.FillEllipse(Brushes.Black, 150, 220, 35, 35);
            nodo.DrawString("8", Font, Brushes.White, 162, 230);
            Pen myNodo4z = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo4z, 150, 220, 35, 35);

            nodo.FillEllipse(Brushes.Black, 250, 220, 35, 35);
            nodo.DrawString("11", Font, Brushes.White, 260, 230);
            Pen myNodo5z = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo5z, 250, 220, 35, 35);

            nodo.FillEllipse(Brushes.Black, 340, 220, 35, 35);
            nodo.DrawString("21", Font, Brushes.White, 350, 230);
            Pen myNodo6z = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo6z, 340, 220, 35, 35);

            nodo.FillEllipse(Brushes.Black, 420, 220, 35, 35);
            nodo.DrawString("24", Font, Brushes.White, 430, 230);
            Pen myNodo7z = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo6z, 420, 220, 35, 35);

            nodo.FillEllipse(Brushes.Black, 560, 220, 35, 35);
            nodo.DrawString("31", Font, Brushes.White, 570, 230);
            Pen myNodo8z = new Pen(Color.Cyan, 3);
            nodo.DrawEllipse(myNodo6z, 560, 220, 35, 35);

            //dibujar líneas entre los nodos
            Pen myLinea1z = new Pen(Color.Cyan, 3);
            nodo.DrawLine(myLinea1z, 320, 55, 235, 90);
            nodo.DrawLine(myLinea1z, 355, 55, 440, 90);

            Pen myLinea2z = new Pen(Color.Cyan, 3);
            nodo.DrawLine(myLinea2z, 215, 115, 140, 160);
            nodo.DrawLine(myLinea2z, 215, 115, 285, 160);

            Pen myLinea2d = new Pen(Color.Cyan, 3);
            nodo.DrawLine(myLinea2d, 455, 115, 395, 160);
            nodo.DrawLine(myLinea2d, 455, 115, 540, 160);

            Pen myLinea3z = new Pen(Color.Cyan, 3);
            nodo.DrawLine(myLinea3z, 140, 195, 117, 220);
            nodo.DrawLine(myLinea3z, 140, 195, 167, 220);
            nodo.DrawLine(myLinea3z, 292, 195, 267, 220);

            Pen myLinea6z = new Pen(Color.Cyan, 3);
            nodo.DrawLine(myLinea6z, 395, 195, 357, 220);
            nodo.DrawLine(myLinea6z, 395, 195, 437, 220);

            Pen myLinea7z = new Pen(Color.Cyan, 3);
            nodo.DrawLine(myLinea7z, 545, 195, 575, 220);
        }

        private void preordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics preorden;
            preorden = CreateGraphics();
            preorden.DrawString("PreOrden = ", Font, Brushes.Black, 30, 280);

            Pen myPreOrden = new Pen(Color.Cyan, 3);
            preorden.DrawEllipse(myPreOrden, 95, 270, 30, 30);
            preorden.DrawString("18", Font, Brushes.Black, 102, 280);

            preorden.DrawEllipse(myPreOrden, 130, 270, 30, 30);
            preorden.DrawString("9", Font, Brushes.Black, 137, 280);

            preorden.DrawEllipse(myPreOrden, 165, 270, 30, 30);
            preorden.DrawString("7", Font, Brushes.Black, 172, 280);

            preorden.DrawEllipse(myPreOrden, 200, 270, 30, 30);
            preorden.DrawString("2", Font, Brushes.Black, 207, 280);

            preorden.DrawEllipse(myPreOrden, 235, 270, 30, 30);
            preorden.DrawString("8", Font, Brushes.Black, 242, 280);

            preorden.DrawEllipse(myPreOrden, 270, 270, 30, 30);
            preorden.DrawString("12", Font, Brushes.Black, 277, 280);

            preorden.DrawEllipse(myPreOrden, 305, 270, 30, 30);
            preorden.DrawString("11", Font, Brushes.Black, 312, 280);

            preorden.DrawEllipse(myPreOrden, 340, 270, 30, 30);
            preorden.DrawString("25", Font, Brushes.Black, 347, 280);

            preorden.DrawEllipse(myPreOrden, 375, 270, 30, 30);
            preorden.DrawString("23", Font, Brushes.Black, 382, 280);

            preorden.DrawEllipse(myPreOrden, 410, 270, 30, 30);
            preorden.DrawString("21", Font, Brushes.Black, 417, 280);

            preorden.DrawEllipse(myPreOrden, 445, 270, 30, 30);
            preorden.DrawString("24", Font, Brushes.Black, 452, 280);

            preorden.DrawEllipse(myPreOrden, 480, 270, 30, 30);
            preorden.DrawString("29", Font, Brushes.Black, 487, 280);

            preorden.DrawEllipse(myPreOrden, 515, 270, 30, 30);
            preorden.DrawString("31", Font, Brushes.Black, 522, 280);
        }

        private void inOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics preorden;
            preorden = CreateGraphics();
            preorden.DrawString("InOrden = ", Font, Brushes.Black, 30, 320);

            Pen myPreOrden = new Pen(Color.Cyan, 3);
            preorden.DrawEllipse(myPreOrden, 95, 310, 30, 30);
            preorden.DrawString("2", Font, Brushes.Black, 102, 320);

            preorden.DrawEllipse(myPreOrden, 130, 310, 30, 30);
            preorden.DrawString("7", Font, Brushes.Black, 137, 320);

            preorden.DrawEllipse(myPreOrden, 165, 310, 30, 30);
            preorden.DrawString("8", Font, Brushes.Black, 172, 320);

            preorden.DrawEllipse(myPreOrden, 200, 310, 30, 30);
            preorden.DrawString("9", Font, Brushes.Black, 207, 320);

            preorden.DrawEllipse(myPreOrden, 235, 310, 30, 30);
            preorden.DrawString("11", Font, Brushes.Black, 242, 320);

            preorden.DrawEllipse(myPreOrden, 270, 310, 30, 30);
            preorden.DrawString("12", Font, Brushes.Black, 277, 320);

            preorden.DrawEllipse(myPreOrden, 305, 310, 30, 30);
            preorden.DrawString("18", Font, Brushes.Black, 312, 320);

            preorden.DrawEllipse(myPreOrden, 340, 310, 30, 30);
            preorden.DrawString("21", Font, Brushes.Black, 347, 320);

            preorden.DrawEllipse(myPreOrden, 375, 310, 30, 30);
            preorden.DrawString("23", Font, Brushes.Black, 382, 320);

            preorden.DrawEllipse(myPreOrden, 410, 310, 30, 30);
            preorden.DrawString("24", Font, Brushes.Black, 417, 320);

            preorden.DrawEllipse(myPreOrden, 445, 310, 30, 30);
            preorden.DrawString("25", Font, Brushes.Black, 452, 320);

            preorden.DrawEllipse(myPreOrden, 480, 310, 30, 30);
            preorden.DrawString("29", Font, Brushes.Black, 487, 320);

            preorden.DrawEllipse(myPreOrden, 515, 310, 30, 30);
            preorden.DrawString("31", Font, Brushes.Black, 522, 320);
        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics preorden;
            preorden = CreateGraphics();
            preorden.DrawString("PostOrden = ", Font, Brushes.Black, 30, 360);

            Pen myPreOrden = new Pen(Color.Cyan, 3);
            preorden.DrawEllipse(myPreOrden, 95, 350, 30, 30);
            preorden.DrawString("2", Font, Brushes.Black, 102, 360);

            preorden.DrawEllipse(myPreOrden, 130, 350, 30, 30);
            preorden.DrawString("8", Font, Brushes.Black, 137, 360);

            preorden.DrawEllipse(myPreOrden, 165, 350, 30, 30);
            preorden.DrawString("7", Font, Brushes.Black, 172, 360);

            preorden.DrawEllipse(myPreOrden, 200, 350, 30, 30);
            preorden.DrawString("11", Font, Brushes.Black, 207, 360);

            preorden.DrawEllipse(myPreOrden, 235, 350, 30, 30);
            preorden.DrawString("12", Font, Brushes.Black, 242, 360);

            preorden.DrawEllipse(myPreOrden, 270, 350, 30, 30);
            preorden.DrawString("9", Font, Brushes.Black, 277, 360);

            preorden.DrawEllipse(myPreOrden, 305, 350, 30, 30);
            preorden.DrawString("21", Font, Brushes.Black, 312, 360);

            preorden.DrawEllipse(myPreOrden, 340, 350, 30, 30);
            preorden.DrawString("24", Font, Brushes.Black, 347, 360);

            preorden.DrawEllipse(myPreOrden, 375, 350, 30, 30);
            preorden.DrawString("23", Font, Brushes.Black, 382, 360);

            preorden.DrawEllipse(myPreOrden, 410, 350, 30, 30);
            preorden.DrawString("31", Font, Brushes.Black, 417, 360);

            preorden.DrawEllipse(myPreOrden, 445, 350, 30, 30);
            preorden.DrawString("29", Font, Brushes.Black, 452, 360);

            preorden.DrawEllipse(myPreOrden, 480, 350, 30, 30);
            preorden.DrawString("25", Font, Brushes.Black, 487, 360);

            preorden.DrawEllipse(myPreOrden, 515, 350, 30, 30);
            preorden.DrawString("18", Font, Brushes.Black, 522, 360);
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo al menu de Escenarios."); // muestra un mensaje
            Escenarios escenarios = new Escenarios();
            escenarios.Show();
            this.Hide();
        }
    }
}
