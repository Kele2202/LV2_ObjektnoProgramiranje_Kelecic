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
    class Kruznica: GrafObj, IDisposable
    {
        public Point currpoint;

        public Kruznica(Color penColor, Point startPoint, Point currPoint):base (startPoint, penColor)
        {
            currpoint = currPoint;
        }

        public override void DrawGrafObj(Graphics objekt)
        {
            objekt.DrawEllipse(new Pen(pencolor, 1), startpoint.X, startpoint.Y, (currpoint.X + currpoint.Y / 2), (currpoint.X + currpoint.Y / 2));
        }

        void IDisposable.Dispose() { }
    }
}
