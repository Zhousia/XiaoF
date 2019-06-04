namespace test01
{
    partial class PDFReader
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFile = new DevExpress.XtraEditors.TextEdit();
            this.txtStart = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtResult = new DevExpress.Tutorials.Controls.RichTextBoxEx();
            this.txtEnd = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.btnSelectText = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnGetText = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(87, 33);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(100, 20);
            this.txtFile.TabIndex = 0;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(87, 93);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 20);
            this.txtStart.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "PDF File";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(202, 36);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(28, 17);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(87, 183);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(347, 206);
            this.txtResult.TabIndex = 6;
            this.txtResult.Text = "";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(247, 93);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 20);
            this.txtEnd.TabIndex = 7;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(87, 147);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(100, 20);
            this.textEdit4.TabIndex = 8;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(247, 147);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(100, 20);
            this.textEdit5.TabIndex = 9;
            // 
            // btnSelectText
            // 
            this.btnSelectText.Location = new System.Drawing.Point(353, 96);
            this.btnSelectText.Name = "btnSelectText";
            this.btnSelectText.Size = new System.Drawing.Size(81, 23);
            this.btnSelectText.TabIndex = 10;
            this.btnSelectText.Text = "文本筛选";
            this.btnSelectText.Click += new System.EventHandler(this.btnSelectText_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "文本之间";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 150);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "行首";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(206, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "行尾";
            // 
            // btnGetText
            // 
            this.btnGetText.Location = new System.Drawing.Point(247, 30);
            this.btnGetText.Name = "btnGetText";
            this.btnGetText.Size = new System.Drawing.Size(81, 23);
            this.btnGetText.TabIndex = 14;
            this.btnGetText.Text = "提取文本";
            this.btnGetText.Click += new System.EventHandler(this.btnGetText_Click);
            // 
            // PDFReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 401);
            this.Controls.Add(this.btnGetText);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnSelectText);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtFile);
            this.Name = "PDFReader";
            this.Text = "PDF读取";
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtFile;
        private DevExpress.XtraEditors.TextEdit txtStart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Tutorials.Controls.RichTextBoxEx txtResult;
        private DevExpress.XtraEditors.TextEdit txtEnd;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.SimpleButton btnSelectText;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnGetText;
    }
}

