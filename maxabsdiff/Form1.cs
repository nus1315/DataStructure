using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace maxabsdiff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int MaxDiff1(int[] a)
        {
            int maxdiff = 0;
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length; j++)
                {
                    int diff = Math.Abs(a[i] - a[j]);
                    if (diff > maxdiff)
                        maxdiff = diff;
                }
            return maxdiff;
        }
        static int MaxDiff2(int[] a)
        {
            int maxdiff = 0;
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                {
                    int diff = Math.Abs(a[i] - a[j]);
                    if (diff > maxdiff)
                        maxdiff = diff;
                }
            return maxdiff;
        }
        static int MaxDiff3(int[] a)
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }
            return max - min;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
            //MessageBox.Show("click");//เรียกwindow


            try
            {
                int maxn = int.Parse(textBox1.Text);
                chart1.ChartAreas[0].AxisX.Title = "n";
                chart1.ChartAreas[0].AxisY.Title = "ms";

                chart1.Series.Clear();
                Series algo1 = chart1.Series.Add("Algo1");
                algo1.ChartType = SeriesChartType.Line;
                algo1.MarkerStyle = MarkerStyle.Circle;

                Series algo2 = chart1.Series.Add("Algo2");
                algo2.ChartType = SeriesChartType.Line;
                algo2.MarkerStyle = MarkerStyle.Circle;

                Series algo3 = chart1.Series.Add("Algo3");
                algo3.ChartType = SeriesChartType.Line;
                algo3.MarkerStyle = MarkerStyle.Circle;

                Stopwatch watch = new Stopwatch();
                for (int n = 1; n < maxn; n *= 2)
                {
                    int[] a = new int[n];
                    watch.Reset();
                    watch.Start();
                    MaxDiff1(a);
                    watch.Stop();
                    algo1.Points.AddXY(n,
                            watch.ElapsedMilliseconds);//addทีละจุด

                    watch.Reset();
                    watch.Start();
                    MaxDiff2(a);
                    watch.Stop();
                    algo2.Points.AddXY(n,
                            watch.ElapsedMilliseconds);

                    watch.Reset();
                    watch.Start();
                    MaxDiff3(a);
                    watch.Stop();
                    algo3.Points.AddXY(n,
                            watch.ElapsedMilliseconds);
                    chart1.Update();
                }
            }
            catch
            {
                MessageBox.Show("Please input number");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
