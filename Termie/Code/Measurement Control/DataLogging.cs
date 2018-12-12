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
            if (_bLogging)
                btnLogStart.Text = "Pause";
            else {
                btnLogStart.Text = "Start";
            }
        }
        private void btnLogStop_Click(object sender, EventArgs e)
        {
            Write_ExcelData();
        }

        private void btnLogPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog1 = new SaveFileDialog();

            fileDialog1.Title = "Save Log As";
            fileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            fileDialog1.FilterIndex = 1;
            fileDialog1.RestoreDirectory = true;

            if (fileDialog1.ShowDialog() == DialogResult.OK)
            {
                button5.Text = fileDialog1.FileName;
                Settings.Option.LogFilePath = fileDialog1.FileName;
                if (File.Exists(button5.Text))
                    File.Delete(button5.Text);
            }
            else
            {
                button5.Text = "";
            }
        }
        #endregion
    }
    public interface IDataLogging
    {
        void btnLogStart_Click(object sender, EventArgs e);
        void btnLogStop_Click(object sender, EventArgs e);
        void btnLogPath_Click(object sender, EventArgs e);
    }
}
