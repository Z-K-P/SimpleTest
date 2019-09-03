using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Red);
            PointF[] f = { new PointF(50, 50), new PointF(75, 25), new PointF(100, 50), new PointF(100, 75), new PointF(50, 75) };
            Graphics g = this.CreateGraphics();
            PathGradientBrush brush = new PathGradientBrush(f);
            brush.CenterColor = Color.Blue;
            Color[] cls = { Color.Red,Color.Green,Color.Yellow,Color.Pink};
            brush.SurroundColors = cls;
            //g.DrawPolygon(p,f);
            g.FillClosedCurve(brush,f);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //    //设置坐标
            //    PointF p1 = new PointF(20.0f,20.0f);
            //    PointF p2 = new PointF(200.0f,200.0f);

            //    //设置颜色
            //     Color c = Color.FromArgb(255,80,80,80);

            //    //设置画笔样式
            //    Pen p = new Pen(c,2.5f);

            //    //设置填充样式
            //    LinearGradientBrush brush = new LinearGradientBrush(p2,p1,Color.Red,Color.Blue);

            //    //设置填充图案
            //    HatchBrush habrush = new HatchBrush(HatchStyle.SmallCheckerBoard,Color.Green);

            //    //设置填充图片
            //    TextureBrush textbrush = new TextureBrush(Image.FromFile(@"C:\Users\Administrator\Desktop\test.jpg"), new RectangleF(50.0f,50.0f,200,200));

            //    //设置路径
            //    GraphicsPath path= new GraphicsPath();


            //    //设置渐变
            //    PathGradientBrush pgb = new PathGradientBrush(path);
            //    //pgb.CenterColor = Color.Red;
            //    pgb.SurroundColors = new Color[] { Color.Blue, Color.LightYellow };


            //    //开始绘画
            //    Graphics g = e.Graphics;

            //    //画线段
            //    g.DrawLine(p, p1, p2);

            //    //画文字
            //    string txt = "测试文字测试文字测试文字测试文字测试文字测试文字测试文字测试文字测试文字";
            //    FontFamily family = new FontFamily("宋体");
            //    Font f = new Font(family, 20);

            //    g.DrawString(txt,f,brush,p1);

            //    //画五边形，并设置填充
            //    PointF[] five = { new PointF(20.0f, 20.0f) , new PointF(25.0f, 25.0f), new PointF(22.5f, 22.5f) , new PointF(17.5f, 17.5f) , new PointF(15.0f, 15.0f) };
            //    g.DrawPolygon(p,five);

            //    PointF[] three = { new PointF(255.0f,255.0f), new PointF(255.0f, 205.0f) , new PointF(205.0f, 205.0f) };
            //    //画三角形
            //    g.FillPolygon(habrush,three);

            //    //画图片。。。
            //    g.FillRectangle(textbrush,new RectangleF(50.0f,50.0f,1500,1500));

            //    //渐变效果
            //    g.FillPath(pgb, path);
            //    g.DrawPath(p,path);
        }
    }
}
