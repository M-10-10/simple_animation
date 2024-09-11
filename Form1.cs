using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private readonly Image mill;
        private readonly Image house;
        private PictureBox picture;
        private readonly Image[] smoke = new Image[2];
        private readonly Image[] blades = new Image[2];
        
        private Timer timer;
        private Timer timer1;
        private int animation;
        private int animation1;
        SolidBrush solidBrush = new SolidBrush(
   Color.MistyRose);
        SolidBrush solidBrush1 = new SolidBrush(
   Color.LemonChiffon);
       
       


        public Button but = new Button();
        public Form1()
        {
            InitializeComponent();








            house = new Bitmap(1000, 1000);
            var graphics = Graphics.FromImage(house);

            // Крыша

            Point f1 = new Point(50, 250);
            Point f2 = new Point(175, 125);
            Point f3 = new Point(300, 250);
            Point[] f = { f1, f2, f3 };
            graphics.FillPolygon(solidBrush, f);
            graphics.DrawLine(Pens.Black, 50, 250, 175, 125);
            graphics.DrawLine(Pens.Black, 175, 125, 300, 250);


            // Дом
            graphics.FillRectangle(solidBrush, 50, 250, 250, 200);
            graphics.DrawRectangle(Pens.Black, 50, 250, 250, 200);

            Label lbl = new Label();
            FontFamily ff = new FontFamily("Arial");
            lbl.Font = new Font(ff, 11, FontStyle.Italic);
            lbl.Text = "29";
            lbl.Size = new Size(40, 40);
            lbl.Location = new Point(260, 300);
            lbl.Parent = picture;
            this.Controls.Add(lbl);

            // Окно
            graphics.FillRectangle(solidBrush1, 100, 300, 150, 100);
            graphics.DrawRectangle(Pens.Black, 100, 300, 150, 100);

            // Рама
            graphics.DrawLine(Pens.Black, 175, 300, 175, 400);
            graphics.DrawLine(Pens.Black, 100, 350, 250, 350);
            // Труба
            Point k1 = new Point(225, 175);
            Point k2 = new Point(225, 100);
            Point k3 = new Point(250, 100);
            Point k4 = new Point(250, 200);
            Point[] k = { k1, k2, k3, k4 };
            graphics.FillPolygon(solidBrush, k);
            graphics.DrawLine(Pens.Black, 225, 175, 225, 100);
            graphics.DrawLine(Pens.Black, 225, 100, 250, 100);
            graphics.DrawLine(Pens.Black, 250, 100, 250, 200);


            // Дым1
            smoke[0] = new Bitmap(1000, 1000);
            graphics = Graphics.FromImage(smoke[0]);
            graphics.DrawBezier(Pens.Black, new Point(235, 85), new Point(300, 40), new Point(400, 80), new Point(450, 60));
            graphics.DrawBezier(Pens.Black, new Point(250, 85), new Point(350, 40), new Point(375, 100), new Point(450, 40));
            graphics.DrawBezier(Pens.Black, new Point(240, 85), new Point(375, 30), new Point(400, 80), new Point(450, 30));
            // Дым2
            smoke[1] = new Bitmap(1000, 1000);
            graphics = Graphics.FromImage(smoke[1]);
            graphics.DrawBezier(Pens.Black, new Point(230, 85), new Point(300, 45), new Point(400, 75), new Point(450, 50));
            graphics.DrawBezier(Pens.Black, new Point(255, 85), new Point(350, 45), new Point(375, 105), new Point(450, 45));
            graphics.DrawBezier(Pens.Black, new Point(245, 85), new Point(375, 25), new Point(400, 75), new Point(450, 35));

            //mill
            mill = new Bitmap(1000, 1000);
            SolidBrush br1 = new SolidBrush(Color.BlanchedAlmond);
            SolidBrush br2 = new SolidBrush(Color.SaddleBrown);
            SolidBrush br3 = new SolidBrush(Color.DarkCyan);
            SolidBrush br = new SolidBrush(Color.Tan);
            Point po1 = new Point(600, 240);
            Point po2 = new Point(700, 240);
            Point po3 = new Point(680, 100);
            Point po4 = new Point(620, 100);
            Point[] m1 = { po1, po2, po3, po4 };
            Point po5 = new Point(650, 70);
            Point[] m2 = { po5, po3, po4 };

            graphics = Graphics.FromImage(mill);
            graphics.FillPolygon(br1, m1);
            graphics.FillPolygon(br2, m2);
            graphics.FillRectangle(br3, 620, 180, 40, 60);
            graphics.FillEllipse(br2, 645, 110, 10, 10);
            graphics.DrawLine(Pens.Black, 600, 240, 700, 240);
            graphics.DrawLine(Pens.Black, 600, 240, 620, 100);
            graphics.DrawLine(Pens.Black, 700, 240, 680, 100);
            graphics.DrawLine(Pens.Black, 620, 100, 680, 100);
            graphics.DrawLine(Pens.Black, 620, 100, 650, 70);
            graphics.DrawLine(Pens.Black, 680, 100, 650, 70);
            graphics.DrawEllipse(Pens.Black, 645, 110, 10, 10);
            graphics.DrawRectangle(Pens.Black, 620, 180, 40, 60);


            //landscape
            SolidBrush br5 = new SolidBrush(Color.DarkGreen);
            Point q1 = new Point(1000, 240);
            Point q2 = new Point(1000, 150);
            Point q3 = new Point(690, 166);
            Point q4 = new Point(700, 240);
            Point[] q = { q1, q2, q3, q4 };
            graphics.FillPolygon(br5, q);
            graphics.DrawLine(Pens.Black, 1000, 180, 690, 180);
            graphics.DrawLine(Pens.Black, 1000, 240, 700, 240);


            Point q5 = new Point(600, 240);
            Point q6 = new Point(600, 500);
            Point q7 = new Point(1000, 500);
            Point[] qq = { q1, q5, q6, q7 };
            graphics.FillPolygon(br5, qq);

            Point q8 = new Point(300, 250);
            Point q9 = new Point(300, 500);
            Point q10 = new Point(600, 500);
            Point[] qqq = { q10, q5, q8, q9 };
            graphics.FillPolygon(br5, qqq);
            Point q11 = new Point(250, 200);
            Point q12 = new Point(610, 170);

            Point[] qqqq = { q5, q8, q11, q12 };
            graphics.FillPolygon(br5, qqqq);

            Point q13 = new Point(0, 500);
            Point q14 = new Point(0, 450);
            Point q15 = new Point(50, 450);
            Point q16 = new Point(50, 500);
            Point[] qqqqq = { q13, q14, q15, q16 };
            graphics.FillPolygon(br5, qqqqq);


            Point q17 = new Point(300, 450);
            Point q22 = new Point(50, 450);
            Point[] l = { q16, q15, q17, q9 };
            graphics.FillPolygon(br5, l);

            Point q18 = new Point(0, 250);
            Point q19 = new Point(50, 250);
            Point q20 = new Point(145, 160);
            Point q21 = new Point(0, 140);
            Point[] l1 = { q22, q14, q18, q19 };
            Point[] l2 = { q18, q19, q20, q21 };
            graphics.FillPolygon(br5, l1);
            graphics.FillPolygon(br5, l2);
            SolidBrush solidBrush2 = new SolidBrush(
  Color.Cornsilk);

            GraphicsPath t1 = new GraphicsPath();
            GraphicsPath t2 = new GraphicsPath();
            GraphicsPath t3 = new GraphicsPath();
            t1.AddBezier(145, 160, 40, 90, 20, 100, 0, 140);
            t2.AddBezier(610, 170, 500, 100, 400, 175, 250, 205);
            t3.AddBezier(690, 166, 750, 145, 900, 75, 1000, 150);
            graphics.FillPath(br5, t1);
            graphics.FillPath(br5, t2);
            graphics.FillPath(br5, t3);


            graphics.DrawBezier(Pens.Black, new Point(145, 160), new Point(40, 90), new Point(20, 100), new Point(0, 140));
            graphics.DrawBezier(Pens.Black, new Point(610, 170), new Point(500, 100), new Point(400, 175), new Point(250, 205));
            graphics.DrawBezier(Pens.Black, new Point(690, 166), new Point(750, 145), new Point(900, 75), new Point(1000, 150));
            graphics.DrawBezier(Pens.Black, new Point(690, 200), new Point(750, 170), new Point(900, 220), new Point(1000, 180));
            graphics.DrawBezier(Pens.Black, new Point(710, 300), new Point(550, 250), new Point(500, 265), new Point(450, 300));
            graphics.DrawBezier(Pens.Black, new Point(450, 300), new Point(420, 310), new Point(410, 280), new Point(450, 310));
            graphics.DrawBezier(Pens.Black, new Point(300, 380), new Point(750, 300), new Point(900, 250), new Point(1000, 450));
            graphics.DrawBezier(Pens.Black, new Point(0, 450), new Point(150, 500), new Point(155, 450), new Point(300, 500));

            graphics.DrawBezier(Pens.Black, new Point(0, 330), new Point(10, 310), new Point(40, 340), new Point(50, 360));
            graphics.DrawEllipse(Pens.Black, 450, 80, 40, 40);
            graphics.FillEllipse(solidBrush2, 450, 80, 40, 40);








            //blades
            blades[0] = new Bitmap(1000, 1000);
            graphics = Graphics.FromImage(blades[0]);
            //1
            Point p11 = new Point(647, 110);
            Point p12 = new Point(675, 40);
            Point p13 = new Point(620, 40);
            Point[] b11 = { p11, p12, p13 };
            graphics.FillPolygon(br, b11);

            graphics.DrawLine(Pens.Black, 647, 110, 620, 40);
            graphics.DrawLine(Pens.Black, 647, 110, 675, 40);
            graphics.DrawLine(Pens.Black, 620, 40, 675, 40);

            //2
            Point p21 = new Point(647, 120);
            Point p22 = new Point(675, 190);
            Point p23 = new Point(620, 190);
            Point[] b21 = { p21, p22, p23 };
            graphics.FillPolygon(br, b21);
            graphics.DrawLine(Pens.Black, 647, 120, 620, 190);
            graphics.DrawLine(Pens.Black, 647, 120, 675, 190);
            graphics.DrawLine(Pens.Black, 620, 190, 675, 190);

            //3
            Point p31 = new Point(645, 115);
            Point p32 = new Point(560, 90);
            Point p33 = new Point(560, 140);
            Point[] b31 = { p31, p32, p33 };
            graphics.FillPolygon(br, b31);
            graphics.DrawLine(Pens.Black, 645, 115, 560, 90);
            graphics.DrawLine(Pens.Black, 645, 115, 560, 140);
            graphics.DrawLine(Pens.Black, 560, 90, 560, 140);

            //4
            Point p41 = new Point(651, 115);
            Point p42 = new Point(720, 90);
            Point p43 = new Point(720, 140);
            Point[] b41 = { p41, p42, p43 };
            graphics.FillPolygon(br, b41);
            graphics.DrawLine(Pens.Black, 651, 115, 720, 90);
            graphics.DrawLine(Pens.Black, 651, 115, 720, 140);
            graphics.DrawLine(Pens.Black, 720, 90, 720, 140);


            blades[1] = new Bitmap(1000, 1000);
            graphics = Graphics.FromImage(blades[1]);
            //1
            Point p1 = new Point(650, 110);
            Point p2 = new Point(690, 45);
            Point p3 = new Point(720, 80);
            Point[] b12 = { p1, p2, p3 };
            graphics.FillPolygon(br, b12);
            graphics.DrawLine(Pens.Black, 650, 110, 690, 45);
            graphics.DrawLine(Pens.Black, 650, 110, 720, 80);
            graphics.DrawLine(Pens.Black, 690, 45, 720, 80);

            //2
            Point p4 = new Point(645, 120);
            Point p5 = new Point(570, 150);
            Point p6 = new Point(600, 180);
            Point[] b22 = { p4, p5, p6 };
            graphics.FillPolygon(br, b22);
            graphics.DrawLine(Pens.Black, 645, 120, 570, 150);
            graphics.DrawLine(Pens.Black, 645, 120, 600, 180);
            graphics.DrawLine(Pens.Black, 570, 150, 600, 180);

            //3
            Point p7 = new Point(645, 110);
            Point p8 = new Point(565, 80);
            Point p9 = new Point(600, 45);
            Point[] b32 = { p7, p8, p9 };
            graphics.FillPolygon(br, b32);
            graphics.DrawLine(Pens.Black, 645, 110, 600, 45);
            graphics.DrawLine(Pens.Black, 645, 110, 565, 80);
            graphics.DrawLine(Pens.Black, 600, 45, 565, 80);

            //4
            Point pp1 = new Point(650, 120);
            Point pp2 = new Point(715, 150);
            Point pp3 = new Point(685, 185);
            Point[] b42 = { pp1, pp2, pp3 };
            graphics.FillPolygon(br, b42);
            graphics.DrawLine(Pens.Black, 650, 120, 715, 150);
            graphics.DrawLine(Pens.Black, 650, 120, 685, 185);
            graphics.DrawLine(Pens.Black, 715, 150, 685, 185);

            //-------------

            //float skyG = Color.LightPink.G;
            //float skyB = Color.PaleVioletRed.B;
            //-------------
            timer1 = new Timer { Interval = 2000 };
            timer1.Tick += Tick1;
            timer1.Start();

            but.Text = "Start";
            but.Size = new Size(80, 40);
            but.Location = new Point(10, 10);
            ///////////////////////////////////////Click
            but.Click += new EventHandler(but_Click);
            this.Controls.Add(but);
        }
        ////////////////////////Обработка Click
        private void but_Click(object sender, EventArgs e)
        {
            picture = new PictureBox { Image = new Bitmap(1000, 500), Location = new Point(0, 0), Size = new Size(1000, 1000) };
            Controls.Add(picture);
            

            timer = new Timer { Interval = 500 };
            timer.Tick += Tick;
            timer.Start();

        }
        private void Tick1(object sender, EventArgs e)
        {
            Random random = new Random();
            but.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }





        private void Tick(object sender, EventArgs e)
        {
            

            var graphics = Graphics.FromImage(picture.Image);
            graphics.Clear(Color.Lavender);
            graphics.DrawImageUnscaled(house, 0, 0, 500, 500);
            graphics.DrawImageUnscaled(mill, 0, 0, 100, 500);
            graphics.DrawImageUnscaled(smoke[animation], 0, 0, 500, 500);
            graphics.DrawImageUnscaled(blades[animation1], 0, 0, 1000, 500);

           

            if (++animation1 >= blades.Length) animation1 = 0;
            if (++animation >= smoke.Length) animation = 0;
            picture.Invalidate();

           



        }


    }
}
    





