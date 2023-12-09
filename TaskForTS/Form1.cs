using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskForTS.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TaskForTS
{
    public partial class Form1 : Form
    {
        Circle circle = new Circle();
        Ellipse ellipse = new Ellipse();
        Rect rect = new Rect();
        Square square = new Square();
        Triangle triangle = new Triangle();
        Polygon polygon = new Polygon();
        List<Shape> shapes = new List<Shape>();
        int firstParameter = 10;
        int secondParameter = 10;

        public Form1()
        {
            InitializeComponent();
        }
        // Отрисовка фигур
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
           
            foreach(var s in shapes) s.DrawShape(e.Graphics);

            base.OnPaint(e);

        }
        // Обработка данных
        private void BSetValue_Click(object sender, EventArgs e)
        {      
            try 
            {
                if (CBWhatDrawing.Text == circle.Name)
                {
                    circle = new Circle();
                    firstParameter = Int32.Parse(TBFirstParameter.Text);
                    secondParameter = Int32.Parse(TBSecondParameter.Text);
                    circle.FirstAxis = firstParameter;
                    circle.X = Int32.Parse(TBX.Text);
                    circle.Y = Int32.Parse(TBY.Text); 
                    shapes.Add(circle);
                    Invalidate();
                }
                else if (CBWhatDrawing.Text == ellipse.Name)
                {
                    ellipse = new Ellipse();
                    firstParameter = Int32.Parse(TBFirstParameter.Text);
                    secondParameter = Int32.Parse(TBSecondParameter.Text);
                    ellipse.FirstAxis = firstParameter;
                    ellipse.SecondAxis = secondParameter;
                    ellipse.X = Int32.Parse(TBX.Text);
                    ellipse.Y = Int32.Parse(TBY.Text);
                    shapes.Add(ellipse);
                    Invalidate();
                }
                else if(CBWhatDrawing.Text == square.Name)
                {
                    square = new Square();
                    firstParameter = Int32.Parse(TBFirstParameter.Text);
                    secondParameter = Int32.Parse(TBSecondParameter.Text);
                    square.FirstSide = firstParameter;
                    square.X = Int32.Parse(TBX.Text);
                    square.Y = Int32.Parse(TBY.Text);
                    shapes.Add(square);
                    Invalidate();
                }
                else if(CBWhatDrawing.Text == rect.Name)
                {
                    rect = new Rect();
                    firstParameter = Int32.Parse(TBFirstParameter.Text);
                    secondParameter = Int32.Parse(TBSecondParameter.Text);
                    rect.FirstSide = firstParameter;
                    rect.SecondSide = secondParameter;
                    rect.X = Int32.Parse(TBX.Text);
                    rect.Y = Int32.Parse(TBY.Text);
                    shapes.Add(rect);
                    Invalidate();
                }
                else if(CBWhatDrawing.Text == triangle.Name)
                {
                    triangle = new Triangle();
                    firstParameter = Int32.Parse(TBFirstParameter.Text);
                    secondParameter = Int32.Parse(TBSecondParameter.Text);
                    triangle.Height = firstParameter;
                    triangle.Base = secondParameter;
                    triangle.X = Int32.Parse(TBX.Text);
                    triangle.Y = Int32.Parse(TBY.Text);
                    shapes.Add(triangle);
                    Invalidate();
                }
                else if (CBWhatDrawing.Text == polygon.Name)
                {
                    polygon = new Polygon();
                    polygon.Points = new List<Point>();
                    firstParameter = Int32.Parse(TBFirstParameter.Text);
                    secondParameter = Int32.Parse(TBSecondParameter.Text);

                    int checkInt;
                    List<string> pointsData = TBPoints.Text.Split('(',',',' ', ')').Where(x => int.TryParse(x, out checkInt)).ToList();

                    if (pointsData.Count % 2 != 0) throw new ArgumentException("Невнрные данные");

                    if (pointsData.Count < 4) throw new ArgumentException("Нужно больше точек");

                    
                    for (int i = 0; i <= pointsData.Count - 2; )
                    {
                        polygon.Points.Add(new Point(Int32.Parse(pointsData[i]), Int32.Parse(pointsData[i + 1])));
                        i += 2;
                    }

                    shapes.Add(polygon);
                    Invalidate();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }            
        }
        // Изменение функционала
        private void IfChanged(object sender, EventArgs e)
        {
            if (CBWhatDrawing.Text == ellipse.Name)
            {
                LFirstParameter.Text = "Ось 1";
                LSecondParameter.Text = "Ось 2";
                LX.Text = "X";
                LY.Text = "Y";
                LPoints.Text = "-";
                TBFirstParameter.Enabled = true;
                TBSecondParameter.Enabled = true;
                TBX.Enabled = true;
                TBY.Enabled = true;
                TBPoints.Enabled = false;
            }
            else if (CBWhatDrawing.Text == circle.Name)
            {
                LFirstParameter.Text = "Радиус";
                LSecondParameter.Text = "-";
                LX.Text = "X";
                LY.Text = "Y";
                LPoints.Text = "-";
                TBFirstParameter.Enabled = true;
                TBSecondParameter.Enabled = false;
                TBX.Enabled = true;
                TBY.Enabled = true;
                TBPoints.Enabled = false;

                TBSecondParameter.Enabled = false;
            }
            else if (CBWhatDrawing.Text == rect.Name)
            {
                LFirstParameter.Text = "Сторана 1";
                LSecondParameter.Text = "Сторана 2";
                LX.Text = "X";
                LY.Text = "Y";
                LPoints.Text = "-";
                TBFirstParameter.Enabled = true;
                TBSecondParameter.Enabled = true;
                TBX.Enabled = true;
                TBY.Enabled = true;
                TBPoints.Enabled = false;
            }
            else if (CBWhatDrawing.Text == square.Name)
            {
                LFirstParameter.Text = "Сторана 1";
                LSecondParameter.Text = "-"; LX.Text = "X";
                LY.Text = "Y";
                LPoints.Text = "-";
                TBFirstParameter.Enabled = true;
                TBSecondParameter.Enabled = false;
                TBX.Enabled = true;
                TBY.Enabled = true;
                TBPoints.Enabled = false;
            }
            else if (CBWhatDrawing.Text == triangle.Name)
            {
                LFirstParameter.Text = "Высота";
                LSecondParameter.Text = "Основание";
                LX.Text = "X";
                LY.Text = "Y";
                LPoints.Text = "-";
                TBFirstParameter.Enabled = true;
                TBSecondParameter.Enabled = true;
                TBX.Enabled = true;
                TBY.Enabled = true;
                TBPoints.Enabled = false;
            }
            else if (CBWhatDrawing.Text == polygon.Name)
            {
                LFirstParameter.Text = "-";
                LSecondParameter.Text = "-";
                LX.Text = "-";
                LY.Text = "-";
                LPoints.Text = "Точки";
                TBFirstParameter.Enabled = false;
                TBSecondParameter.Enabled = false;
                TBX.Enabled = false;
                TBY.Enabled = false;
                TBPoints.Enabled = true;

            }
        }
        // Очистка полотна
        private void BCleaning_Click(object sender, EventArgs e)
        {
            shapes = new List<Shape>();
            Invalidate();
        }

    }
}
