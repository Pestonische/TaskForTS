using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskForTS.Model
{
    /*Класс эллипс*/
    public class Ellipse : Circle 
    {
        // Название фигуры
        public override string Name { get; } = "Эллипс";
        // Второй диаметр эллипса
        private int _secondAxis;
        public int SecondAxis { get => _secondAxis; set => _secondAxis = value; }

        // Метод отрисовки фигуры
        public override void DrawShape(Graphics graphics)
        {
            using (Pen pen = new Pen(PenColor, PenWidth))
                    graphics.DrawEllipse(pen, new Rectangle(X, Y, FirstAxis, SecondAxis));
        }
    }
}
