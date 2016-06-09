namespace HotelManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.munsMain = new System.Windows.Forms.MenuStrip();
            this.tsmiBaseSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetRoomType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageBusiness = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageGuest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMain = new System.Windows.Forms.ToolStrip();
            this.tsbRoomType = new System.Windows.Forms.ToolStripButton();
            this.tsbRoomSet = new System.Windows.Forms.ToolStripButton();
            this.tsbBusiness = new System.Windows.Forms.ToolStripButton();
            this.tsbUserManager = new System.Windows.Forms.ToolStripButton();
            this.munsMain.SuspendLayout();
            this.tspMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // munsMain
            // 
            this.munsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBaseSetting,
            this.tsmiManageBusiness,
            this.tsmiUserManage,
            this.tsmiExit});
            this.munsMain.Location = new System.Drawing.Point(0, 0);
            this.munsMain.Name = "munsMain";
            this.munsMain.Size = new System.Drawing.Size(792, 24);
            this.munsMain.TabIndex = 0;
            this.munsMain.Text = "menuStrip1";
            // 
            // tsmiBaseSetting
            // 
            this.tsmiBaseSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetRoomType,
            this.tsmiSetRoom});
            this.tsmiBaseSetting.Name = "tsmiBaseSetting";
            this.tsmiBaseSetting.Size = new System.Drawing.Size(65, 20);
            this.tsmiBaseSetting.Text = "基础设置";
            // 
            // tsmiSetRoomType
            // 
            this.tsmiSetRoomType.Name = "tsmiSetRoomType";
            this.tsmiSetRoomType.Size = new System.Drawing.Size(142, 22);
            this.tsmiSetRoomType.Text = "客房类型设置";
            this.tsmiSetRoomType.Click += new System.EventHandler(this.tsmiSetRoomType_Click);
            // 
            // tsmiSetRoom
            // 
            this.tsmiSetRoom.Name = "tsmiSetRoom";
            this.tsmiSetRoom.Size = new System.Drawing.Size(142, 22);
            this.tsmiSetRoom.Text = "客房信息设置";
            this.tsmiSetRoom.Click += new System.EventHandler(this.tsmiSetRoom_Click);
            // 
            // tsmiManageBusiness
            // 
            this.tsmiManageBusiness.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageGuest});
            this.tsmiManageBusiness.Name = "tsmiManageBusiness";
            this.tsmiManageBusiness.Size = new System.Drawing.Size(65, 20);
            this.tsmiManageBusiness.Text = "业务管理";
            // 
            // tsmiManageGuest
            // 
            this.tsmiManageGuest.Name = "tsmiManageGuest";
            this.tsmiManageGuest.Size = new System.Drawing.Size(118, 22);
            this.tsmiManageGuest.Text = "客人管理";
            this.tsmiManageGuest.Click += new System.EventHandler(this.tsmiManageGuest_Click);
            // 
            // tsmiUserManage
            // 
            this.tsmiUserManage.Name = "tsmiUserManage";
            this.tsmiUserManage.Size = new System.Drawing.Size(65, 20);
            this.tsmiUserManage.Text = "用户管理";
            this.tsmiUserManage.Click += new System.EventHandler(this.tsmiUserManage_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(65, 20);
            this.tsmiExit.Text = "退出系统";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tspMain
            // 
            this.tspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRoomType,
            this.tsbRoomSet,
            this.tsbBusiness,
            this.tsbUserManager});
            this.tspMain.Location = new System.Drawing.Point(0, 24);
            this.tspMain.Name = "tspMain";
            this.tspMain.Size = new System.Drawing.Size(792, 25);
            this.tspMain.TabIndex = 2;
            // 
            // tsbRoomType
            // 
            this.tsbRoomType.Image = ((System.Drawing.Image)(resources.GetObject("tsbRoomType.Image")));
            this.tsbRoomType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoomType.Name = "tsbRoomType";
            this.tsbRoomType.Size = new System.Drawing.Size(97, 22);
            this.tsbRoomType.Text = "客房类型设置";
            // 
            // tsbRoomSet
            // 
            this.tsbRoomSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbRoomSet.Image")));
            this.tsbRoomSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoomSet.Name = "tsbRoomSet";
            this.tsbRoomSet.Size = new System.Drawing.Size(97, 22);
            this.tsbRoomSet.Text = "客房信息设置";
            // 
            // tsbBusiness
            // 
            this.tsbBusiness.Image = ((System.Drawing.Image)(resources.GetObject("tsbBusiness.Image")));
            this.tsbBusiness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBusiness.Name = "tsbBusiness";
            this.tsbBusiness.Size = new System.Drawing.Size(73, 22);
            this.tsbBusiness.Text = "业务管理";
            // 
            // tsbUserManager
            // 
            this.tsbUserManager.Image = ((System.Drawing.Image)(resources.GetObject("tsbUserManager.Image")));
            this.tsbUserManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUserManager.Name = "tsbUserManager";
            this.tsbUserManager.Size = new System.Drawing.Size(73, 22);
            this.tsbUserManager.Text = "用户管理";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tspMain);
            this.Controls.Add(this.munsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.munsMain;
            this.Name = "MainForm";
            this.Text = "【酒店管理系统】";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.munsMain.ResumeLayout(false);
            this.munsMain.PerformLayout();
            this.tspMain.ResumeLayout(false);
            this.tspMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip munsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiBaseSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetRoomType;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageBusiness;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageGuest;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserManage;
        private System.Windows.Forms.ToolStrip tspMain;
        private System.Windows.Forms.ToolStripButton tsbRoomType;
        private System.Windows.Forms.ToolStripButton tsbRoomSet;
        private System.Windows.Forms.ToolStripButton tsbBusiness;
        private System.Windows.Forms.ToolStripButton tsbUserManager;
    }
}