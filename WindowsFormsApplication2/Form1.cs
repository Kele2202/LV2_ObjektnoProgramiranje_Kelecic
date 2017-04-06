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
        Graphics graphicHelper;
        Point startPoint, currPoint;
        List<Point> poligonPTS = new List<Point>();
        Boolean bMouseDown = false, poliflag;
        Color penColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
            graphicHelper = panel1.CreateGraphics();
        }
        private void rbPoligon_CheckedChanged(object sender, EventArgs e)
        {
            poliflag = false;
            poligonPTS.Clear();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        { 
            bMouseDown = false;

            if (rbPoligon.Checked)
            {
                using (Poligon remPen = new Poligon(this.BackColor, startPoint, poligonPTS))
                {
                    remPen.DrawGrafObj(graphicHelper);
                }
                poligonPTS.Add(e.Location);
                using (Poligon penDraw = new Poligon(penColor, startPoint, poligonPTS))
                {
                    penDraw.DrawGrafObj(graphicHelper);
                }

            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                if (rbLinija.Checked)
                {
                    using (Linija remPen = new Linija(this.BackColor, startPoint, currPoint))
                    {
                        remPen.DrawGrafObj(graphicHelper);
                    }
                    currPoint = e.Location;

                    using (Linija penDraw = new Linija(penColor, startPoint, currPoint))
                    {
                        penDraw.DrawGrafObj(graphicHelper);
                    }
                }

                if(rbKruznica.Checked)
                {
                    using (Kruznica remPen = new Kruznica(this.BackColor, startPoint, currPoint))
                    {
                        remPen.DrawGrafObj(graphicHelper);
                    }
                    currPoint = e.Location;
                    using (Kruznica penDraw = new Kruznica(penColor, startPoint, currPoint))
                    {
                        penDraw.DrawGrafObj(graphicHelper);
                    }
                }

                if (rbElipsa.Checked)
                {
                    using (Elipsa remPen = new Elipsa(this.BackColor, startPoint, currPoint))
                    {
                        remPen.DrawGrafObj(graphicHelper);
                    }
                    currPoint = e.Location;
                    using (Elipsa penDraw = new Elipsa(penColor, startPoint, currPoint))
                    {
                        penDraw.DrawGrafObj(graphicHelper);
                    }
                }

                if (rbPravokutnik.Checked)
                {
                    using (Kvadrat remPen = new Kvadrat(this.BackColor, startPoint, currPoint))
                    {
                        remPen.DrawGrafObj(graphicHelper);
                    }
                    currPoint = e.Location;
                    using (Kvadrat penDraw = new Kvadrat(penColor, startPoint, currPoint))
                    {
                        penDraw.DrawGrafObj(graphicHelper);
                    }
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            bMouseDown = true;
            startPoint = e.Location;
            if (rbPoligon.Checked && poliflag == false)
            {
                poligonPTS.Add(e.Location);
                poligonPTS.Add(e.Location);
                poliflag = true;
            }
        }
        private void rbCrvena_CheckedChanged(object sender, EventArgs e)
        {
            penColor = Color.Red;
        }

        private void rbPlava_CheckedChanged(object sender, EventArgs e)
        {
            penColor = Color.Blue;
        }

        private void rbCrna_CheckedChanged(object sender, EventArgs e)
        {
            penColor = Color.Black;
        }
    }
}
