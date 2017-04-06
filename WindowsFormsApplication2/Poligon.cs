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
    class Poligon : GrafObj, IDisposable
    {
        List<Point> poliPts = new List<Point>();
        public Poligon (Color penColor, Point startPoint, List<Point> poligonPTS):base (startPoint, penColor)
        {
            poliPts = poligonPTS;
        }
        public override void DrawGrafObj(Graphics objekt)
        {
            objekt.DrawPolygon(new Pen(pencolor, 1), poliPts.ToArray());
        }

        void IDisposable.Dispose() { }
    }
}
