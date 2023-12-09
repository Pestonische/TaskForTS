using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskForTS.Model
{
    /*Класс треугольник*/
    public class Triangle : Shape
    {
        // Название фигуры
        public override string Name { get; } = "Треугольник";
        // Высота треугольника
        private int _height;        
        public int Height { get => _height; set => _height = value; }
        // Длина основания
        private int _base;
        public int Base { get => _base; set => _base = value; }

        // Метод отрисовки фигуры
        public override void DrawShape(Graphics graphics)
        {
            using (Pen pen = new Pen(PenColor, PenWidth))
                graphics.DrawPolygon(pen, new Point[] {new Point(X + Base / 2, Y), new Point(X, Y + Height), new Point(X + Base, Y + Height) });
        }
    }
}
