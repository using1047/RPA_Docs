namespace RPA_Docs.View
{
    partial class RPADocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SPC = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPC)).BeginInit();
            this.SPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 754);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(24, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Issue";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(24, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "API";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SPC
            // 
            this.SPC.Dock = System.Windows.Forms.DockStyle.Top;
            this.SPC.Location = new System.Drawing.Point(275, 0);
            this.SPC.Name = "SPC";
            this.SPC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SPC.Panel1
            // 
            this.SPC.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.SPC.Size = new System.Drawing.Size(1074, 754);
            this.SPC.SplitterDistance = 140;
            this.SPC.SplitterWidth = 1;
            this.SPC.TabIndex = 1;
            // 
            // RPADocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 754);
            this.Controls.Add(this.SPC);
            this.Controls.Add(this.panel1);
            this.Name = "RPADocs";
            this.Text = "RPADocs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RPADocs_FormClosing);
            this.Load += new System.EventHandler(this.RPADocs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPC)).EndInit();
            this.SPC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer SPC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}