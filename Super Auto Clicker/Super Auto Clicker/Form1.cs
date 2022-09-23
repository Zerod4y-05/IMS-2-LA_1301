using System.Runtime.InteropServices;
using System.Threading;

namespace Super_Auto_Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]

        static extern void mouse_event(int dwFlags, int dx, int dy, int dwdata, int dwextrainfo);
        public enum mouseeventflags
        {
            LeftDown = 2,
            LeftUp = 4,
        }

        public void leftclick(Point p)
        {
            mouse_event((int)(mouseeventflags.LeftDown), p.X, p.Y, 0, 0);
            mouse_event((int)(mouseeventflags.LeftUp), p.X, p.Y, 0, 0);
        }
        bool stop = true;

        private void button1_Click(object sender, EventArgs e)
        {
            stop = (stop) ? false : true;
            timer1.Interval = (int)numericUpDown1.Value;
            timer1.Enabled = true;

            timer2.Interval = (int)numericUpDown1.Value;
            timer2.Enabled = true;

            timer3.Interval = (int)numericUpDown1.Value;
            timer3.Enabled = true;

            timer4.Interval = (int)numericUpDown1.Value;
            timer4.Enabled = true;

            timer5.Interval = (int)numericUpDown1.Value;
            timer5.Enabled = true;

            timer6.Interval = (int)numericUpDown1.Value;
            timer6.Enabled = true;

            timer7.Interval = (int)numericUpDown1.Value;
            timer7.Enabled = true;

            timer8.Interval = (int)numericUpDown1.Value;
            timer8.Enabled = true;

            timer9.Interval = (int)numericUpDown1.Value;
            timer9.Enabled = true;

            timer10.Interval = (int)numericUpDown1.Value;
            timer10.Enabled = true;

            timer11.Interval = (int)numericUpDown1.Value;
            timer11.Enabled = true;

            timer12.Interval = (int)numericUpDown1.Value;
            timer12.Enabled = true;

            timer13.Interval = (int)numericUpDown1.Value;
            timer13.Enabled = true;

            timer14.Interval = (int)numericUpDown1.Value;
            timer14.Enabled = true;

            timer15.Interval = (int)numericUpDown1.Value;
            timer15.Enabled = true;



            if (!stop)
            {
                Thread.Sleep(1000);
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                timer5.Start();
                timer6.Start();
                timer7.Start();
                timer8.Start();
                timer9.Start();
                timer10.Start();
                timer11.Start();
                timer12.Start();
                timer13.Start();
                timer14.Start();
                timer15.Start();
            }
            if (stop)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                timer6.Stop();
                timer7.Stop();
                timer8.Stop();
                timer9.Stop();
                timer10.Stop();
                timer11.Stop();
                timer12.Stop();
                timer13.Stop();
                timer14.Stop();
                timer15.Stop();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

    }
}