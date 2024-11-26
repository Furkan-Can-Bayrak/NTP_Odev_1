using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //hareket fonksiyonunu yazdık arabayı hareket ettirir
        void moveline(int speed)
        {
            if (p1.Top >= 460)
            {
                p1.Top = -100;
            }
            else {
                p1.Top += speed;
            }

            if (p2.Top >= 460)
            {
                p2.Top = -100;
            }
            else
            {
                p2.Top += speed;
            }

            if (p3.Top >= 460)
            {
                p3.Top = -100;
            }
            else
            {
                p3.Top += speed;
            }

            if (p4.Top >= 460)
            {
                p4.Top = -100;
            }
            else
            {
                p4.Top += speed;
            }

            
        }
        Random r = new Random();
        int x, y;
        //Araba tekrar spawnlanırken x koordinatı rastgele olsun diye random sınıfı

            //Diğer arabaların hareke fonksiyonunu ayrı yazdık
        void otherCar(int speed) {
            if (car2.Top >= 500) {
                x = r.Next(0,200);
                car2.Location = new Point(x,0);
            }
            else
            {
                car2.Top += speed;
            }

            if (car3.Top >= 500)
            {
                x = r.Next(0, 200);
                car3.Location = new Point(x, 0);
            }
            else
            {
                car3.Top += speed;
            }
        }

        //hep bu fonksiyon çalışır. Oyunu yöneten fonksiyon diyebiliriz
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(5);
            otherCar(3);
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        //Main arabamızı sağa sola hareket ettiririz
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left) {
                car1.Left -= 8;
            }
            if (e.KeyCode == Keys.Right)
            {
                car1.Left += 8;
            }
        }
    }
}
