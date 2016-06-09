namespace HotelManager
{
    partial class RoomTypeSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTypeSettingForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.grpQuery = new System.Windows.Forms.GroupBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvRoomType = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAddBedPrice = new System.Windows.Forms.TextBox();
            this.pnlRoomTypeContent = new System.Windows.Forms.Panel();
            this.chkIsAddBed = new System.Windows.Forms.CheckBox();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnModify = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancle = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.grpQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).BeginInit();
            this.pnlRoomTypeContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnModify,
            this.tsbtnDelete,
            this.tsbtnSave,
            this.tsbtnCancle,
            this.tsbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = global::HotelManage.Properties.Resources.返回;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(33, 32);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // grpQuery
            // 
            this.grpQuery.Controls.Add(this.lblTypeName);
            this.grpQuery.Controls.Add(this.txtTypeName);
            this.grpQuery.Controls.Add(this.btnQuery);
            this.grpQuery.Location = new System.Drawing.Point(5, 32);
            this.grpQuery.Name = "grpQuery";
            this.grpQuery.Size = new System.Drawing.Size(640, 43);
            this.grpQuery.TabIndex = 1;
            this.grpQuery.TabStop = false;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(94, 17);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(65, 12);
            this.lblTypeName.TabIndex = 3;
            this.lblTypeName.Text = "类型名称：";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(165, 14);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(248, 21);
            this.txtTypeName.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(462, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvRoomType
            // 
            this.dgvRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Remark});
            this.dgvRoomType.Location = new System.Drawing.Point(5, 77);
            this.dgvRoomType.Name = "dgvRoomType";
            this.dgvRoomType.ReadOnly = true;
            this.dgvRoomType.RowTemplate.Height = 23;
            this.dgvRoomType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvRoomType.Size = new System.Drawing.Size(642, 282);
            this.dgvRoomType.TabIndex = 2;
            this.dgvRoomType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomType_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "TypeID";
            this.ID.HeaderText = "类型ＩＤ";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TypeName";
            this.Column2.HeaderText = "类型名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TypePrice";
            this.Column3.HeaderText = "价格";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "AddBedPrice";
            this.Column4.HeaderText = "加床价格";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "IsAddBed";
            this.Column6.HeaderText = "是否可以加床";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 200;
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(0, 20);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(268, 21);
            this.txtType.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(284, 20);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 4;
            // 
            // txtAddBedPrice
            // 
            this.txtAddBedPrice.Enabled = false;
            this.txtAddBedPrice.Location = new System.Drawing.Point(406, 20);
            this.txtAddBedPrice.Name = "txtAddBedPrice";
            this.txtAddBedPrice.Size = new System.Drawing.Size(100, 21);
            this.txtAddBedPrice.TabIndex = 5;
            // 
            // pnlRoomTypeContent
            // 
            this.pnlRoomTypeContent.Controls.Add(this.chkIsAddBed);
            this.pnlRoomTypeContent.Controls.Add(this.lblAddPrice);
            this.pnlRoomTypeContent.Controls.Add(this.lblPrice);
            this.pnlRoomTypeContent.Controls.Add(this.lblRemark);
            this.pnlRoomTypeContent.Controls.Add(this.lblType);
            this.pnlRoomTypeContent.Controls.Add(this.txtRemark);
            this.pnlRoomTypeContent.Controls.Add(this.txtPrice);
            this.pnlRoomTypeContent.Controls.Add(this.txtAddBedPrice);
            this.pnlRoomTypeContent.Controls.Add(this.txtType);
            this.pnlRoomTypeContent.Location = new System.Drawing.Point(5, 365);
            this.pnlRoomTypeContent.Name = "pnlRoomTypeContent";
            this.pnlRoomTypeContent.Size = new System.Drawing.Size(640, 104);
            this.pnlRoomTypeContent.TabIndex = 6;
            this.pnlRoomTypeContent.Visible = false;
            // 
            // chkIsAddBed
            // 
            this.chkIsAddBed.AutoSize = true;
            this.chkIsAddBed.Enabled = false;
            this.chkIsAddBed.Location = new System.Drawing.Point(538, 22);
            this.chkIsAddBed.Name = "chkIsAddBed";
            this.chkIsAddBed.Size = new System.Drawing.Size(96, 16);
            this.chkIsAddBed.TabIndex = 13;
            this.chkIsAddBed.Text = "是否可以加床";
            this.chkIsAddBed.UseVisualStyleBackColor = true;
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Location = new System.Drawing.Point(405, 4);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(53, 12);
            this.lblAddPrice.TabIndex = 12;
            this.lblAddPrice.Text = "加床价格";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(282, 4);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "价格";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(1, 44);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(29, 12);
            this.lblRemark.TabIndex = 9;
            this.lblRemark.Text = "备注";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(1, 4);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 12);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "类型名称";
            // 
            // txtRemark
            // 
            this.txtRemark.Enabled = false;
            this.txtRemark.Location = new System.Drawing.Point(0, 60);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemark.Size = new System.Drawing.Size(640, 41);
            this.txtRemark.TabIndex = 7;
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
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = global::HotelManage.Properties.Resources.删除;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(33, 32);
            this.tsbtnDelete.Text = "删除";
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
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
            this.tsbtnCancle.Image = global::HotelManage.Properties.Resources.退出;
            this.tsbtnCancle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancle.Name = "tsbtnCancle";
            this.tsbtnCancle.Size = new System.Drawing.Size(33, 32);
            this.tsbtnCancle.Text = "取消";
            this.tsbtnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCancle.Click += new System.EventHandler(this.tsbtnCancle_Click);
            // 
            // RoomTypeSettingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.ClientSize = new System.Drawing.Size(651, 366);
            this.Controls.Add(this.pnlRoomTypeContent);
            this.Controls.Add(this.dgvRoomType);
            this.Controls.Add(this.grpQuery);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomTypeSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【客房类型设置】";
            this.Load += new System.EventHandler(this.RoomTypeSettingForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpQuery.ResumeLayout(false);
            this.grpQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).EndInit();
            this.pnlRoomTypeContent.ResumeLayout(false);
            this.pnlRoomTypeContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnModify;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnCancle;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.GroupBox grpQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.DataGridView dgvRoomType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAddBedPrice;
        private System.Windows.Forms.Panel pnlRoomTypeContent;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.CheckBox chkIsAddBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}