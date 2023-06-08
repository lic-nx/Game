using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private Point pos; // то где впервый раз нажали мышкой
        private bool dragging; // передвигаем окно или нет
        public Form1()
        {
            InitializeComponent();
            // Методы нужны для перемещения окна 
            Road_img2.MouseDown += MouseClickDown;
            Road_img2.MouseDown += MouseClickUp;
            Road_img2.MouseDown += MouseClickMove;
            Road_img.MouseDown += MouseClickDown;
            Road_img.MouseUp += MouseClickUp;
            Road_img.MouseMove += MouseClickMove;

        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            // смотрим, если нажали на мышку, то запоминаем коорд. Того где нажали
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            // проверяем что отпустили и больше не надо следить за мышкой
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + Road_img.Top);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // просто для выхода из игры
            if (e.KeyChar == (char)Keys.Escape) { 
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // каждые 20 млсек. двигаем изображение дороги чтоб казалось что идет анимация
            int speed = 10;
            int carSpeed = 7;
            Road_img2.Top += speed;
            Road_img.Top += speed;

            redCar1.Top += carSpeed;
            redCar.Top += carSpeed;

            if (Road_img.Top >= 650) {
                Road_img2.Top = -640;
                Road_img.Top = 0;
            }
            if (redCar.Top >= 650) redCar.Top = -130;
            if (redCar1.Top >= 650) redCar1.Top = -400;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // управление машинкой
            int speedCar = 10;
            if((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Car_img.Left >= 150 ) {
                Car_img.Left -= speedCar;
            }
            else if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && Car_img.Right <= 700)
            {
                Car_img.Left += speedCar;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
