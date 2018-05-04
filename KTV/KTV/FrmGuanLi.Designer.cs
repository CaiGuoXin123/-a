namespace KTV
{
    partial class FrmGuanLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuanLi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.歌手管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加歌手信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询歌手信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.歌曲管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置资源路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.歌手管理ToolStripMenuItem,
            this.歌曲管理ToolStripMenuItem,
            this.设置资源路径ToolStripMenuItem,
            this.账户管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 歌手管理ToolStripMenuItem
            // 
            this.歌手管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加歌手信息ToolStripMenuItem,
            this.查询歌手信息ToolStripMenuItem});
            this.歌手管理ToolStripMenuItem.Name = "歌手管理ToolStripMenuItem";
            this.歌手管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.歌手管理ToolStripMenuItem.Text = "歌手管理";
            this.歌手管理ToolStripMenuItem.Click += new System.EventHandler(this.歌手管理ToolStripMenuItem_Click);
            // 
            // 增加歌手信息ToolStripMenuItem
            // 
            this.增加歌手信息ToolStripMenuItem.Name = "增加歌手信息ToolStripMenuItem";
            this.增加歌手信息ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.增加歌手信息ToolStripMenuItem.Text = "增加歌手信息";
            this.增加歌手信息ToolStripMenuItem.Click += new System.EventHandler(this.增加歌手信息ToolStripMenuItem_Click);
            // 
            // 查询歌手信息ToolStripMenuItem
            // 
            this.查询歌手信息ToolStripMenuItem.Name = "查询歌手信息ToolStripMenuItem";
            this.查询歌手信息ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.查询歌手信息ToolStripMenuItem.Text = "查询歌手信息";
            this.查询歌手信息ToolStripMenuItem.Click += new System.EventHandler(this.查询歌手信息ToolStripMenuItem_Click);
            // 
            // 歌曲管理ToolStripMenuItem
            // 
            this.歌曲管理ToolStripMenuItem.Name = "歌曲管理ToolStripMenuItem";
            this.歌曲管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.歌曲管理ToolStripMenuItem.Text = "歌曲管理";
            // 
            // 设置资源路径ToolStripMenuItem
            // 
            this.设置资源路径ToolStripMenuItem.Name = "设置资源路径ToolStripMenuItem";
            this.设置资源路径ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.设置资源路径ToolStripMenuItem.Text = "设置资源路径";
            // 
            // 账户管理ToolStripMenuItem
            // 
            this.账户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem});
            this.账户管理ToolStripMenuItem.Name = "账户管理ToolStripMenuItem";
            this.账户管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.账户管理ToolStripMenuItem.Text = "账户管理";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // FrmGuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 514);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGuanLi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "KTV后台管理";
            this.Load += new System.EventHandler(this.FrmGuanLi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 歌手管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 歌曲管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置资源路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加歌手信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询歌手信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
    }
}