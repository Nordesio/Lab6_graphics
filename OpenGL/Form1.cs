using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using SharpGL.SceneGraph;

namespace Lab6_graphics
{
    public partial class Form1 : Form
    {
        OpenGL GL;
        public Form1()
        {
            openglControl1 = new OpenGLControl();
            GL = openglControl1.OpenGL;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            openglControl1.Width = this.Width - 30;
            openglControl1.Height = this.Height - 100;

            GL.MatrixMode(OpenGL.GL_PROJECTION);
            GL.LoadIdentity();

            GL.Perspective(80, 4 / 3, 0.1, 200);
            GL.LookAt(0, 0, 20, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(OpenGL.GL_MODELVIEW);
            GL.LoadIdentity();

            //GL.ClearColor(0.1f, 1f, 1.3f, 1);

            GL.Clear(OpenGL.GL_COLOR_BUFFER_BIT |
                OpenGL.GL_DEPTH_BUFFER_BIT);
          
        }
        double x = 30;
        double _x = -30;
        double y = 30;
        double _y = -30;
        private void openglControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            GL.Clear(OpenGL.GL_COLOR_BUFFER_BIT |
                OpenGL.GL_DEPTH_BUFFER_BIT);
            GL.Color(Color.Red);
            /*
            GL.Begin(OpenGL.GL_LINES);

            GL.Vertex(0, 0, 0);
            GL.Vertex(10, 0, 0);

            GL.Color(Color.Yellow);
            GL.Vertex(0, 0, 0);
            GL.Vertex(0, 10, 0);

            GL.Color(Color.Blue);
            GL.Vertex(0, 0, 0);
            GL.Vertex(0, 0, 10);
            GL.End();
            //Pacman*/

            DrawCircle(0, 5f, 2f, Color.Yellow);

            //G


            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-8.5 + _x, 0, 0);
            GL.Vertex(-8.5 + _x, -0.5, 0);
            GL.Vertex(-10 + _x, -0.5, 0);
            GL.Vertex(-10 + _x, 0, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-10 + _x, -0.5, 0);
            GL.Vertex(-10 + _x, -4, 0);
            GL.Vertex(-9.7 + _x, -4, 0);
            GL.Vertex(-9.7 + _x, -0.5, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-9.7 + _x, -4, 0);
            GL.Vertex(-9.7 + _x, -3.5, 0);
            GL.Vertex(-8.5 + _x, -3.5, 0);
            GL.Vertex(-8.5 + _x, -4, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-8.5 + _x, -3.5, 0);
            GL.Vertex(-8.5 + _x, -1.5, 0);
            GL.Vertex(-8.8 + _x, -1.5, 0);
            GL.Vertex(-8.8 + _x, -3.5, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-8.8 + _x, -1.5, 0);
            GL.Vertex(-8.8 + _x, -2, 0);
            GL.Vertex(-9.2 + _x, -2, 0);
            GL.Vertex(-9.2 + _x, -1.5, 0);
            GL.End();
            //A
            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-8.2, -3.5 + _y, 0);
            GL.Vertex(-8.2, -4 + _y, 0);
            GL.Vertex(-7, -0.5 + _y, 0);
            GL.Vertex(-7, 0 + _y, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-5.8, -3.5 + _y, 0);
            GL.Vertex(-5.8, -4 + _y, 0);
            GL.Vertex(-7, -0.5 + _y, 0);
            GL.Vertex(-7, 0 + _y, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-7.6, -1.8 + _y, 0);
            GL.Vertex(-7.6, -2.2 + _y, 0);
            GL.Vertex(-6.4, -2.2 + _y, 0);
            GL.Vertex(-6.4, -1.8 + _y, 0);
            GL.End();

