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
    class GrafObj

    {
        public Point startpoint;
        public Color pencolor;

        public GrafObj() { }

        public GrafObj(Point startPoint, Color penColor)
        {
            startpoint = startPoint;
            pencolor = penColor;
        }

        virtual public void DrawGrafObj (Graphics objekt)
        {

        }

    }
}
