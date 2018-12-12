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
        #region Excel
        public void Write_ExcelData()
        {
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;
            object missing = System.Reflection.Missing.Value;

            try
            {
                int r = 1, c = 1;
                // Excel 첫번째 워크시트 마지막 번째 가져오기. lms 추가함.
                excelApp = new Excel.Application();
                wb = excelApp.Workbooks.Add(missing);
                ws = wb.Worksheets.get_Item(1) as Excel.Worksheet;


                for (; c <= dataGridView.ColumnCount; c++)
                {
                    ws.Cells[r, c] = dataGridView.Columns[c - 1].HeaderText;
                }
                for (r = 2; r <= dataGridView.Rows.Count + 1; r++)
                {
                    for (c = 1; c <= dataGridView.ColumnCount; c++)
                    {
                        ws.Cells[r, c] = dataGridView.Rows[r - 2].Cells[c - 1].Value;
                    }
                }
                wb.SaveAs(Settings.Option.LogFilePath);
                wb.Close(true);
                excelApp.Quit();
            }
            finally
            {
                // Clean up
                ReleaseExcelObject(ws);
                ReleaseExcelObject(wb);
                ReleaseExcelObject(excelApp);
            }
        }
        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion
    }
}
