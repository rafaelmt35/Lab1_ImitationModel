using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dt = 0.01; //time step// delta t
        double x, y, v0, t, sina, cosa, m, S, k, vx, vy, vend;

       

        int series = 1;

        private void btNew_Click(object sender, EventArgs e)
        {
            chart1.Series.Add("Series" + (series+1).ToString());
            chart1.Series["Series" + (series + 1).ToString()].XValueType = ChartValueType.Auto;
            chart1.Series["Series" + (series + 1).ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Series" + (series + 1).ToString()].BorderWidth = 3;
            series += 1;
        }


    

        int index = 0;


        const double g = 9.81;  //Gravity 
        const double C = 0.15;
        const double rho = 1.29;    //Rho 
       
        List<double> arrayY;
        


        private void resetButton_Click(object sender, EventArgs e)
        {
            resultTime.Text = "...";
            resultDistance.Text = "...";
            resultMaxHeight.Text = "...";
            resultSpeedEndPoint.Text = "...";
            
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = t + dt;
            double vxold = vx;
            double vyold = vy;
            double vroot = Math.Sqrt(vx * vx + vy * vy);
            vx = vxold - k * vxold * vroot * dt;
            vy = vyold - (g + k * vyold * vroot) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
           
         

            chart1.Series["Series" + (series).ToString()].Points.AddXY(x, y);
            if (y > 0)
            {
                arrayY.Add(y);
            }
            if (y <= 0)
            {
                timer1.Stop();
                index += 1;
                vend = Math.Sqrt(vx * vx + vy * vy);
                resultTime.Text = (Math.Round(t,2)).ToString();
                resultDistance.Text = (Math.Round(x,2)).ToString();
                resultSpeedEndPoint.Text =(Math.Round(vend, 2)).ToString();
                resultMaxHeight.Text = (Math.Round(arrayY.Max(), 2)).ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*chart1.Series[0].Points.Clear();*/
            
            t = 0;
            x = 0;
            y = (double)numHeight.Value;
            v0 = (double)numSpeed.Value;
            arrayY = new List<double>();
            //Change angle to Radiant
            double a = (double)numAngle.Value * Math.PI / 180;

            sina = Math.Sin(a);
            cosa = Math.Cos(a);
            S = (double)numArea.Value;  //area  
            m = (double)numWeight.Value;    //weight вес
            k = 0.5 * C * S * rho / m;
            vx = v0 * cosa; //vox
            vy = v0 * sina; //voy

            
            chart1.Series["Series" + (series).ToString()].Points.AddXY(x, y);

            timer1.Start();
            
        }

    }
}
