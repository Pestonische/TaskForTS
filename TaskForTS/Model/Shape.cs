using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForTS.Model
{
    /*Абстрактный класс фигура*/
    public abstract class Shape
    {
        // Толщина пера
        protected int PenWidth { get; } = 1; 
        // Цвет пера
        protected Color PenColor { get; } = Color.Black;
        // Координаты фигуры
        public int  X { get; set; }
        public int Y { get; set; }
        // Название фигуры
        public virtual string Name { get; }
        // Метод отрисовки фигуры
        public abstract void DrawShape(Graphics graphics);
    }
}
