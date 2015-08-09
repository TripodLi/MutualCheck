namespace MutualCheck
{
    partial class S_BoxCheckControl
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
            this.kp_sn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.packsn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.TextBox();
            this.sboxstationno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "KP-SN";
            // 
            // kp_sn
            // 
            this.kp_sn.Location = new System.Drawing.Point(125, 7);
            this.kp_sn.Name = "kp_sn";
            this.kp_sn.Size = new System.Drawing.Size(119, 21);
            this.kp_sn.TabIndex = 1;
            this.kp_sn.TextChanged += new System.EventHandler(this.kp_sn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PACKSN";
            // 
            // packsn
            // 
            this.packsn.Location = new System.Drawing.Point(297, 7);
            this.packsn.Name = "packsn";
            this.packsn.Size = new System.Drawing.Size(141, 21);
            this.packsn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "ERRORMSG";
            // 
            // errorMsg
            // 
            this.errorMsg.Location = new System.Drawing.Point(503, 7);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(143, 21);
            this.errorMsg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "RECORD";
            // 
            // record
            // 
            this.record.Location = new System.Drawing.Point(699, 7);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(95, 21);
            this.record.TabIndex = 7;
            // 
            // sboxstationno
            // 
            this.sboxstationno.AutoSize = true;
            this.sboxstationno.Location = new System.Drawing.Point(28, 10);
            this.sboxstationno.Name = "sboxstationno";
            this.sboxstationno.Size = new System.Drawing.Size(0, 12);
            this.sboxstationno.TabIndex = 8;
            // 
            // S_BoxCheckControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sboxstationno);
            this.Controls.Add(this.record);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.packsn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kp_sn);
            this.Controls.Add(this.label1);
            this.Name = "S_BoxCheckControl";
            this.Size = new System.Drawing.Size(814, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox packsn;
        public System.Windows.Forms.TextBox kp_sn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox record;
        public System.Windows.Forms.TextBox errorMsg;
        public System.Windows.Forms.Label sboxstationno;
    }
}
