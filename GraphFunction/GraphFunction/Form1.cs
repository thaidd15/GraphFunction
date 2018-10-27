using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random random = new Random();
        private int n, x0, y0, xmax, ymax, min, max, x1, y1, x2, y2;
        private int k = 30;
        private double x, dx, fx1, fx2;
        private string s1, s2;

        //Calculate value of function y=f(x) with value x
        private double f(double x, string s2)
        {
            double result;

            Expression exp = new Expression(s2);
            if (exp.Convert_To_CharArray() == false)
            {
                MessageBox.Show("Error. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (exp.Convert_Infix_To_Postfix() == false)
            {
                MessageBox.Show("Error. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            result = exp.Evaluate_Postfix(x);
            return result;
        }

        //Draw OXY
        private void DrawOXY()
        {
            Graphics g = Graph.CreateGraphics();
            xmax = Graph.Width;
            ymax = Graph.Height;
            x0 = xmax / 2;
            y0 = ymax / 2;
            min = -x0 / k;
            max = x0 / k;
            Pen p1 = new Pen(Color.Black, 2);
            Pen p2 = new Pen(Color.Gray, 1);
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Black);
            Font f1 = new Font("Arial", 12);
            Font f2 = new Font("Arial", 10);
            //Draw OY
            g.DrawLine(p1, x0, 0, x0, ymax);
            //Draw OX
            g.DrawLine(p1, 0, y0, xmax, y0);
            g.DrawString("O", f1, b1, x0, y0);
            g.DrawString("X", f1, b1, xmax - 15, y0 - 18);
            g.DrawString("Y", f1, b1, x0, 0);
            n = 1;
            for (int i = x0 + k; i < xmax; i += k)
            {
                g.DrawLine(p2, i, 0, i, ymax);
                g.DrawString(n.ToString(), f2, b2, i, y0);
                n++;
            }
            n = 1;
            for (int i = x0 - k; i > 0; i -= k)
            {
                g.DrawLine(p2, i, 0, i, ymax);
                g.DrawString("-" + n.ToString(), f2, b2, i, y0);
                n++;
            }
            n = 1;
            for (int i = y0 - k; i > 0; i -= k)
            {
                g.DrawLine(p2, 0, i, xmax, i);
                g.DrawString(n.ToString(), f2, b2, x0 - 18, i);
                n++;
            }
            n = 1;
            for (int i = y0 + k; i < ymax; i += k)
            {
                g.DrawLine(p2, 0, i, xmax, i);
                g.DrawString("-" + n.ToString(), f2, b2, x0 - 22, i);
                n++;
            }
        }

        //Draw Graph
        private void DrawGraph()
        {
            Graph.Controls.Clear();
            Graph.Refresh();

            DrawOXY();
            Graphics g = Graph.CreateGraphics();

            //Input text
            s1 = Inputtxt.Text;
            s2 = s1.ToLower();

            string[] graphics = s2.Split('\n');

            for (int i = 0; i < graphics.Length; i++)
            {
                Color color = Color.FromArgb(
                    (byte)random.Next(0, 256),
                    (byte)random.Next(0, 256),
                    (byte)random.Next(0, 256));

                Pen pen = new Pen(color, 2);

                x = min;
                dx = 1.0f / k;
                fx1 = f(x, graphics[i]);

                if (!double.IsNaN(fx1))
                {
                    //add label - function x
                    Label label = new Label()
                    {
                        Text = graphics[i],
                        Font = new Font(Font.FontFamily, 18),
                        ForeColor = color,
                        Location = new Point(0, 35 * i),
                        AutoSize = true,
                    };

                    Graph.Controls.Add(label);
                }

                x1 = x0 + (int)(x * k);
                y1 = y0 - (int)(fx1 * k);
                while (x < max)
                {
                    x += dx;
                    fx2 = f(x, graphics[i]);
                    x2 = x0 + (int)(x * k);
                    y2 = y0 - (int)(fx2 * k);
                    try
                    {
                        if (!((fx1 * fx2 < 0) && (Math.Abs((int)(fx1 - fx2)) > k)))
                        {
                            //Draw graph
                            g.DrawLine(pen, x1, y1, x2, y2);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                    x1 = x2;
                    y1 = y2;
                    fx1 = fx2;
                }
            }
        }

        private void Drawbtn_Click(object sender, EventArgs e)
        {
            if (Inputtxt.Text.Equals("") == true)
            {
                MessageBox.Show("Error Input. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DrawGraph();
            }
        }

        private void ZoomInbtn_Click(object sender, EventArgs e)
        {
            if (Inputtxt.Text.Equals("") == true)
            {
                MessageBox.Show("Error Input. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                k += 5;
                DrawGraph();
            }
        }

        private void ZoomOutbtn_Click(object sender, EventArgs e)
        {
            if (Inputtxt.Text.Equals("") == true)
            {
                MessageBox.Show("Error Input. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (k > 10)
                {
                    k -= 5;
                    DrawGraph();
                }
            }
        }

        //Calculate integral of function
        private void Integralbtn_Click(object sender, EventArgs e)
        {
            s1 = Inputtxt.Text;
            s2 = s1.ToLower();
            if ((Inputtxt.Text.Equals("") == true) || (Lowertxt.Text.Equals("") == true) || (Uppertxt.Text.Equals("") == true) || (Iterationtxt.Text.Equals("") == true))
            {
                MessageBox.Show("Error Input. Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double result;
                Integral I = new Integral();
                result = I.Calculate_Integral(Lowertxt.Text.ToLower(), Uppertxt.Text.ToLower(), Iterationtxt.Text.ToLower(), s2);
                Integral.Text = "Integral of function: I = " + result.ToString();
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Inputtxt.ResetText();
                Integral.ResetText();
                Graph.Refresh();
                k = 30;
                DrawOXY();
                Lowertxt.ResetText();
                Uppertxt.ResetText();
                Iterationtxt.ResetText();
            }
        }
    }
}