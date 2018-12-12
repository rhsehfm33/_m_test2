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

        #region Event handling - data received and status changed


        // delegate used for Invoke
        internal delegate void StringDelegate(string data);
        internal delegate void PacketDelegate(RealPacket data);

        // shutdown the worker thread when the form closes
        protected override void OnClosed(EventArgs e)
        {
            CommPort com = CommPort.Instance;
            com.Close();

            Settings.Write();

            base.OnClosed(e);
        }

        /// <summary>
        /// Update the connection status
        /// </summary>
        public void OnStatusChanged(string status)
        {
            //Handle multi-threading
            if (InvokeRequired)
            {
                Invoke(new StringDelegate(OnStatusChanged), new object[] { status });
                return;
            }

            textBox1.Text = status;
        }

        /// <summary>
        /// Handle data received event from serial port.
        /// </summary>
        /// <param name="data">incoming data</param>
        /// 
        public void OnDataReceived(RealPacket packet)
        {
            double ftime = _stopWatch.Elapsed.TotalSeconds;
            ftime = Math.Truncate(ftime * 100) / 100;
            //Handle multi-threading
            if (InvokeRequired)
            {
                Invoke(new PacketDelegate(OnDataReceived), new object[] { packet });
                return;
            }

            if (StartButton.Text == "Start")
            {
                return;
            }
            DrawGraph(packet,ftime);
            if (_bLogging)
            {
                DrawGrid(packet, ftime);
            }
        }
        #endregion
    }
}
