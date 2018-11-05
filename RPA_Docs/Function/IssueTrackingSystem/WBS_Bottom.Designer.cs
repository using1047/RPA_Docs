namespace RPA_Docs.Function.IssueTrackingSystem
{
    partial class WBS_Bottom
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_WBS = new System.Windows.Forms.DataGridView();
            this.col_Classify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Importance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WBS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_WBS
            // 
            this.dgv_WBS.BackgroundColor = System.Drawing.Color.White;
            this.dgv_WBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_WBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Classify,
            this.col_Todo,
            this.col_startDate,
            this.col_endDate,
            this.col_Importance,
            this.col_Status});
            this.dgv_WBS.Location = new System.Drawing.Point(3, -3);
            this.dgv_WBS.Name = "dgv_WBS";
            this.dgv_WBS.RowTemplate.Height = 23;
            this.dgv_WBS.Size = new System.Drawing.Size(654, 614);
            this.dgv_WBS.TabIndex = 0;
            this.dgv_WBS.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_WBS_CellMouseClick);
            // 
            // col_Classify
            // 
            this.col_Classify.HeaderText = "분류";
            this.col_Classify.Name = "col_Classify";
            // 
            // col_Todo
            // 
            this.col_Todo.HeaderText = "업무명";
            this.col_Todo.Name = "col_Todo";
            // 
            // col_startDate
            // 
            this.col_startDate.HeaderText = "시작일";
            this.col_startDate.Name = "col_startDate";
            this.col_startDate.Width = 140;
            // 
            // col_endDate
            // 
            this.col_endDate.HeaderText = "종료일";
            this.col_endDate.Name = "col_endDate";
            this.col_endDate.Width = 140;
            // 
            // col_Importance
            // 
            this.col_Importance.HeaderText = "중요도";
            this.col_Importance.Name = "col_Importance";
            this.col_Importance.Width = 65;
            // 
            // col_Status
            // 
            this.col_Status.HeaderText = "진행도";
            this.col_Status.Name = "col_Status";
            this.col_Status.Width = 65;
            // 
            // WBS_Bottom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_WBS);
            this.Name = "WBS_Bottom";
            this.Size = new System.Drawing.Size(1074, 614);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_WBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Classify;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Importance;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Status;
    }
}
