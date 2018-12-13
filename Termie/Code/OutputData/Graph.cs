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
        #region Constant Variable
        public const int scrollSize = 5;

        #region Index Constant
        public const string Breath = "Breath";
        public const string RPM = "RPM";
        public const string Pressure = "Pressure";
        public const string LRPM = "LRPM";
        public const string RRPM = "RRPM";
        #endregion

        #endregion
        #region Graph
        #region ScrollBar Movement
        public void ScrollBarMove(ChartArea chartArea, double ftime)
        {
            if (ftime < scrollSize)
                return;
            chartArea.AxisX.Maximum = ftime;
            chartArea.AxisX.ScaleView.Position = ftime- scrollSize;
            chartArea.AxisX.RoundAxisValues();

            //chartArea.AxisX.RoundAxisValues();
        }
        public void ScrollBarMoveAll(double ftime)
        {
            ScrollBarMove(ChartBreath.ChartAreas[Breath], ftime);
            ScrollBarMove(ChartRPM.ChartAreas[RPM], ftime);
            ScrollBarMove(ChartPressure.ChartAreas[Pressure], ftime);
        }
        #endregion
        #region Set Axisx Interval
        public void AxisXIntervalSet(Axis axisX)
        {
            axisX.Minimum = 0;
            axisX.Maximum = 5;

            axisX.Interval = 1;
            axisX.IntervalAutoMode = IntervalAutoMode.FixedCount;

            axisX.MajorGrid.Enabled = true;
            axisX.MajorGrid.LineColor = Color.DimGray;
            axisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;

            axisX.MinorGrid.Enabled = true;
            axisX.MinorGrid.LineColor = Color.Gray;
            axisX.MinorGrid.LineDashStyle = ChartDashStyle.Dash;
            axisX.MinorGrid.Interval = 0.25;
        }
        public void AxisXIntervalSetAll()
        {
            AxisXIntervalSet(ChartBreath.ChartAreas[Breath].AxisX);
            AxisXIntervalSet(ChartRPM.ChartAreas[RPM].AxisX);
            AxisXIntervalSet(ChartPressure.ChartAreas[Pressure].AxisX);
        }
        #endregion
        #region Set AxisX Scale
        public void AxisXScaleSet(Axis axis)
        {
            axis.ScaleView.Size = scrollSize;
            axis.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Seconds;
            axis.ScaleView.Zoomable = true;
            axis.ScaleView.Position = 0;

        }
        public void AxisXScaleSetAll()
        {
            AxisXScaleSet(ChartBreath.ChartAreas[Breath].AxisX);
            AxisXScaleSet(ChartPressure.ChartAreas[Pressure].AxisX);
            AxisXScaleSet(ChartRPM.ChartAreas[RPM].AxisX);
        }
        #endregion
        #region ScrollBar Initialize
        public void ScrollBarInit(ChartArea chartArea)
        {
            chartArea.CursorX.AutoScroll = true;
            chartArea.AxisX.ScrollBar.Enabled = false;
            chartArea.AxisX.LabelStyle.Format = "#";
        }
        public void ScrollBarInitAll()
        {
            ScrollBarInit(ChartBreath.ChartAreas[Breath]);
            ScrollBarInit(ChartRPM.ChartAreas[RPM]);
            ScrollBarInit(ChartPressure.ChartAreas[Pressure]);
        }
        #endregion
        #region add Value
        public void AddPoints(RealPacket packet, double ftime)
        {
            ChartBreath.Series[Breath].Points.AddXY(ftime, packet.breath);
            ChartRPM.Series[RRPM].Points.AddXY(ftime, packet.RRPM);
            ChartRPM.Series[LRPM].Points.AddXY(ftime, packet.LRPM);
            ChartPressure.Series[Pressure].Points.AddXY(ftime, packet.pressure);
        }
        #endregion
        #region Show Scrollbar
        public void ScrollBarShow(ChartArea chartArea)
        {
            chartArea.AxisX.RoundAxisValues();
            chartArea.AxisX.ScrollBar.Enabled = true;
            chartArea.CursorX.AutoScroll = true;
            chartArea.AxisX.Minimum = 0;
        }
        #endregion
        #region Graph Main functions
        public void PauseGraph()
        {
            ScrollBarShow(ChartBreath.ChartAreas[Breath]);
            ScrollBarShow(ChartRPM.ChartAreas[RPM]);
            ScrollBarShow(ChartPressure.ChartAreas[Pressure]);
        }

        public void InitializeGraph()
        {
            ScrollBarInitAll();
            AxisXIntervalSetAll();
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
        #endregion
    }
}
