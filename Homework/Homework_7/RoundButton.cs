//Кнопка с округлыми краями

using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Homework_7
{
    public class RoundButton : Button
    {
        /// <summary>
        /// Метоз изменения формы
        /// </summary>
        /// <param name="Rectangl">Прямоугольник</param>
        /// <param name="radius">Радиус</param>
        /// <returns></returns>
        GraphicsPath GetRoundPath(RectangleF Rectangl, int radius)
        {
            float myRadius = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rectangl.X, Rectangl.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rectangl.X + myRadius, Rectangl.Y, Rectangl.Width - myRadius, Rectangl.Y);
            GraphPath.AddArc(Rectangl.X + Rectangl.Width - radius, Rectangl.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rectangl.Width, Rectangl.Y + myRadius, Rectangl.Width, Rectangl.Height - myRadius);
            GraphPath.AddArc(Rectangl.X + Rectangl.Width - radius,
                                Rectangl.Y + Rectangl.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rectangl.Width - myRadius, Rectangl.Height, Rectangl.X + myRadius, Rectangl.Height);
            GraphPath.AddArc(Rectangl.X, Rectangl.Y + Rectangl.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rectangl.X, Rectangl.Height - myRadius, Rectangl.X, Rectangl.Y + myRadius);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rectangl = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rectangl, 50);

            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.Black, 1.75f))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }
}
