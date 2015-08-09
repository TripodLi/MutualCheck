namespace MutualCheck
{
    partial class MudleOkOrNot
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
            this.mudleErrormsg = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.mudleOkOrNotRecord = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.okOrNot = new System.Windows.Forms.TextBox();
            this.mudleNumber = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.stationNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mudleErrormsg
            // 
            this.mudleErrormsg.Location = new System.Drawing.Point(560, 4);
            this.mudleErrormsg.Name = "mudleErrormsg";
            this.mudleErrormsg.Size = new System.Drawing.Size(100, 21);
            this.mudleErrormsg.TabIndex = 15;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(487, 7);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(65, 12);
            this.label35.TabIndex = 14;
            this.label35.Text = "错误信息：";
            // 
            // mudleOkOrNotRecord
            // 
            this.mudleOkOrNotRecord.Location = new System.Drawing.Point(719, 4);
            this.mudleOkOrNotRecord.Name = "mudleOkOrNotRecord";
            this.mudleOkOrNotRecord.Size = new System.Drawing.Size(75, 21);
            this.mudleOkOrNotRecord.TabIndex = 13;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(672, 7);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 12);
            this.label34.TabIndex = 12;
            this.label34.Text = "信号：";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(293, 7);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(65, 12);
            this.label33.TabIndex = 11;
            this.label33.Text = "是否可用：";
            // 
            // okOrNot
            // 
            this.okOrNot.Location = new System.Drawing.Point(367, 4);
            this.okOrNot.Name = "okOrNot";
            this.okOrNot.Size = new System.Drawing.Size(96, 21);
            this.okOrNot.TabIndex = 10;
            // 
            // mudleNumber
            // 
            this.mudleNumber.Location = new System.Drawing.Point(141, 4);
            this.mudleNumber.Name = "mudleNumber";
            this.mudleNumber.Size = new System.Drawing.Size(120, 21);
            this.mudleNumber.TabIndex = 9;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(80, 7);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 12);
            this.label32.TabIndex = 8;
            this.label32.Text = "模组号：";
            // 
            // stationNo
            // 
            this.stationNo.AutoSize = true;
            this.stationNo.Location = new System.Drawing.Point(19, 7);
            this.stationNo.Name = "stationNo";
            this.stationNo.Size = new System.Drawing.Size(41, 12);
            this.stationNo.TabIndex = 16;
            this.stationNo.Text = "label1";
            // 
            // MudleOkOrNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stationNo);
            this.Controls.Add(this.mudleErrormsg);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.mudleOkOrNotRecord);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.okOrNot);
            this.Controls.Add(this.mudleNumber);
            this.Controls.Add(this.label32);
            this.Name = "MudleOkOrNot";
            this.Size = new System.Drawing.Size(797, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox mudleErrormsg;
        private System.Windows.Forms.Label label35;
        public System.Windows.Forms.TextBox mudleOkOrNotRecord;
        private System.Windows.Forms.Label label34;
        public System.Windows.Forms.Label label33;
        public System.Windows.Forms.TextBox okOrNot;
        public System.Windows.Forms.TextBox mudleNumber;
        private System.Windows.Forms.Label label32;
        public System.Windows.Forms.Label stationNo;
    }
}
