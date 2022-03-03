namespace Ex7_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.w = new System.Windows.Forms.GroupBox();
            this.rdbH3 = new System.Windows.Forms.RadioButton();
            this.rdbH2 = new System.Windows.Forms.RadioButton();
            this.rdbH1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbD2 = new System.Windows.Forms.RadioButton();
            this.rdbD1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbV2 = new System.Windows.Forms.RadioButton();
            this.rdbV1 = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.w.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // w
            // 
            this.w.Controls.Add(this.rdbH3);
            this.w.Controls.Add(this.rdbH2);
            this.w.Controls.Add(this.rdbH1);
            this.w.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.w.Location = new System.Drawing.Point(32, 24);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(414, 85);
            this.w.TabIndex = 0;
            this.w.TabStop = false;
            this.w.Text = "住宿";
            // 
            // rdbH3
            // 
            this.rdbH3.AutoSize = true;
            this.rdbH3.Location = new System.Drawing.Point(289, 39);
            this.rdbH3.Name = "rdbH3";
            this.rdbH3.Size = new System.Drawing.Size(90, 24);
            this.rdbH3.TabIndex = 2;
            this.rdbH3.Text = "四人房";
            this.rdbH3.UseVisualStyleBackColor = true;
            this.rdbH3.CheckedChanged += new System.EventHandler(this.rdbH3_CheckedChanged);
            // 
            // rdbH2
            // 
            this.rdbH2.AutoSize = true;
            this.rdbH2.Location = new System.Drawing.Point(159, 39);
            this.rdbH2.Name = "rdbH2";
            this.rdbH2.Size = new System.Drawing.Size(90, 24);
            this.rdbH2.TabIndex = 1;
            this.rdbH2.Text = "三人房";
            this.rdbH2.UseVisualStyleBackColor = true;
            this.rdbH2.CheckedChanged += new System.EventHandler(this.rdbH2_CheckedChanged);
            // 
            // rdbH1
            // 
            this.rdbH1.AutoSize = true;
            this.rdbH1.Checked = true;
            this.rdbH1.Location = new System.Drawing.Point(37, 39);
            this.rdbH1.Name = "rdbH1";
            this.rdbH1.Size = new System.Drawing.Size(90, 24);
            this.rdbH1.TabIndex = 0;
            this.rdbH1.TabStop = true;
            this.rdbH1.Text = "雙人房";
            this.rdbH1.UseVisualStyleBackColor = true;
            this.rdbH1.CheckedChanged += new System.EventHandler(this.rdbH1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbD2);
            this.groupBox2.Controls.Add(this.rdbD1);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(32, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "時段";
            // 
            // rdbD2
            // 
            this.rdbD2.AutoSize = true;
            this.rdbD2.Location = new System.Drawing.Point(235, 42);
            this.rdbD2.Name = "rdbD2";
            this.rdbD2.Size = new System.Drawing.Size(90, 24);
            this.rdbD2.TabIndex = 1;
            this.rdbD2.Text = "非假日";
            this.rdbD2.UseVisualStyleBackColor = true;
            this.rdbD2.CheckedChanged += new System.EventHandler(this.rdbD2_CheckedChanged);
            // 
            // rdbD1
            // 
            this.rdbD1.AutoSize = true;
            this.rdbD1.Checked = true;
            this.rdbD1.Location = new System.Drawing.Point(89, 42);
            this.rdbD1.Name = "rdbD1";
            this.rdbD1.Size = new System.Drawing.Size(70, 24);
            this.rdbD1.TabIndex = 0;
            this.rdbD1.TabStop = true;
            this.rdbD1.Text = "假日";
            this.rdbD1.UseVisualStyleBackColor = true;
            this.rdbD1.CheckedChanged += new System.EventHandler(this.rdbD1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "假日：週五、週六、國定假日前一晚";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbV2);
            this.groupBox3.Controls.Add(this.rdbV1);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(32, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 74);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "身分";
            // 
            // rdbV2
            // 
            this.rdbV2.AutoSize = true;
            this.rdbV2.Location = new System.Drawing.Point(200, 30);
            this.rdbV2.Name = "rdbV2";
            this.rdbV2.Size = new System.Drawing.Size(90, 24);
            this.rdbV2.TabIndex = 1;
            this.rdbV2.Text = "非會員";
            this.rdbV2.UseVisualStyleBackColor = true;
            this.rdbV2.CheckedChanged += new System.EventHandler(this.rdbV2_CheckedChanged);
            // 
            // rdbV1
            // 
            this.rdbV1.AutoSize = true;
            this.rdbV1.Checked = true;
            this.rdbV1.Location = new System.Drawing.Point(72, 30);
            this.rdbV1.Name = "rdbV1";
            this.rdbV1.Size = new System.Drawing.Size(70, 24);
            this.rdbV1.TabIndex = 0;
            this.rdbV1.TabStop = true;
            this.rdbV1.Text = "會員";
            this.rdbV1.UseVisualStyleBackColor = true;
            this.rdbV1.CheckedChanged += new System.EventHandler(this.rdbV1_CheckedChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(29, 401);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 23);
            this.lblPrice.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 465);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.w);
            this.Name = "Form1";
            this.Text = "松崗渡假村房價試算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.w.ResumeLayout(false);
            this.w.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox w;
        private System.Windows.Forms.RadioButton rdbH3;
        private System.Windows.Forms.RadioButton rdbH2;
        private System.Windows.Forms.RadioButton rdbH1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbD2;
        private System.Windows.Forms.RadioButton rdbD1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbV2;
        private System.Windows.Forms.RadioButton rdbV1;
        private System.Windows.Forms.Label lblPrice;
    }
}

