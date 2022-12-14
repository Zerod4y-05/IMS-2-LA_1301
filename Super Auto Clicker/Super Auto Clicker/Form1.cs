using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Super_Auto_Clicker
{
    public partial class Form1 : Form
    {
        bool _stop = true;

        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")] static extern void mouse_event(int dwFlags, int dx, int dy, int dwdata, int dwextrainfo);

        public enum mouseeventflags
        {
            LeftDown = 2,
            LeftUp = 4,
        }

        public void leftclick(Point p)
        {
            if (checkBox1.Checked)
            {
                Random rd = new Random();
                Thread.Sleep(rd.Next(0, 50));
                mouse_event((int)(mouseeventflags.LeftDown), p.X, p.Y, 0, 0);
                Thread.Sleep(rd.Next(0, 50));
                mouse_event((int)(mouseeventflags.LeftUp), p.X, p.Y, 0, 0);
            }
            else
            {
                mouse_event((int)(mouseeventflags.LeftDown), p.X, p.Y, 0, 0);
                mouse_event((int)(mouseeventflags.LeftUp), p.X, p.Y, 0, 0);
            }
        }

        public void SetTimerInterval()
        {
            timer1.Interval = (int)numericUpDown1.Value;
            timer1.Enabled = false;

            timer2.Interval = (int)numericUpDown1.Value;
            timer2.Enabled = false;

            timer3.Interval = (int)numericUpDown1.Value;
            timer3.Enabled = false;

            timer4.Interval = (int)numericUpDown1.Value;
            timer4.Enabled = false;

            timer5.Interval = (int)numericUpDown1.Value;
            timer5.Enabled = false;

            timer6.Interval = (int)numericUpDown1.Value;
            timer6.Enabled = false;

            timer7.Interval = (int)numericUpDown1.Value;
            timer7.Enabled = false;

            timer8.Interval = (int)numericUpDown1.Value;
            timer8.Enabled = false;

            timer9.Interval = (int)numericUpDown1.Value;
            timer9.Enabled = false;

            timer10.Interval = (int)numericUpDown1.Value;
            timer10.Enabled = false;

            timer11.Interval = (int)numericUpDown1.Value;
            timer11.Enabled = false;

            timer12.Interval = (int)numericUpDown1.Value;
            timer12.Enabled = false;

            timer13.Interval = (int)numericUpDown1.Value;
            timer13.Enabled = false;

            timer14.Interval = (int)numericUpDown1.Value;
            timer14.Enabled = false;

            timer15.Interval = (int)numericUpDown1.Value;
            timer15.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _stop = (_stop) ? false : true;
            SetTimerInterval();

            if (!_stop)
            {
                Thread.Sleep(1000);
                switch (numericUpDown2.Value)
                {
                    case 1:
                        timer1.Start();
                        break;
                    case 2:
                        timer1.Start();
                        timer2.Start();
                        break;
                    case 3:
                        timer1.Start();
                        timer2.Start();
                        timer3.Start();
                        break;
                    case 4:
                        timer1.Start();
                        timer2.Start();
                        timer3.Start();
                        timer4.Start();
                        break;
                    case 5:
                        timer1.Start();
                        timer2.Start();
                        timer3.Start();
                        timer4.Start();
                        timer5.Start();
                        break;
                    case 6:
                        timer1.Start();
                        timer2.Start();
                        timer3.Start();
                        timer4.Start();
                        timer5.Start();
                        timer6.Start();
                        break;
                    case 7:
                        timer1.Start();
                        timer2.Start();
                        timer3.Start();
                        timer4.Start();
                        timer5.Start();
                        timer6.Start();
                        timer7.Start();
                        break;
                    case 8:
                        timer1.Start();
                        timer2.Start();
                        timer3.Start();
                        timer4.Start();
                        timer5.Start();
                        timer6.Start();
                        timer7.Start();
                        timer8.Start();
                        break;
                    case 9:
                        timer1.Start();
                        timer2.Start();
                        timer3.Start();
                        timer4.Start();
                        timer5.Start();
                        timer6.Start();
                        timer7.Start();
                        timer8.Start();
                        timer9.Start();
                        break;
                    case 10:
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
                        break;
                    case 11:
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
                        break;
                    case 12:
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
                        break;
                    case 13:
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
                        break;
                    case 14:
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
                        break;
                    case 15:
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
                        break;
                    default:
                        timer1.Start();
                        break;
                }
            }
            if (_stop)
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