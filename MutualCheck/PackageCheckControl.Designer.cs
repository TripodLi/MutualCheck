namespace MutualCheck
{
    partial class PackageCheckControl
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
            this.Kp_Sn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pack_sn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.TextBox();
            this.packagestationno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "KP-SN";
            // 
            // Kp_Sn
            // 
            this.Kp_Sn.Location = new System.Drawing.Point(108, 12);
            this.Kp_Sn.Name = "Kp_Sn";
            this.Kp_Sn.Size = new System.Drawing.Size(115, 21);
            this.Kp_Sn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PACK-SN";
            // 
            // pack_sn
            // 
            this.pack_sn.Location = new System.Drawing.Point(282, 12);
            this.pack_sn.Name = "pack_sn";
            this.pack_sn.Size = new System.Drawing.Size(132, 21);
            this.pack_sn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "ERRORMSG";
            // 
            // errorMsg
            // 
            this.errorMsg.Location = new System.Drawing.Point(479, 12);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(137, 21);
            this.errorMsg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "RECORD";
            // 
            // record
            // 
            this.record.Location = new System.Drawing.Point(669, 12);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(115, 21);
            this.record.TabIndex = 7;
            // 
            // packagestationno
            // 
            this.packagestationno.AutoSize = true;
            this.packagestationno.Location = new System.Drawing.Point(20, 15);
            this.packagestationno.Name = "packagestationno";
            this.packagestationno.Size = new System.Drawing.Size(0, 12);
            this.packagestationno.TabIndex = 8;
            // 
            // PackageCheckControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.packagestationno);
            this.Controls.Add(this.record);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pack_sn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kp_Sn);
            this.Controls.Add(this.label1);
            this.Name = "PackageCheckControl";
            this.Size = new System.Drawing.Size(787, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Kp_Sn;
        public System.Windows.Forms.TextBox pack_sn;
        public System.Windows.Forms.TextBox errorMsg;
        public System.Windows.Forms.TextBox record;
        public System.Windows.Forms.Label packagestationno;
    }
}
