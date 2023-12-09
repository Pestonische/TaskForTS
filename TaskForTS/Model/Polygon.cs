using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForTS.Model
{
    /*Класс многоугольник*/
    public class Polygon : Shape
    {
        // Название фигуры
        public override string Name { get; } = "Многоугольник";
        // Точки фигуры
        private List<Point> _points;        
        public List<Point> Points { get => _points; set => _points = value; }

        // Метод отрисовки фигуры
        public override void DrawShape(Graphics graphics)
        {
            using (Pen pen = new Pen(PenColor, PenWidth))
                graphics.DrawPolygon(pen, Points.ToArray());
        }
    }
}
