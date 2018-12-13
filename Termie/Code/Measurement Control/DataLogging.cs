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
using Termie;
namespace Termie
{
    public partial class MainForm 
    {
        #region button
        private void btnLogStart_Click(object sender, EventArgs e)
        {
            _bLogging = !_bLogging;
            if (_bLogging) {
                btnLogStart.Text = "Pause";
                DrawGrid();
            }
            else {
                btnLogStart.Text = "Start";
            }
        }
        private void btnLogStop_Click(object sender, EventArgs e)
        {
            Write_ExcelData();
        }

        
        #endregion
    }
}
