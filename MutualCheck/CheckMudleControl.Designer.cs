namespace MutualCheck
{
    partial class CheckMudleControl
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
            this.CheckPackSn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BarCodeNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Record = new System.Windows.Forms.TextBox();
            this.mudlestationno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHECKPACKSN";
            // 
            // CheckPackSn
            // 
            this.CheckPackSn.Location = new System.Drawing.Point(93, 10);
            this.CheckPackSn.Name = "CheckPackSn";
            this.CheckPackSn.Size = new System.Drawing.Size(113, 21);
            this.CheckPackSn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "RESULT";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(259, 10);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(120, 21);
            this.result.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "BARCODENO";
            // 
            // BarCodeNo
            // 
            this.BarCodeNo.Location = new System.Drawing.Point(450, 10);
            this.BarCodeNo.Name = "BarCodeNo";
            this.BarCodeNo.Size = new System.Drawing.Size(122, 21);
            this.BarCodeNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "RECORD";
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(625, 10);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(117, 21);
            this.Record.TabIndex = 7;
            // 
            // mudlestationno
            // 
            this.mudlestationno.AutoSize = true;
            this.mudlestationno.Location = new System.Drawing.Point(10, 13);
            this.mudlestationno.Name = "mudlestationno";
            this.mudlestationno.Size = new System.Drawing.Size(0, 12);
            this.mudlestationno.TabIndex = 8;
            // 
            // CheckMudleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mudlestationno);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BarCodeNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckPackSn);
            this.Controls.Add(this.label1);
            this.Name = "CheckMudleControl";
            this.Size = new System.Drawing.Size(758, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Record;
        public System.Windows.Forms.TextBox BarCodeNo;
        public System.Windows.Forms.TextBox CheckPackSn;
        public System.Windows.Forms.TextBox result;
        public System.Windows.Forms.Label mudlestationno;
    }
}
