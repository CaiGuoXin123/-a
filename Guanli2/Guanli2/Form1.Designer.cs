namespace Guanli2
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnshan = new System.Windows.Forms.Button();
            this.btntian = new System.Windows.Forms.Button();
            this.cbmmu = new System.Windows.Forms.ComboBox();
            this.cbmli = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblbiao = new System.Windows.Forms.Label();
            this.lblxiang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnjia = new System.Windows.Forms.Button();
            this.txtming = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnshan);
            this.groupBox2.Controls.Add(this.btntian);
            this.groupBox2.Controls.Add(this.cbmmu);
            this.groupBox2.Controls.Add(this.cbmli);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.lblbiao);
            this.groupBox2.Controls.Add(this.lblxiang);
            this.groupBox2.Location = new System.Drawing.Point(26, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 376);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "检查套餐维护";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "231";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "价格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "套餐：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(39, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(591, 212);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "项目名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Bewrite";
            this.Column2.HeaderText = "描述";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "价格";
            this.Column3.Name = "Column3";
            // 
            // btnshan
            // 
            this.btnshan.Location = new System.Drawing.Point(489, 75);
            this.btnshan.Name = "btnshan";
            this.btnshan.Size = new System.Drawing.Size(75, 23);
            this.btnshan.TabIndex = 2;
            this.btnshan.Text = "删除";
            this.btnshan.UseVisualStyleBackColor = true;
            // 
            // btntian
            // 
            this.btntian.Location = new System.Drawing.Point(366, 75);
            this.btntian.Name = "btntian";
            this.btntian.Size = new System.Drawing.Size(75, 23);
            this.btntian.TabIndex = 2;
            this.btntian.Text = "添加";
            this.btntian.UseVisualStyleBackColor = true;
            this.btntian.Click += new System.EventHandler(this.btntian_Click);
            // 
            // cbmmu
            // 
            this.cbmmu.FormattingEnabled = true;
            this.cbmmu.Location = new System.Drawing.Point(447, 33);
            this.cbmmu.Name = "cbmmu";
            this.cbmmu.Size = new System.Drawing.Size(157, 23);
            this.cbmmu.TabIndex = 1;
            // 
            // cbmli
            // 
            this.cbmli.FormattingEnabled = true;
            this.cbmli.Location = new System.Drawing.Point(139, 33);
            this.cbmli.Name = "cbmli";
            this.cbmli.Size = new System.Drawing.Size(157, 23);
            this.cbmli.TabIndex = 1;
            this.cbmli.SelectedIndexChanged += new System.EventHandler(this.cbmli_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(299, 105);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 0;
            // 
            // lblbiao
            // 
            this.lblbiao.AutoSize = true;
            this.lblbiao.Location = new System.Drawing.Point(51, 41);
            this.lblbiao.Name = "lblbiao";
            this.lblbiao.Size = new System.Drawing.Size(67, 15);
            this.lblbiao.TabIndex = 0;
            this.lblbiao.Text = "套餐列表";
            // 
            // lblxiang
            // 
            this.lblxiang.AutoSize = true;
            this.lblxiang.Location = new System.Drawing.Point(363, 41);
            this.lblxiang.Name = "lblxiang";
            this.lblxiang.Size = new System.Drawing.Size(67, 15);
            this.lblxiang.TabIndex = 0;
            this.lblxiang.Text = "检查项目";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnjia);
            this.groupBox1.Controls.Add(this.txtming);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新建套餐";
            // 
            // btnjia
            // 
            this.btnjia.Location = new System.Drawing.Point(366, 40);
            this.btnjia.Name = "btnjia";
            this.btnjia.Size = new System.Drawing.Size(75, 23);
            this.btnjia.TabIndex = 2;
            this.btnjia.Text = "添加";
            this.btnjia.UseVisualStyleBackColor = true;
            // 
            // txtming
            // 
            this.txtming.Location = new System.Drawing.Point(150, 46);
            this.txtming.Name = "txtming";
            this.txtming.Size = new System.Drawing.Size(157, 25);
            this.txtming.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "套餐名称";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnshan;
        private System.Windows.Forms.Button btntian;
        private System.Windows.Forms.ComboBox cbmmu;
        private System.Windows.Forms.ComboBox cbmli;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblbiao;
        private System.Windows.Forms.Label lblxiang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnjia;
        private System.Windows.Forms.TextBox txtming;
        private System.Windows.Forms.Label lblName;
    }
}

