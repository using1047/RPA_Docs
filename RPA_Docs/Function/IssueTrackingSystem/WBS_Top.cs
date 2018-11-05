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
    public partial class WBS_Top : UserControl
    {
        public delegate void GetData(wbsData data);
        public event GetData getData;
        int ImportanceColor = 0;

        public WBS_Top()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = true;

            if (User.Text == string.Empty) { MessageBox.Show("담당자 명을  입력해주세요."); b = false; }

            if (dtp_Start.Text == string.Empty) { MessageBox.Show("시작 날짜를 입력해주세요."); b = false; }

            if (dtp_End.Text == string.Empty) { MessageBox.Show("종료 날짜를 입력해주세요."); b = false; }

            if (txt_Process.Text == string.Empty) { MessageBox.Show("업무 명을 입력해주세요."); b = false; }

            if (dtp_Start.Value <= dtp_End.Value) { }else{ MessageBox.Show("종료일자를 시작일자와 같거나 이후로 설정해주세요."); b = false; }

            if (b == true) { wbsData data = SaveData(); this.getData(data); }
        }

        wbsData SaveData()
        {
            wbsData wbs = new wbsData();
            wbs.userName = User.Text;
            wbs.startDate = dtp_Start.Text;
            wbs.endDate = dtp_End.Text;
            wbs.Todo = txt_Process.Text;
            wbs.Classify = cb_Process.Text;
            wbs.Importance = pb_Importance.BackColor;
            wbs.State = "대기";
            return wbs;
        }

        enum WBSColor
        {
            red,
            blue,
            green
        }

        private void pb_Importance_Click(object sender, EventArgs e)
        {
            switch(ImportanceColor)
            {
                case (int)WBSColor.red:
                    ImportanceColor++;
                    pb_Importance.BackColor = Color.Blue;
                    break;
                case (int)WBSColor.blue: 
                    ImportanceColor++;
                    pb_Importance.BackColor = Color.Green;
                    break;
                case (int)WBSColor.green:
                    ImportanceColor = 0;
                    pb_Importance.BackColor = Color.Red;
                    break;
            }
        }

        private void dtp_Start_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_Start.Value <= dtp_End.Value) { }
            else MessageBox.Show("종료 일자가 시작 일자보다 먼저일수 없습니다.");
        }

        private void dtp_End_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_Start.Value <= dtp_End.Value) { }
            else MessageBox.Show("종료 일자가 시작 일자보다 먼저일수 없습니다.");
        }
    }
}
