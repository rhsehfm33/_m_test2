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
        public void DrawGrid(RealPacket packet, double ftime)
        {
            dataGridView.Rows.Add(ftime, packet.breath, packet.pressure, packet.LRPM, packet.RRPM);
            dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.RowCount - 1;

        }
    }
}
