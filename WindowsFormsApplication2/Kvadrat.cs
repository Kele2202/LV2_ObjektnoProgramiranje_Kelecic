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
    class Kvadrat : Linija, IDisposable
    {
        public Kvadrat (Color penColor, Point startPoint, Point currPoint): base(penColor, startPoint, currPoint)
        {

        }
        public override void DrawGrafObj(Graphics objekt)
        {
            objekt.DrawRectangle(new Pen(pencolor, 1), startpoint.X, startpoint.Y, currpoint.X, currpoint.Y);
        }
    }
}
