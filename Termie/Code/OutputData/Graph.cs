using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using ZedGraph;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using Axis = System.Windows.Forms.DataVisualization.Charting.Axis;

namespace Termie
{
    public partial class MainForm : Form
    {
        #region Chart const var
        public const string Breath = "Breath";
        public const string RPM = "RPM";
        public const string Pressure = "Pressure";
        public const string LRPM = "LRPM";
        public const string RRPM = "RRPM";
        #endregion
        #region Graph

        public const int scrollSize = 5;
        public void ScrollBarMove(ChartArea chartArea, double ftime)
        {
            if (ftime < scrollSize)
                return;
            chartArea.AxisX.Maximum = ftime;
            chartArea.AxisX.ScaleView.Position = ftime- scrollSize;
            chartArea.AxisX.RoundAxisValues();

            //chartArea.AxisX.Minimum = Math.Ceiling(ftime) - scrollSize;
            //chartArea.AxisX.IntervalOffset = 0;
            //chartArea.AxisX.RoundAxisValues();
        }
        public void ScrollBarMoveAll(double ftime)
        {
            ScrollBarMove(ChartBreath.ChartAreas[Breath], ftime);
            ScrollBarMove(ChartRPM.ChartAreas[RPM], ftime);
            ScrollBarMove(ChartPressure.ChartAreas[Pressure], ftime);
        }
        public void AxisXIntervalSet(Axis axisX)
        {
            axisX.Interval = 1;
            axisX.MajorGrid.Enabled = true;
            axisX.MajorGrid.LineColor = Color.DimGray;
            axisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;

            axisX.MinorGrid.Enabled = true;
            axisX.MinorGrid.LineColor = Color.Gray;
            axisX.MinorGrid.LineDashStyle = ChartDashStyle.Dash;
            //axisX.MinorGrid.IntervalOffset = 0;
            axisX.MinorGrid.Interval = 0.25;
            
        }
        public void ScrollBarInit(ChartArea chartArea)
        {
            chartArea.AxisX.ScaleView.Size = scrollSize;
            chartArea.CursorX.AutoScroll = true;
            chartArea.AxisX.ScrollBar.Enabled = false;
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 5;
            chartArea.AxisX.LabelStyle.Format = "#";
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chartArea.AxisX.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Seconds;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScaleView.Position = 0;
           
        }
        public void ScrollBarInitAll()
        {
            ScrollBarInit(ChartBreath.ChartAreas[Breath]);
            ScrollBarInit(ChartRPM.ChartAreas[RPM]);
            ScrollBarInit(ChartPressure.ChartAreas[Pressure]);
        }
        public void AxisXIntervalSetAll()
        {
            AxisXIntervalSet(ChartBreath.ChartAreas[Breath].AxisX);
            AxisXIntervalSet(ChartRPM.ChartAreas[RPM].AxisX);
            AxisXIntervalSet(ChartPressure.ChartAreas[Pressure].AxisX);
        }
        public void AddPoints(RealPacket packet, double ftime)
        {
            ChartBreath.Series[Breath].Points.AddXY(ftime, packet.breath);
            ChartRPM.Series[RRPM].Points.AddXY(ftime, packet.RRPM);
            ChartRPM.Series[LRPM].Points.AddXY(ftime, packet.LRPM);
            ChartPressure.Series[Pressure].Points.AddXY(ftime, packet.pressure);
        }
        public void InitializeGraph()
        {
            ScrollBarInitAll();
            AxisXIntervalSetAll();
        }
        public void ScrollBarShow(ChartArea chartArea)
        {
            //chartArea.AxisX.ScrollBar.Size = scrollSize;
            chartArea.AxisX.RoundAxisValues();
            chartArea.AxisX.ScrollBar.Enabled = true;
            chartArea.CursorX.AutoScroll = true;
            chartArea.AxisX.Minimum = 0;
            //chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
        }
        public void PauseGraph()
        {
            //ChartBreath.Series[0].Points.AddY(0);
            //ChartBreath.Series[0].Points[ChartBreath.Series[0].Points.Count - 1].IsEmpty = true;
            ScrollBarShow(ChartBreath.ChartAreas[Breath]);
            ScrollBarShow(ChartRPM.ChartAreas[RPM]);
            ScrollBarShow(ChartPressure.ChartAreas[Pressure]);
        }
        public void ResetGraph()
        {
            ChartBreath.Series["Breath"].Points.Clear();
            ChartRPM.Series["RRPM"].Points.Clear();
            ChartRPM.Series["LRPM"].Points.Clear();
            ChartPressure.Series["Pressure"].Points.Clear();

            InitializeGraph();
        }
        public void DrawGraph(RealPacket packet, double ftime)
        {
            if (ftime >= 0 && ftime <= 1.1)
                ;
            AddPoints(packet, ftime);
            ScrollBarMoveAll(ftime);
        }
        #endregion
    }
}
