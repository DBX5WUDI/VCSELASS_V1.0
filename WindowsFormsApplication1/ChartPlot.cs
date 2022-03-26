using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class NMRG_VCSEL : Form
    {
        private bool isMouseDown = false;
        private int lastMove = 0; // 用于记录鼠标上次移动的点，用于判断是上移还是下移
        private void InitChart()
        {
            //定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("V");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            //设置图表显示样式
            this.chart1.ChartAreas[0].BackColor = System.Drawing.Color.Snow;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.chart1.ChartAreas[0].AxisY.IsLabelAutoFit = true;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            this.chart1.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.chart1.ChartAreas[0].AxisY.ScaleView.Size = 0.1;
            this.chart1.ChartAreas[0].AxisY.LabelStyle.Format = @"{0:0.000}";
            this.chart1.ChartAreas[0].Position.X = 0F;
            this.chart1.ChartAreas[0].Position.Y = 0F;
            this.chart1.ChartAreas[0].Position.Height = 100F;
            this.chart1.ChartAreas[0].Position.Width = 100F;
            //设置标题
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "光电探测器反馈图";
            this.chart1.Titles[0].ForeColor = Color.Black;
            this.chart1.Titles[0].Font = new System.Drawing.Font("黑体", 15F);
            //设置图表显示样式
            this.chart1.Series[0].Color = Color.BlueViolet;
            this.chart1.Series[0].ChartType = SeriesChartType.Line;
            this.chart1.Series[0].BorderWidth = 3;
            this.chart1.Series[0].Points.Clear();
        }
        private void Chart1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Items.Clear();

                contextMenuStrip1.Items.Add(toolStripMenuItem1);
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);//一定要是MousePosition.X,MousePosition.
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                contextMenuStrip1.Close();
                lastMove = 0;
                isMouseDown = true;
            }
        }
        private void Chart1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            //this.chart1.ChartAreas[0].AxisY.IsLabelAutoFit = false;
            if (e.Delta < 0&&chart1.ChartAreas[0].AxisY.ScaleView.Size > 0) // 防止越过左边界
            {
                chart1.ChartAreas[0].AxisY.ScaleView.Size *= 1.1; //+= 0.1*(e.Delta / 120); // 每次缩放1
            }
            else if (e.Delta > 0)
            {
                chart1.ChartAreas[0].AxisY.ScaleView.Size *= 0.909;//+= 0.1*(e.Delta / 120); // 每次缩放1
            }  
        }
        private void ToolStripMenuItem1_MouseDown(object sender, MouseEventArgs e)
        {
            chart1.Series[0].Points.Clear();
            iGlobal = 0;
            contextMenuStrip1.Close();
        }
        private void Chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                if (lastMove != 0 && e.Y - lastMove > 0)
                    chart1.ChartAreas[0].AxisY.ScaleView.Position += 0.007*chart1.ChartAreas[0].AxisY.ScaleView.Size;  // 每次向右移动1
                else if (lastMove != 0 && e.Y - lastMove < 0)
                    chart1.ChartAreas[0].AxisY.ScaleView.Position -= 0.007* chart1.ChartAreas[0].AxisY.ScaleView.Size; // 每次向左移动1
                lastMove = e.Y;
            }
        }

    }
}
