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
    class Linija : GrafObj, IDisposable
    {
        public Point currpoint;
        public Linija (Color penColor, Point startPoint, Point currPoint ) : base (startPoint, penColor)
        {
            currpoint = currPoint;
        }

        public override void DrawGrafObj (Graphics objekt)
        {
            objekt.DrawLine(new Pen(pencolor, 1), startpoint, currpoint);
        }

        void IDisposable.Dispose() { }
    }
}
