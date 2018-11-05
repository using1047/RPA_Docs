using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPA_Docs.Function.IssueTrackingSystem
{
    public partial class WBS_Bottom : UserControl
    {
        public WBS_Bottom()
        {
            InitializeComponent();
            dgv_WBS.AutoGenerateColumns = false;
        }

        public void SetData(wbsData data)
        {
            int rowId = dgv_WBS.Rows.Add();

            DataGridViewRow row = dgv_WBS.Rows[rowId];

            row.Cells["col_Classify"].Value = data.Classify;
            row.Cells["col_Todo"].Value = data.Todo;
            row.Cells["col_startDate"].Value = data.startDate;
            row.Cells["col_endDate"].Value = data.endDate;
            row.Cells["col_Importance"].Style.BackColor = data.Importance;

            dgv_WBS.CellPainting += dgv_WBS_CellPainting;
            dgv_WBS.CellFormatting += Dgv_WBS_CellFormatting;
            dgv_WBS.Sort(dgv_WBS.Columns["col_Classify"], ListSortDirection.Ascending);
            dgv_WBS.Sort(dgv_WBS.Columns["col_startDate"], ListSortDirection.Ascending);
            dgv_WBS.Sort(dgv_WBS.Columns["col_endDate"], ListSortDirection.Ascending);
        }

        /// <summary>
        /// Cell 포멧 형식 지정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dgv_WBS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 첫번째줄은 Skip
            if (e.RowIndex == 0)
                return;
            //같은 값인지 확인
            if (IsTheSameCellValue(e.RowIndex) && e.ColumnIndex == 0)
            {
                // 빈칸으로 만들어준다.
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        bool IsTheSameCellValue(int row)
        {
            DataGridViewCell cell1 = dgv_WBS[0, row];
            DataGridViewCell cell2 = dgv_WBS[0, row - 1];
            if(cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void dgv_WBS_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if(IsTheSameCellValue(e.RowIndex) && e.ColumnIndex == 0)
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dgv_WBS.AdvancedCellBorderStyle.Top;
            }

            
        }
    }
}
