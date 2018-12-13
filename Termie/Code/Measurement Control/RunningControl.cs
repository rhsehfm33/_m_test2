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
        #region button
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!CommPort.bRunning)
            {
                InitializeGraph();
                StartButton.Text = "Pause";
                CommPort.bRunning = true;
                _stopWatch.Start();
            }
            else
            {
                StartButton.Text = "Start";
                PauseGraph();
                CommPort.bRunning = false;
                _stopWatch.Stop();
            }

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _stopWatch.Restart();
            if(!CommPort.bRunning)
                _stopWatch.Stop();
            ResetGraph();
            ResetGrid();
        }
        #endregion
    }
}
