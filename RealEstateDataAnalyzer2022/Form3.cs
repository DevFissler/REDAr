using ScottPlot.Plottable;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace RealEstateDataAnalyzer2022
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            scatterPlot.Visible = true;

            double[] xs2 = Form1.xdatas.Select(x => x.ToOADate()).ToArray();
            double[] ys2 = Form1.ydatas.ToArray();

            scatterPlot.Plot.AddScatter(xs2, ys2, lineWidth: 0, label: "markers only");

            // Then tell the axis to display tick labels using a time format
            scatterPlot.Plot.XAxis.DateTimeFormat(true);

            scatterPlot.Plot.Title(Form1.danjiName + " " + Form1.pyeongFullName + " 년도별 계약금액 추이");
            scatterPlot.Plot.YLabel("계약금액(만원)");
            
            scatterPlot.Refresh();

            
        }

        public string FormCapture(Size _FormSize)
        {
            string strOutput = Form1.danjiName + "_" + Form1.pyeongFullName + " 년도별 계약금액 추이.png";
            Bitmap bmp = new Bitmap(_FormSize.Width, _FormSize.Height);
            Graphics grp = Graphics.FromImage(bmp);
            grp.CopyFromScreen(new Point(this.Bounds.X, this.Bounds.Y), new Point(0, 0), _FormSize);
            bmp.Save(strOutput, System.Drawing.Imaging.ImageFormat.Png);

            return strOutput;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

            FormCapture(new Size(this.Bounds.Width, this.Bounds.Height));
            MessageBox.Show("Graph Saved Successfully !!!", "Info");

        }
    }
}
