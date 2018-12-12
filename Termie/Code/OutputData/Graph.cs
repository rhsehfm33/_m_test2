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
            chartArea.AxisX.Maximum = Math.Ceiling(ftime);
            chartArea.AxisX.Minimum = chartArea.AxisX.Maximum - scrollSize;
            chartArea.AxisX.ScaleView.Position = chartArea.AxisX.Minimum;
            //chartArea.AxisX.IntervalOffset = 0;
            //chartArea.AxisX.
            //chartArea.AxisX.IntervalOffset = (int)Math.Ceiling(ftime) + 1;
            chartArea.AxisX.RoundAxisValues();
        }
        public void ScrollBarMoveAll(double ftime)
        {
         //   ChartBreath
            ScrollBarMove(ChartBreath.ChartAreas[Breath], ftime);
            ScrollBarMove(ChartRPM.ChartAreas[RPM], ftime);
            ScrollBarMove(ChartPressure.ChartAreas[Pressure], ftime);
        }
        public void ScrollBarInit(ChartArea chartArea)
        {
            chartArea.AxisX.ScaleView.Size = scrollSize;
            chartArea.AxisX.ScrollBar.Enabled = true;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chartArea.AxisX.LabelStyle.Format = "#";
            //chartArea.AxisX.LabelStyle.Format = "ss.000";
            //chartArea.CursorX.Interval = 1;
            //chartArea.AxisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Seconds;
            //chartArea.AxisX.ScaleView.SmallScrollSize = 30;
            //chartArea.AxisX.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Seconds;
            //chartArea.AxisX.ScaleView.SmallScrollMinSize = 1;
            chartArea.AxisX.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Seconds;
            chartArea.CursorX.AutoScroll = true;
        }
        public void ScrollBarInitAll()
        {
            ScrollBarInit(ChartBreath.ChartAreas[Breath]);
            ScrollBarInit(ChartRPM.ChartAreas[RPM]);
            ScrollBarInit(ChartPressure.ChartAreas[Pressure]);
        }
        
        public void AddPoints(RealPacket packet, double ftime)
        {
            ChartBreath.Series[Breath].Points.AddXY(ftime, packet.breath);
            ChartRPM.Series[RRPM].Points.AddXY(ftime, packet.RRPM);
            ChartRPM.Series[LRPM].Points.AddXY(ftime, packet.LRPM);
            ChartPressure.Series[Pressure].Points.AddXY(ftime, packet.pressure);

            //ChartBreath.Series[0].Points.AddXY(Math.Truncate( ftime*10)/10, 0);
            //ChartBreath.Series[0].Points[ChartBreath.Series[0].Points.Count - 1].IsEmpty = true;
        }
        public void InitializeGraph()
        {
            ScrollBarInitAll();
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
            AddPoints(packet, ftime);
            ScrollBarMoveAll(ftime);
        }
        #endregion
    }
}
