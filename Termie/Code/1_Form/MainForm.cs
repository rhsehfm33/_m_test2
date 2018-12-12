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

namespace Termie
{
    public partial class MainForm : Form
    {
        public Stopwatch _stopWatch;
        bool _bLogging;
        
        public MainForm()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            Settings.Read();
            InitializeComponent();
            _bLogging = false;
            TopMost = Settings.Option.StayOnTop;

            CommPort com = CommPort.Instance;
            com.StatusChanged += OnStatusChanged;
            com.DataReceived += OnDataReceived;
            com.Open();

            InitializeGraph();

            _stopWatch = new Stopwatch();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog1 = new SaveFileDialog();

            fileDialog1.Title = "Save Log As";
            fileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            fileDialog1.FilterIndex = 1;
            fileDialog1.RestoreDirectory = true;
            fileDialog1.FileName = Settings.Option.LogFilePath;

            if (fileDialog1.ShowDialog() == DialogResult.OK)
            {
                LogPathBox.Text = fileDialog1.FileName;
                Settings.Option.LogFilePath = LogPathBox.Text;
                Settings.Option.LogFilePath = fileDialog1.FileName;
                
                if (File.Exists(LogPathBox.Text))
                    File.Delete(LogPathBox.Text);
                Settings.Write();
            }
        }

    }
}