using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace toolbox__copy
{
    public class gradient_box: Panel
    {
        public Color Gradient_top { get; set; }
        public Color Gradient_bottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush Linear = new LinearGradientBrush(this.ClientRectangle, this.Gradient_top, this.Gradient_bottom, 45f);
            Graphics g = e.Graphics;
            g.FillRectangle(Linear , this.ClientRectangle);
            base.OnPaint(e);

        }
    }
}