            //M

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-5.5, -4 + y, 0);
            GL.Vertex(-5.5, -0 + y, 0);
            GL.Vertex(-5.2, -0 + y, 0);
            GL.Vertex(-5.2, -4 + y, 0);
            GL.End();


            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-5.2, 0 + y, 0);
            GL.Vertex(-5.2, -0.4 + y, 0);
            GL.Vertex(-4.5, -2 + y, 0);
            GL.Vertex(-4.5, -1.6 + y, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-3.8, 0 + y, 0);
            GL.Vertex(-3.8, -0.4 + y, 0);
            GL.Vertex(-4.5, -2 + y, 0);
            GL.Vertex(-4.5, -1.6 + y, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-3.8, -4 + y, 0);
            GL.Vertex(-3.8, -0 + y, 0);
            GL.Vertex(-3.5, -0 + y, 0);
            GL.Vertex(-3.5, -4 + y, 0);
            GL.End();

            //E

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-3.2, -4 + _y, 0);
            GL.Vertex(-3.2, -0 + _y, 0);
            GL.Vertex(-2.9, -0 + _y, 0);
            GL.Vertex(-2.9, -4 + _y, 0);
            GL.End();


            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-2.9, 0 + _y, 0);
            GL.Vertex(-2.9, -0.5 + _y, 0);
            GL.Vertex(-1.5, -0.5 + _y, 0);
            GL.Vertex(-1.5, 0 + _y, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-2.9, -3.5 + _y, 0);
            GL.Vertex(-2.9, -4 + _y, 0);
            GL.Vertex(-1.5, -4 + _y, 0);
            GL.Vertex(-1.5, -3.5 + _y, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(-2.9, -1.75 + _y, 0);
            GL.Vertex(-2.9, -2.25 + _y, 0);
            GL.Vertex(-1.5, -2.25 + _y, 0);
            GL.Vertex(-1.5, -1.75 + _y, 0);
            GL.End();


            //O

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(1.5, 0 + y, 0);
            GL.Vertex(1.5, -4 + y, 0);
            GL.Vertex(3.1, -4 + y, 0);
            GL.Vertex(3.1, 0 + y, 0);
            GL.End();


            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Black);
            GL.Vertex(1.7, -0.5 + y, 0);
            GL.Vertex(1.7, -3.5 + y, 0);
            GL.Vertex(2.9, -3.5 + y, 0);
            GL.Vertex(2.9, -0.5 + y, 0);
            GL.End();

            //V

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(3.4, 0 + _y, 0);
            GL.Vertex(3.4, -0.5 + _y, 0);
            GL.Vertex(4.6, -4 + _y, 0);
            GL.Vertex(4.6, -3.5 + _y, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(5.8, 0 + _y, 0);
            GL.Vertex(5.8, -0.5 + _y, 0);
            GL.Vertex(4.6, -4 + _y, 0);
            GL.Vertex(4.6, -3.5 + _y, 0);
            GL.End();




            //E

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(6.1, -4 + y, 0);
            GL.Vertex(6.1, -0 + y, 0);
            GL.Vertex(6.4, -0 + y, 0);
            GL.Vertex(6.4, -4 + y, 0);
            GL.End();


            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(6.4, 0 + y, 0);
            GL.Vertex(6.4, -0.5 + y, 0);
            GL.Vertex(7.8, -0.5 + y, 0);
            GL.Vertex(7.8, 0 + y, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(6.4, -3.5 + y, 0);
            GL.Vertex(6.4, -4 + y, 0);
            GL.Vertex(7.8, -4 + y, 0);
            GL.Vertex(7.8, -3.5 + y, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(6.4, -1.75 + y, 0);
            GL.Vertex(6.4, -2.25 + y, 0);
            GL.Vertex(7.8, -2.25 + y, 0);
            GL.Vertex(7.8, -1.75 + y, 0);
            GL.End();

            //R

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(8.1 + x, -4, 0);
            GL.Vertex(8.1 + x, -0, 0);
            GL.Vertex(8.4 + x, -0, 0);
            GL.Vertex(8.4 + x, -4, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(8.4 + x, 0, 0);
            GL.Vertex(8.4 + x, -2.2, 0);
            GL.Vertex(9.5 + x, -2.2, 0);
            GL.Vertex(9.5 + x, -0, 0);
            GL.End();

            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Black);
            GL.Vertex(8.4 + x, -0.3, 0);
            GL.Vertex(8.4 + x, -1.9, 0);
            GL.Vertex(9.35 + x, -1.9, 0);
            GL.Vertex(9.35 + x, -0.3, 0);
            GL.End();


            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Blue);
            GL.Vertex(8.1 + x, -1.65, 0);
            GL.Vertex(8.1 + x, -2.15, 0);
            GL.Vertex(9.2 + x, -4, 0);
            GL.Vertex(9.5 + x, -4, 0);
            GL.End();






            if (x > 0)
                x -= 0.25;
            if (_x < 0)
                _x += 0.25;
            if (y > 0)
                y -= 0.25;
            if (_y < 0)
                _y += 0.25;
        }
        public void DrawCircle(float x, float y, float radius, Color c)
        {
           
            GL.Begin(OpenGL.GL_TRIANGLE_FAN);
            GL.Color(c);

            GL.Vertex(x, y);
            
            for (int i = 0; i < 240; i++)
            {
                GL.Vertex(x + Math.Cos(i) * radius, y + Math.Sin(i) * radius);
            }


            GL.End();
            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Black);
            GL.Vertex(-0.6, 6.7, 0);
            GL.Vertex(-0.6, 6.4, 0);
            GL.Vertex(-0.3, 5.7, 0);
            GL.Vertex(-0.3, 6, 0);
            GL.End();


            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Black);
            GL.Vertex(-0.6, 5.7, 0);
            GL.Vertex(-0.6, 6, 0);
            GL.Vertex(-0.3, 6.7, 0);
            GL.Vertex(-0.3, 6.4, 0);
            GL.End();


            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Black);
            GL.Vertex(0.15, 6.7, 0);
            GL.Vertex(0.15, 6.4, 0);
            GL.Vertex(0.45, 5.7, 0);
            GL.Vertex(0.45, 6, 0);
            GL.End();


            GL.Begin(OpenGL.GL_POLYGON);
            GL.Color(Color.Black);
            GL.Vertex(0.15, 5.7, 0);
            GL.Vertex(0.15, 6, 0);
            GL.Vertex(0.45, 6.7, 0);
            GL.Vertex(0.45, 6.4, 0);
            GL.End();



            GL.Begin(OpenGL.GL_TRIANGLES);
            GL.Color(Color.Black);
            GL.Vertex(0, 5, 0);
            GL.Vertex(2, 7, 0);
            GL.Vertex(2, 3, 0);
            GL.End();

        }
    }
}
