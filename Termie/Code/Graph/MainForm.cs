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
        #region Graph
        public const int scrollSize = 10;
        public void ScrollBarMove(ChartArea chartArea, float ftime)
        {
            chartArea.AxisX.ScaleView.Position = chartArea.AxisX.Maximum - scrollSize;
            chartArea.AxisX.Maximum = Math.Ceiling(ftime);
            chartArea.AxisX.Minimum = chartArea.AxisX.Maximum - scrollSize;
        }
        public void ScrollBarMoveAll(float ftime)
        {
            ScrollBarMove(ChartBreath.ChartAreas["ChartAreaBreath"], ftime);
            ScrollBarMove(ChartRPM.ChartAreas["ChartAreaRPM"], ftime);
            ScrollBarMove(ChartPressure.ChartAreas["ChartAreaPressure"], ftime);
        }
        public void ScrollBarInit(ChartArea chartArea)
        {
            chartArea.AxisX.ScaleView.Size = scrollSize;
            chartArea.AxisX.ScrollBar.Enabled = true;
            //chartArea.AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Seconds;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum= 10;
            chartArea.CursorX.AutoScroll = true;
        }
        public void ScrollBarInitAll()
        {
            ScrollBarInit(ChartBreath.ChartAreas["ChartAreaBreath"]);
            ScrollBarInit(ChartRPM.ChartAreas["ChartAreaRPM"]);
            ScrollBarInit(ChartPressure.ChartAreas["ChartAreaPressure"]);
        }
        
        public void AddPoints(RealPacket packet, float ftime)
        {
            ChartBreath.Series["Breath"].Points.AddXY(ftime, packet.breath);
            ChartRPM.Series["RRPM"].Points.AddXY(ftime, packet.RRPM);
            ChartRPM.Series["LRPM"].Points.AddXY(ftime, packet.LRPM);
            ChartPressure.Series["Pressure"].Points.AddXY(ftime, packet.pressure);
        }
        public void InitializeGraph()
        {
            ScrollBarInitAll();
        }
        public void DrawGraph(RealPacket packet, float ftime)
        {
            AddPoints(packet, ftime);
            ScrollBarMoveAll(ftime);
        }
        public void ResetGraph()
        {
            ChartBreath.Series["Breath"].Points.Clear();
            ChartRPM.Series["RRPM"].Points.Clear();
            ChartRPM.Series["LRPM"].Points.Clear();
            ChartPressure.Series["Pressure"].Points.Clear();
        }
        #endregion
    }
}
