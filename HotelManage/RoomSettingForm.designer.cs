namespace HotelManager
{
    partial class RoomSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomSettingForm));
            this.txtBed = new System.Windows.Forms.TextBox();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpQuery = new System.Windows.Forms.GroupBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tspRoomSet = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnModify = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancle = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblGuestNumber = new System.Windows.Forms.Label();
            this.txtGuestNumber = new System.Windows.Forms.TextBox();
            this.cboTypeName = new System.Windows.Forms.ComboBox();
            this.txtRoomNO = new System.Windows.Forms.TextBox();
            this.lblRoomNO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.grpQuery.SuspendLayout();
            this.tspRoomSet.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBed
            // 
            this.txtBed.Enabled = false;
            this.txtBed.Location = new System.Drawing.Point(501, 23);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(98, 21);
            this.txtBed.TabIndex = 9;
            // 
            // dgvRoom
            // 
            this.dgvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Column7,
            this.Column9,
            this.Column4,
            this.Column8,
            this.ID});
            this.dgvRoom.Location = new System.Drawing.Point(3, 86);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowTemplate.Height = 23;
            this.dgvRoom.Size = new System.Drawing.Size(743, 295);
            this.dgvRoom.TabIndex = 8;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "房间号";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "BedNumber";
            this.Column7.HeaderText = "床位数";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "State";
            this.Column9.HeaderText = "状态";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GuestNumber";
            this.Column4.HeaderText = "入住人数";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Description";
            this.Column8.HeaderText = "描述";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 300;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "RoomID";
            this.ID.HeaderText = "客房ＩＤ";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // grpQuery
            // 
            this.grpQuery.Controls.Add(this.lblRoomNumber);
            this.grpQuery.Controls.Add(this.txtRoomNumber);
            this.grpQuery.Controls.Add(this.btnQuery);
            this.grpQuery.Location = new System.Drawing.Point(5, 37);
            this.grpQuery.Name = "grpQuery";
            this.grpQuery.Size = new System.Drawing.Size(741, 43);
            this.grpQuery.TabIndex = 7;
            this.grpQuery.TabStop = false;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(124, 17);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(53, 12);
            this.lblRoomNumber.TabIndex = 3;
            this.lblRoomNumber.Text = "房间号：";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(184, 14);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(294, 21);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(532, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tspRoomSet
            // 
            this.tspRoomSet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnModify,
            this.tsbtnDel,
            this.tsbtnSave,
            this.tsbtnCancle,
            this.tsbtnExit});
            this.tspRoomSet.Location = new System.Drawing.Point(0, 0);
            this.tspRoomSet.Name = "tspRoomSet";
            this.tspRoomSet.Size = new System.Drawing.Size(751, 35);
            this.tspRoomSet.TabIndex = 6;
            this.tspRoomSet.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = global::HotelManage.Properties.Resources.新增;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(33, 32);
            this.tsbtnAdd.Text = "新增";
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnModify
            // 
            this.tsbtnModify.Image = global::HotelManage.Properties.Resources.修改;
            this.tsbtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModify.Name = "tsbtnModify";
            this.tsbtnModify.Size = new System.Drawing.Size(33, 32);
            this.tsbtnModify.Text = "修改";
            this.tsbtnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnModify.Click += new System.EventHandler(this.tsbtnModify_Click);
            // 
            // tsbtnDel
            // 
            this.tsbtnDel.Image = global::HotelManage.Properties.Resources.删除;
            this.tsbtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDel.Name = "tsbtnDel";
            this.tsbtnDel.Size = new System.Drawing.Size(33, 32);
            this.tsbtnDel.Text = "删除";
            this.tsbtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDel.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = global::HotelManage.Properties.Resources.保存;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(33, 32);
            this.tsbtnSave.Text = "保存";
            this.tsbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // tsbtnCancle
            // 
            this.tsbtnCancle.Image = global::HotelManage.Properties.Resources.返回;
            this.tsbtnCancle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancle.Name = "tsbtnCancle";
            this.tsbtnCancle.Size = new System.Drawing.Size(33, 32);
            this.tsbtnCancle.Text = "取消";
            this.tsbtnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCancle.Click += new System.EventHandler(this.tsbtnCancle_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = global::HotelManage.Properties.Resources.退出;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(33, 32);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(3, 63);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(739, 49);
            this.txtDescription.TabIndex = 13;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(127, 9);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(53, 12);
            this.lblTypeName.TabIndex = 14;
            this.lblTypeName.Text = "类型名称";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Location = new System.Drawing.Point(499, 8);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(41, 12);
            this.lblBed.TabIndex = 15;
            this.lblBed.Text = "床位数";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(238, 9);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "价格";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(3, 48);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(29, 12);
            this.lbldescription.TabIndex = 17;
            this.lbldescription.Text = "描述";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(612, 8);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(29, 12);
            this.lblState.TabIndex = 18;
            this.lblState.Text = "状态";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.cboState);
            this.pnlContent.Controls.Add(this.txtPrice);
            this.pnlContent.Controls.Add(this.lblGuestNumber);
            this.pnlContent.Controls.Add(this.txtGuestNumber);
            this.pnlContent.Controls.Add(this.cboTypeName);
            this.pnlContent.Controls.Add(this.txtRoomNO);
            this.pnlContent.Controls.Add(this.lblRoomNO);
            this.pnlContent.Controls.Add(this.lblTypeName);
            this.pnlContent.Controls.Add(this.txtDescription);
            this.pnlContent.Controls.Add(this.lbldescription);
            this.pnlContent.Controls.Add(this.lblState);
            this.pnlContent.Controls.Add(this.lblBed);
            this.pnlContent.Controls.Add(this.lblPrice);
            this.pnlContent.Controls.Add(this.txtBed);
            this.pnlContent.Location = new System.Drawing.Point(4, 387);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(742, 115);
            this.pnlContent.TabIndex = 19;
            this.pnlContent.Visible = false;
            // 
            // cboState
            // 
            this.cboState.Enabled = false;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "空闲",
            "入住",
            "维修",
            "自用"});
            this.cboState.Location = new System.Drawing.Point(614, 23);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(128, 20);
            this.cboState.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(241, 23);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 25;
            // 
            // lblGuestNumber
            // 
            this.lblGuestNumber.AutoSize = true;
            this.lblGuestNumber.Location = new System.Drawing.Point(362, 7);
            this.lblGuestNumber.Name = "lblGuestNumber";
            this.lblGuestNumber.Size = new System.Drawing.Size(53, 12);
            this.lblGuestNumber.TabIndex = 24;
            this.lblGuestNumber.Text = "入住人数";
            // 
            // txtGuestNumber
            // 
            this.txtGuestNumber.Enabled = false;
            this.txtGuestNumber.Location = new System.Drawing.Point(362, 23);
            this.txtGuestNumber.Name = "txtGuestNumber";
            this.txtGuestNumber.Size = new System.Drawing.Size(117, 21);
            this.txtGuestNumber.TabIndex = 23;
            // 
            // cboTypeName
            // 
            this.cboTypeName.Enabled = false;
            this.cboTypeName.FormattingEnabled = true;
            this.cboTypeName.Location = new System.Drawing.Point(127, 24);
            this.cboTypeName.Name = "cboTypeName";
            this.cboTypeName.Size = new System.Drawing.Size(93, 20);
            this.cboTypeName.TabIndex = 21;
            // 
            // txtRoomNO
            // 
            this.txtRoomNO.Enabled = false;
            this.txtRoomNO.Location = new System.Drawing.Point(5, 23);
            this.txtRoomNO.Name = "txtRoomNO";
            this.txtRoomNO.Size = new System.Drawing.Size(100, 21);
            this.txtRoomNO.TabIndex = 20;
            // 
            // lblRoomNO
            // 
            this.lblRoomNO.AutoSize = true;
            this.lblRoomNO.Location = new System.Drawing.Point(3, 8);
            this.lblRoomNO.Name = "lblRoomNO";
            this.lblRoomNO.Size = new System.Drawing.Size(41, 12);
            this.lblRoomNO.TabIndex = 19;
            this.lblRoomNO.Text = "房间号";
            // 
            // RoomSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 388);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.grpQuery);
            this.Controls.Add(this.tspRoomSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【客房信息设置】";
            this.Load += new System.EventHandler(this.RoomSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.grpQuery.ResumeLayout(false);
            this.grpQuery.PerformLayout();
            this.tspRoomSet.ResumeLayout(false);
            this.tspRoomSet.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBed;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.GroupBox grpQuery;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ToolStrip tspRoomSet;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnModify;
        private System.Windows.Forms.ToolStripButton tsbtnDel;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnCancle;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TextBox txtRoomNO;
        private System.Windows.Forms.Label lblRoomNO;
        private System.Windows.Forms.ComboBox cboTypeName;
        private System.Windows.Forms.Label lblGuestNumber;
        private System.Windows.Forms.TextBox txtGuestNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;

    }
}