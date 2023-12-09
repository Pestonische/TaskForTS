using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskForTS.Model
{
    /*Класс круг*/
    public class Circle : Shape
    {
        // Название фигуры
        public override string Name { get; } = "Круг";
        // Диаметр круга
        private int _firstAxis;
        public int FirstAxis { get => _firstAxis; set => _firstAxis = value; }

        // Метод отрисовки фигуры
        public override void DrawShape(Graphics graphics)
        {
            using (Pen pen = new Pen(PenColor, PenWidth))
                graphics.DrawEllipse(pen, new Rectangle(X, Y, FirstAxis, FirstAxis));
        }
    }
}
