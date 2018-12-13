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
        private void DrawGrid()
        {
            for(int i = dataGridView.RowCount; i < ChartBreath.Series[Breath].Points.Count; ++i)
            {
                var time = ChartBreath.Series["Breath"].Points[i].XValue;
                var breath = ChartBreath.Series["Breath"].Points[i].YValues[0];
                var rrpm = ChartRPM.Series["RRPM"].Points[i].YValues[0];
                var lrpm = ChartRPM.Series["LRPM"].Points[i].YValues[0];
                var pressure = ChartPressure.Series["Pressure"].Points[i].YValues[0];
                dataGridView.Rows.Add(time, breath, pressure, lrpm, rrpm);
                dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.RowCount - 1;
            }
        }
        private void ResetGrid()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
        }
    }
}
