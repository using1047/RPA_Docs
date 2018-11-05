using RPA_Docs.Function.IssueTrackingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace RPA_Docs.View
{
    public partial class RPADocs : Form
    {
        WBS_Top wt = new WBS_Top();
        WBS_Bottom wb = new WBS_Bottom();
        bool ExistExcel = false;
        bool ExistTemp = false;

        public RPADocs()
        {
            InitializeComponent();

            wt.getData += Wt_getData;
        }

        private void Wt_getData(wbsData data)
        {
            wb.SetData(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SPC.Panel1.Controls.Add(wt);
            SPC.Panel2.Controls.Add(wb);
        }

        private void RPADocs_FormClosing(object sender, FormClosingEventArgs e)
        {
            string OldExcelPath = "./Data.xlsx", NewExcelPath = "./Data.xlsx";
            int row = wb.dgv_WBS.Rows.Count, column = wb.dgv_WBS.ColumnCount;
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;
            try
            {
                // Excel 그 자체
                excelApp = new Excel.Application();
                // Excel 파일 열기
                workbook = excelApp.Workbooks.Open(OldExcelPath);
                // Excel 첫번째 시트
                worksheet = workbook.Worksheets.Item[1] as Excel.Worksheet;
                // Excel Sheet 저장할 범위 ex) worksheet.Range["B2", "G8"]
                Excel.Range rng = worksheet.Range[worksheet.Range[worksheet.Cells[1, 1]], worksheet.Cells[row, column]];

                // 저장 데이터
                object[,] data = new object[row, column];

                for (int r = 0; r < row; r++)
                {
                    for (int c = 0; c < column; c++)
                    {
                        data[r, c] = wb.dgv_WBS.Rows[r].Cells[c].FormattedValue.ToString();
                    }
                }

                rng.Value = data;

                if (NewExcelPath != null) workbook.SaveCopyAs(NewExcelPath);
                else workbook.Save();
                workbook.Close();
                excelApp.Quit();
            }
            catch(COMException)
            {
                MessageBox.Show("Excel이 설치되지 않은 컴퓨터에서는 작동되지 않습니다.\n임시 데이터(\'.txt\'형식)로 저장합니다.");

                string temp = "";
                string Classify = "";
                using (StreamWriter outputFile = new StreamWriter("./TempData.txt"))
                {
                    for (int r = 0; r < row - 1; r++)
                    {
                        temp = "";
                        for (int c = 0; c < column; c++)
                        {
                            // 1. 분류 , 2. 업무명, 3. 시작 날짜, 4. 종료예정날짜, 5. 중요도
                            switch(c)
                            {
                                case 0:
                                    if (wb.dgv_WBS.Rows[r].Cells[c].FormattedValue.ToString() == "") temp += Classify;
                                    else
                                    {
                                        temp += wb.dgv_WBS.Rows[r].Cells[c].FormattedValue.ToString() + ",";
                                        Classify = temp;
                                    }
                                    break;

                                case 1:
                                    temp += wb.dgv_WBS.Rows[r].Cells[c].FormattedValue.ToString() + ",";
                                    break;

                                case 2:
                                    temp += wb.dgv_WBS.Rows[r].Cells[c].FormattedValue.ToString() + ",";
                                    break;

                                case 3:
                                    temp += wb.dgv_WBS.Rows[r].Cells[c].FormattedValue.ToString() + ",";
                                    break;
                                case 4:
                                    temp += wb.dgv_WBS.Rows[r].Cells[c].Style.BackColor.Name + "\r\n";
                                    break;
                            }
                        }
                        outputFile.Write(temp);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // 해제 시켜주지 않으면 계속 켜져 있으므로 조심
                ReleaseExcelObject(worksheet);
                ReleaseExcelObject(workbook);
                ReleaseExcelObject(excelApp);
            }
        }

        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if(obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch(Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void RPADocs_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo("./");
            FileInfo[] info = di.GetFiles();

            for (int i = 0; i < info.Count(); i++)
            {
                if (info[i].ToString() == "Data.xlsx")
                {
                    MessageBox.Show("Data.xlsx 파일이 있군요.");
                    ExistExcel = true;
                }
                else if (info[i].ToString() == "TempData.txt")
                {
                    MessageBox.Show("TempData.txt 파일이 있군요.");
                    ExistTemp = true;
                }
            }

            if(ExistExcel == true && ExistTemp == true)
            {

            }
            else if(ExistTemp == true)
            {
                string[] lines = File.ReadAllLines("./TempData.txt");
                wbsData wd = new wbsData();


                for (int r = 0; r < lines.Length; r++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        switch(c)
                        {
                            case 0:
                                wd.Classify = lines[r].Split(',').ElementAt(0);
                                break;

                            case 1:
                                wd.Todo = lines[r].Split(',').ElementAt(1);
                                break;

                            case 2:
                                wd.startDate = lines[r].Split(',').ElementAt(2);
                                break;

                            case 3:
                                wd.endDate = lines[r].Split(',').ElementAt(3);
                                break;

                            case 4:
                                if (lines[r].Split(',').ElementAt(4).ToString() == "Red")
                                    wd.Importance = Color.Red;
                                else if (lines[r].Split(',').ElementAt(4).ToString() == "Green")
                                    wd.Importance = Color.Green;
                                else if (lines[r].Split(',').ElementAt(4).ToString() == "Blue")
                                    wd.Importance = Color.Blue;
                                break;
                        }
                        wd.userName = "김미나";
                    }
                    wb.SetData(wd);
                }
            }
        }
    }
}
