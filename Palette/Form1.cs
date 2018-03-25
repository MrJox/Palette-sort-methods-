using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace Palette
{
    public partial class Form1 : Form
    {
        private string[] color1, color2;
        private int delay, c;
        Stopwatch stopWatch = new Stopwatch();
        Stopwatch stopWatch1 = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            new System.Windows.Forms.Timer() { Interval = 50, Enabled = true }.Tick += delegate { Invalidate(); };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            label1.Top = 15;
            label2.Top = 15;
            label1.Left = 40;
            label2.Left = 560;
        }

        private void delay0_CheckedChanged(object sender, EventArgs e)
        {
            if (delay0.Checked)
                delay = 0;
            else if (delay1.Checked)
                delay = 1;
            else if (delay10.Checked)
                delay = 10;
            else if (delay100.Checked)
                delay = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var thread1 = new Thread(() => Insert(color1)) { IsBackground = true };
            var thread2 = new Thread(() => Shell(color2)) { IsBackground = true };
            thread1.Start();
            thread2.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e.Graphics, color1, new Rectangle(label1.Location.X - 10, label1.Location.Y + 25, 500, 500));
            Draw(e.Graphics, color2, new Rectangle(label2.Location.X - 10, label2.Location.Y + 25, 500, 500));
        }

        private void Draw(Graphics gr, string[] color, Rectangle rect)
        {
            TimeSpan ts = stopWatch.Elapsed;
            TimeSpan ts1 = stopWatch1.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            string elapsedTime1 = String.Format("{0:00}:{1:00}.{2:00}", ts1.Minutes, ts1.Seconds, ts1.Milliseconds / 10);
            int Size = 500 / int.Parse(Math.Sqrt(color.Length).ToString());
            SolidBrush[] myBrush = new SolidBrush[color.Length];

            gr.ResetTransform();
            var r = rect;
            r.Inflate(0, 0);
            gr.DrawRectangle(Pens.Black, r);
            gr.TranslateTransform(rect.X, rect.Y);

            c = 0;
            for (int i = 0; i < int.Parse(Math.Sqrt(color.Length).ToString()); i++)
            {
                for (int j = 0; j < int.Parse(Math.Sqrt(color.Length).ToString()); j++)
                {
                    myBrush[c] = new SolidBrush(ColorTranslator.FromHtml("#" + color[c]));
                    gr.FillRectangle(myBrush[c], new Rectangle(j * Size, i * Size, Size, Size));
                    c++;
                }
            }
            label4.Text = "Затрачено: " + elapsedTime;
            label5.Text = "Затрачено: " + elapsedTime1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stopWatch.Reset();
            stopWatch1.Reset();
            label4.Text = label5.Text = "Затрачено: 00:00.00";
            int Amount = int.Parse(comboBox1.SelectedItem.ToString());
            color1 = new string[Amount];
            color2 = new string[Amount];
            var random = new Random();
            
            for (int i = 0; i < Amount; i += 2)
            {
                color1[i] = color2[i] = String.Format("FF{0:X4}", random.Next(0x100));
            }
            for (int i = 1; i < Amount; i += 2)
            {
                color1[i] = color2[i] = String.Format("{0:X2}0000", random.Next(0x100));
            }
        }

        void Insert(string[] color)
        {
            stopWatch.Start();
            for (int i = 0; i < color.Length; i++)
            {
                string current = color[i];
                int j = i;
                while (j > 0 && Convert.ToInt32(current, 16) < Convert.ToInt32(color[j - 1], 16))
                {
                    color[j] = color[j - 1];
                    j--;
                }
                color[j] = current;
                Thread.Sleep(delay);
            }
            stopWatch.Stop();
        }

        void Shell(string[] color)
        {
            stopWatch1.Start();
            int j;
            int step = color.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (color.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (Convert.ToInt32(color[j], 16) > Convert.ToInt32(color[j + step], 16)))
                    {
                        string current = color[j];
                        color[j] = color[j + step];
                        color[j + step] = current;
                        j -= step;
                    }
                }
                step = step / 2;
                Thread.Sleep(delay);
            }
            stopWatch1.Stop();
        }
    }
}