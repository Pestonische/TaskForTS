using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskForTS.Model
{
    /*Класс квадрат*/
    public class Square : Shape
    {
        // Название фигуры
        public override string Name { get; } = "Квадрат";
        // Длина стороны
        private int _firstSide;
        public int FirstSide { get => _firstSide; set => _firstSide = value; }

        // Метод отрисовки фигуры
        public override void DrawShape(Graphics graphics)
        {
            using (Pen pen = new Pen(PenColor, PenWidth))
                graphics.DrawRectangle(pen, new Rectangle(X, Y, FirstSide, FirstSide));
        }
    }
}
