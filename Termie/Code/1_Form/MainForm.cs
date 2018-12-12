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

            InitializeComponent();
            _bLogging = false;
            Settings.Read();
            TopMost = Settings.Option.StayOnTop;

            CommPort com = CommPort.Instance;
            com.StatusChanged += OnStatusChanged;
            com.DataReceived += OnDataReceived;
            com.Open();

            InitializeGraph();

            _stopWatch = new Stopwatch();
        }
    }
}