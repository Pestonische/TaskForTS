namespace TaskForTS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CBWhatDrawing = new System.Windows.Forms.ComboBox();
            this.TBFirstParameter = new System.Windows.Forms.TextBox();
            this.TBSecondParameter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LFirstParameter = new System.Windows.Forms.Label();
            this.LSecondParameter = new System.Windows.Forms.Label();
            this.BSetValue = new System.Windows.Forms.Button();
            this.LY = new System.Windows.Forms.Label();
            this.LX = new System.Windows.Forms.Label();
            this.TBY = new System.Windows.Forms.TextBox();
            this.TBX = new System.Windows.Forms.TextBox();
            this.BCleaning = new System.Windows.Forms.Button();
            this.LPoints = new System.Windows.Forms.Label();
            this.TBPoints = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CBWhatDrawing
            // 
            this.CBWhatDrawing.FormattingEnabled = true;
            this.CBWhatDrawing.Items.AddRange(new object[] {
            "Круг",
            "Эллипс",
            "Квадрат",
            "Прямоугольник",
            "Треугольник",
            "Многоугольник"});
            this.CBWhatDrawing.Location = new System.Drawing.Point(667, 12);
            this.CBWhatDrawing.Name = "CBWhatDrawing";
            this.CBWhatDrawing.Size = new System.Drawing.Size(121, 24);
            this.CBWhatDrawing.TabIndex = 0;
            this.CBWhatDrawing.TextChanged += new System.EventHandler(this.IfChanged);
            // 
            // TBFirstParameter
            // 
            this.TBFirstParameter.Location = new System.Drawing.Point(667, 42);
            this.TBFirstParameter.Name = "TBFirstParameter";
            this.TBFirstParameter.Size = new System.Drawing.Size(121, 22);
            this.TBFirstParameter.TabIndex = 1;
            this.TBFirstParameter.Text = "100";
            // 
            // TBSecondParameter
            // 
            this.TBSecondParameter.Location = new System.Drawing.Point(667, 70);
            this.TBSecondParameter.Name = "TBSecondParameter";
            this.TBSecondParameter.Size = new System.Drawing.Size(121, 22);
            this.TBSecondParameter.TabIndex = 2;
            this.TBSecondParameter.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Что рисуем?";
            // 
            // LFirstParameter
            // 
            this.LFirstParameter.AutoSize = true;
            this.LFirstParameter.Location = new System.Drawing.Point(563, 45);
            this.LFirstParameter.Name = "LFirstParameter";
            this.LFirstParameter.Size = new System.Drawing.Size(41, 16);
            this.LFirstParameter.TabIndex = 4;
            this.LFirstParameter.Text = "Ось 1";
            // 
            // LSecondParameter
            // 
            this.LSecondParameter.AutoSize = true;
            this.LSecondParameter.Location = new System.Drawing.Point(563, 73);
            this.LSecondParameter.Name = "LSecondParameter";
            this.LSecondParameter.Size = new System.Drawing.Size(41, 16);
            this.LSecondParameter.TabIndex = 5;
            this.LSecondParameter.Text = "Ось 2";
            // 
            // BSetValue
            // 
            this.BSetValue.Location = new System.Drawing.Point(685, 207);
            this.BSetValue.Name = "BSetValue";
            this.BSetValue.Size = new System.Drawing.Size(103, 28);
            this.BSetValue.TabIndex = 6;
            this.BSetValue.Text = "Нарисовать";
            this.BSetValue.UseVisualStyleBackColor = true;
            this.BSetValue.Click += new System.EventHandler(this.BSetValue_Click);
            // 
            // LY
            // 
            this.LY.AutoSize = true;
            this.LY.Location = new System.Drawing.Point(563, 182);
            this.LY.Name = "LY";
            this.LY.Size = new System.Drawing.Size(16, 16);
            this.LY.TabIndex = 10;
            this.LY.Text = "Y";
            // 
            // LX
            // 
            this.LX.AutoSize = true;
            this.LX.Location = new System.Drawing.Point(563, 154);
            this.LX.Name = "LX";
            this.LX.Size = new System.Drawing.Size(15, 16);
            this.LX.TabIndex = 9;
            this.LX.Text = "X";
            // 
            // TBY
            // 
            this.TBY.Location = new System.Drawing.Point(667, 179);
            this.TBY.Name = "TBY";
            this.TBY.Size = new System.Drawing.Size(121, 22);
            this.TBY.TabIndex = 8;
            this.TBY.Text = "100";
            // 
            // TBX
            // 
            this.TBX.Location = new System.Drawing.Point(667, 151);
            this.TBX.Name = "TBX";
            this.TBX.Size = new System.Drawing.Size(121, 22);
            this.TBX.TabIndex = 7;
            this.TBX.Text = "100";
            // 
            // BCleaning
            // 
            this.BCleaning.Location = new System.Drawing.Point(566, 207);
            this.BCleaning.Name = "BCleaning";
            this.BCleaning.Size = new System.Drawing.Size(113, 28);
            this.BCleaning.TabIndex = 11;
            this.BCleaning.Text = "Очистить все";
            this.BCleaning.UseVisualStyleBackColor = true;
            this.BCleaning.Click += new System.EventHandler(this.BCleaning_Click);
            // 
            // LPoints
            // 
            this.LPoints.AutoSize = true;
            this.LPoints.Location = new System.Drawing.Point(563, 113);
            this.LPoints.Name = "LPoints";
            this.LPoints.Size = new System.Drawing.Size(47, 16);
            this.LPoints.TabIndex = 13;
            this.LPoints.Text = "Точки";
            // 
            // TBPoints
            // 
            this.TBPoints.Location = new System.Drawing.Point(667, 101);
            this.TBPoints.Multiline = true;
            this.TBPoints.Name = "TBPoints";
            this.TBPoints.Size = new System.Drawing.Size(121, 44);
            this.TBPoints.TabIndex = 14;
            this.TBPoints.Text = "(1, 1) (20, 20)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBPoints);
            this.Controls.Add(this.LPoints);
            this.Controls.Add(this.BCleaning);
            this.Controls.Add(this.LY);
            this.Controls.Add(this.LX);
            this.Controls.Add(this.TBY);
            this.Controls.Add(this.TBX);
            this.Controls.Add(this.BSetValue);
            this.Controls.Add(this.LSecondParameter);
            this.Controls.Add(this.LFirstParameter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBSecondParameter);
            this.Controls.Add(this.TBFirstParameter);
            this.Controls.Add(this.CBWhatDrawing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBWhatDrawing;
        private System.Windows.Forms.TextBox TBFirstParameter;
        private System.Windows.Forms.TextBox TBSecondParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LFirstParameter;
        private System.Windows.Forms.Label LSecondParameter;
        private System.Windows.Forms.Button BSetValue;
        private System.Windows.Forms.Label LY;
        private System.Windows.Forms.Label LX;
        private System.Windows.Forms.TextBox TBY;
        private System.Windows.Forms.TextBox TBX;
        private System.Windows.Forms.Button BCleaning;
        private System.Windows.Forms.Label LPoints;
        private System.Windows.Forms.TextBox TBPoints;
    }
}

