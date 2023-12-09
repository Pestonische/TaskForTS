using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskForTS.Model
{
    /*Класс прямоугольник*/
    public class Rect : Square
    {
        // Название фигуры
        public override string Name { get; } = "Прямоугольник";
        // Длина второй стороны
        private int _secondSide;
        public int SecondSide { get => _secondSide; set => _secondSide = value; }

        // Метод отрисовки фигуры
        public override void DrawShape(Graphics graphics)
        {
            using (Pen pen = new Pen(PenColor, PenWidth))
                graphics.DrawRectangle(pen, new Rectangle(X, Y, FirstSide, SecondSide));
        }
    }
}

