namespace OpenLas
{
    partial class OpenLas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenLas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.打开点云ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建LasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开LasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.鼠标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开点云ToolStripMenuItem,
            this.鼠标ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1033, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 打开点云ToolStripMenuItem
            // 
            this.打开点云ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建LasdToolStripMenuItem,
            this.打开LasdToolStripMenuItem});
            this.打开点云ToolStripMenuItem.Name = "打开点云ToolStripMenuItem";
            this.打开点云ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.打开点云ToolStripMenuItem.Text = "打开点云";
            // 
            // 创建LasdToolStripMenuItem
            // 
            this.创建LasdToolStripMenuItem.Name = "创建LasdToolStripMenuItem";
            this.创建LasdToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.创建LasdToolStripMenuItem.Text = "创建Lasd";
            this.创建LasdToolStripMenuItem.Click += new System.EventHandler(this.创建LasdToolStripMenuItem_Click);
            // 
            // 打开LasdToolStripMenuItem
            // 
            this.打开LasdToolStripMenuItem.Name = "打开LasdToolStripMenuItem";
            this.打开LasdToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.打开LasdToolStripMenuItem.Text = "打开Lasd";
            this.打开LasdToolStripMenuItem.Click += new System.EventHandler(this.打开LasdToolStripMenuItem_Click);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 28);
            this.axMapControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(1033, 500);
            this.axMapControl1.TabIndex = 1;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(248, 52);
            this.axLicenseControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 2;
            // 
            // 鼠标ToolStripMenuItem
            // 
            this.鼠标ToolStripMenuItem.Name = "鼠标ToolStripMenuItem";
            this.鼠标ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.鼠标ToolStripMenuItem.Text = "鼠标";
            this.鼠标ToolStripMenuItem.Click += new System.EventHandler(this.鼠标ToolStripMenuItem_Click);
            // 
            // OpenLas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 528);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OpenLas";
            this.Text = "打开点云";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开点云ToolStripMenuItem;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.ToolStripMenuItem 创建LasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开LasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 鼠标ToolStripMenuItem;
    }
}

