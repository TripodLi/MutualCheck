namespace MutualCheck
{
    partial class GetSnControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Pack_Sn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Error_Msg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Record = new System.Windows.Forms.TextBox();
            this.kpstationno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "KP-SN";
            // 
            // Pack_Sn
            // 
            this.Pack_Sn.Location = new System.Drawing.Point(111, 4);
            this.Pack_Sn.Name = "Pack_Sn";
            this.Pack_Sn.Size = new System.Drawing.Size(149, 21);
            this.Pack_Sn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PN";
            // 
            // PN
            // 
            this.PN.Location = new System.Drawing.Point(289, 5);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(163, 21);
            this.PN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "ERROR-MSG";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Error_Msg
            // 
            this.Error_Msg.Location = new System.Drawing.Point(523, 5);
            this.Error_Msg.Name = "Error_Msg";
            this.Error_Msg.Size = new System.Drawing.Size(152, 21);
            this.Error_Msg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "RECORD";
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(728, 4);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(58, 21);
            this.Record.TabIndex = 7;
            // 
            // kpstationno
            // 
            this.kpstationno.AutoSize = true;
            this.kpstationno.Location = new System.Drawing.Point(3, 7);
            this.kpstationno.Name = "kpstationno";
            this.kpstationno.Size = new System.Drawing.Size(0, 12);
            this.kpstationno.TabIndex = 8;
            // 
            // GetSnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kpstationno);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Error_Msg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pack_Sn);
            this.Controls.Add(this.label1);
            this.Name = "GetSnControl";
            this.Size = new System.Drawing.Size(797, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Pack_Sn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox PN;
        public System.Windows.Forms.TextBox Error_Msg;
        public System.Windows.Forms.TextBox Record;
        public System.Windows.Forms.Label kpstationno;

    }
}
