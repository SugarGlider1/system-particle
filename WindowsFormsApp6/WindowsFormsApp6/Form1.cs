using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {      
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        ColorPoint rPoint; // Красненькая тчк
        ColorPoint yPoint; // Желтенькая тчк
        ColorPoint gPoint; // Зелененькая тчк
        ColorPoint mPoint; // Маджента тчк
        CounterPoint CounterPoint; // точка счетчик

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            emitter = new TopEmitter
            {
                Width = picDisplay.Width,
                GravitationY = 0.25f
            };

            rPoint = new ColorPoint
            {
                X = picDisplay.Width / 2 - 256, // X тчк
                Y = picDisplay.Height / 2 - 32, // Y тчк
                Radius = 100, // R тчк
                pColor = Color.Red // Окрашивающий цвет тчк (также - цвет границ тчк)
            };
            
            yPoint = new ColorPoint
            {
                X = picDisplay.Width / 2 - 128,
                Y = picDisplay.Height / 2 - 16,
                Radius = 100,
                pColor = Color.Yellow
            };
            
            CounterPoint = new CounterPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
                Radius = 100,
                pColor = Color.Blue
            };
            
            gPoint = new ColorPoint
            {
                X = picDisplay.Width / 2 + 128,
                Y = picDisplay.Height / 2 - 16,
                Radius = 100,
                pColor = Color.Green
            };
            
            mPoint = new ColorPoint
            {
                X = picDisplay.Width / 2 + 256,
                Y = picDisplay.Height / 2 - 32,
                Radius = 100,
                pColor = Color.Magenta
            };

            // привязываем поля к эмиттеру
            emitter.impactPoints.Add(rPoint);
            emitter.impactPoints.Add(yPoint);
            emitter.impactPoints.Add(gPoint);
            emitter.impactPoints.Add(mPoint);
            emitter.impactPoints.Add(CounterPoint);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // тут теперь обновляем эмиттер

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
            }

            picDisplay.Invalidate();
        }
        
        private void rPointScroller_Scroll(object sender, EventArgs e) //изменение радиуса красной тчк
        {
            rPoint.Radius = rPointScroller.Value;
        }
        private void trackBar1_Scroll(object sender, EventArgs e) //изменение положение красной тчк по Х
        {
            rPoint.X = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e) //изменение положения красной тчк по Y
        {
            rPoint.Y = 400 - trackBar2.Value;
        }

        private void rColorChangeBtn_Click(object sender, EventArgs e)//кнопка для изменение цвета красной тчк
        {
            colorDialog.Color = rPoint.pColor;
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            rPoint.pColor = colorDialog.Color;
        }

        private void yPointScroller_Scroll(object sender, EventArgs e)//изменение радиуса желтой тчк
        {
            yPoint.Radius = yPointScroller.Value;
        }
        private void trackBar3_Scroll(object sender, EventArgs e)//изменение положения желтой тчк по X
        {
            yPoint.X = trackBar3.Value;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)//измение положения желтой тчк по Y
        {
            yPoint.Y = 400 - trackBar4.Value;
        }

        private void yColorChangeBtn_Click(object sender, EventArgs e)//кнопка изменения цвета желтой тчк
        {
            colorDialog.Color = yPoint.pColor;
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            yPoint.pColor = colorDialog.Color;
        }

        private void gPointScroller_Scroll(object sender, EventArgs e)// измененние радиуса зеленой тчк
        {
            gPoint.Radius = gPointScroller.Value;
        }
        private void trackBar5_Scroll(object sender, EventArgs e)// изменение положения зеленной тчк по X
        {
            gPoint.X = trackBar5.Value;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)// изменение положения зеленной тчк по Y
        {
            gPoint.Y = 400 - trackBar6.Value;
        }

        private void gColorChangeBtn_Click(object sender, EventArgs e)// кнопка изменения цвета зеленной тчк
        {
            colorDialog.Color = gPoint.pColor;
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            gPoint.pColor = colorDialog.Color;
        }

        private void mPointScroller_Scroll(object sender, EventArgs e)// изменение радиуса маджентовой тчк
        {
            mPoint.Radius = mPointScroller.Value;
        }

        private void trackBar7_Scroll(object sender, EventArgs e)// изменение положения маджентовой тчк по X
        {
            mPoint.X = trackBar7.Value;
        }

        private void trackBar8_Scroll(object sender, EventArgs e)// изменение положения маджентовой тчк по Y
        {
            mPoint.Y = 400 - trackBar8.Value;
        }

        private void mColorChangeBtn_Click(object sender, EventArgs e)// кнопка изменения цвета маджентовой тчк
        {
            colorDialog.Color = mPoint.pColor;
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            mPoint.pColor = colorDialog.Color;
        }
        
        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            CounterPoint = new CounterPoint
            {
                X = e.X,
                Y = e.Y,
                Radius = 100,
                pColor = Color.Blue
            };

            emitter.impactPoints.Add(CounterPoint);
        }
        
        private void Generation_rate_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = Generation_rate.Value;
        }
    }
}
