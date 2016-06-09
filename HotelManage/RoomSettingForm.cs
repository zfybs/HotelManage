using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HotelManager.Models;
using HotelManager.BLL;
/**************************************
 * 类名：RoomSettingForm
 * 创建日期：2008-9-15
 * 功能描述：提供客房信息设置功能
 * ***********************************/
namespace HotelManager
{
    public partial class RoomSettingForm : Form
    {
        #region Private Members
        Room room = new Room();
        RoomType roomType = new RoomType();
        
        string roomId = string.Empty;
        #endregion

        #region Public Methods
        public RoomSettingForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 隐藏编辑区
        /// </summary>
        public void HideEditSection()
        {
            //将窗体高度设置为原始大小
            this.Height = 417;
            //将编辑内容设置为不可操作状态
            this.txtRoomNO.Enabled = false;
            this.txtBed.Enabled = false;
            this.txtDescription.Enabled = false;
            this.txtGuestNumber.Enabled = false;
            this.cboState.Enabled = false;
            this.cboTypeName.Enabled = false;
            //隐藏编辑区
            this.pnlContent.Visible = false;
        }
        /// <summary>
        /// 显示编辑区
        /// </summary>
        public void VisibleEditSection()
        {
            //设置编辑内容为可操作状态
            this.txtBed.Enabled = true;
            this.txtDescription.Enabled = true;
            this.txtGuestNumber.Enabled = true;
            this.cboState.Enabled = true;
            this.cboTypeName.Enabled = true;
            this.txtRoomNO.Enabled = true;
            //设置内容编辑区
            this.Height = 531;
            this.pnlContent.Visible = true;
        }
        /// <summary>
        /// 清空编辑区
        /// </summary>
        public void ClearEditSection()
        {
            this.txtRoomNO.Text = "";
            this.cboState.Text = "空闲";
            this.txtDescription.Text = "";
            this.txtBed.Text = "";
            this.txtGuestNumber.Text = "";
            this.cboTypeName.Text = "标间";
            this.txtPrice.Text = "100.0000";
        }
        /// <summary>
        /// 绑定房屋信息列表
        /// </summary>
        public void BindRoomInfoList()
        {
            //取消DataGridView自动生成列功能
            this.dgvRoom.AutoGenerateColumns = false;
            if (string.IsNullOrEmpty(this.txtRoomNumber.Text.Trim()))
            {
                //绑定数据源
                this.dgvRoom.DataSource = RoomManager.GetAllRooms();
            }
            else
                this.dgvRoom.DataSource = RoomManager.GetRoomListByRoomNumber(this.txtRoomNumber.Text.Trim());
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// 新增记录
        /// </summary>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            //    显示编辑区
            VisibleEditSection();
            //    清空编辑区
            ClearEditSection();
        }
        /// <summary>
        /// 修改
        /// </summary>
        private void tsbtnModify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(roomId) && string.IsNullOrEmpty(txtRoomNO.Text.Trim()))
                MessageBox.Show("没有可修改信息，请选择要修改的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //现在编辑区
                VisibleEditSection();
            }
    
        }
        /// <summary>
        /// 删除
        /// </summary>
        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(roomId) && !string.IsNullOrEmpty(txtRoomNO.Text.Trim()))
            {
                //调用业务逻辑层客房信息删除功能
                DialogResult result = MessageBox.Show("您确实要删除此信息吗？", "提交提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    if (RoomManager.DeleteRoomByRoomId(Convert.ToInt32(roomId)))
                    {
                        //刷新房屋信息列表
                        BindRoomInfoList();
                        MessageBox.Show("信息删除成功！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("该客房有客人入住，不能删除");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 数字验证
        /// </summary>
        /// <param name="strNumber">被验证信息</param>
        /// <returns></returns>
        public bool IsWholeNumber(string strNumber)
        {
            Regex notWholePattern = new Regex(@"^[-]?\d+[.]?\d*$");
            return notWholePattern.IsMatch(strNumber, 0);
        }
        /// <summary>
        /// 保存
        /// </summary>
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRoomNO.Text))
            {
                MessageBox.Show("房间号不能为空！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsWholeNumber(this.txtGuestNumber.Text.Trim()))
            {
                MessageBox.Show("入住人数必须是有效的整数！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsWholeNumber(this.txtBed.Text.Trim()))
            {
                MessageBox.Show("床位数必须是有效的整数！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(this.txtDescription.Text))
            {
                MessageBox.Show("描述信息不能为空！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //提示信息
            string message = string.Empty;
            //用实体对象封装信息
            //room.Number = this.txtRoomNO.Text.Trim();
            //room.TypeID = RoomTypeManager.GetRoomTypeList(this.cboTypeName.Text.Trim());
            //room.BedNumber = Convert.ToInt32(this.txtBed.Text.Trim());
            //room.Description = this.txtDescription.Text.Trim();
            //room.State = this.cboState.Text.Trim();
            //room.GuestNumber = Convert.ToInt32(this.txtGuestNumber.Text.Trim());         
            ////调用业务逻辑客房信息增加功能
            //message = RoomManager.AddRoom(room).ToString();
            ////刷新房屋信息列表
            //BindRoomInfoList();
            ////弹出提示信息框
            //MessageBox.Show(message, "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 取消
        /// </summary>
        private void tsbtnCancle_Click(object sender, EventArgs e)
        {
            //    //隐藏编辑区
            HideEditSection();
            //    //清空编辑区
            ClearEditSection();
        }
        /// <summary>
        /// 退出
        /// </summary>
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 按条件搜索相关内容
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRoomNumber.Text.Trim()))
                MessageBox.Show("请输入房间号！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                //根据房间号查找消息
                BindRoomInfoList();
        }
        /// <summary>
        /// 窗体加载时执行 
        /// </summary>
        private void RoomSettingForm_Load(object sender, EventArgs e)
        {
            //绑定客房类型数据
            this.cboTypeName.DataSource = RoomTypeManager.GetAllRoomTypes();
            this.cboTypeName.DisplayMember = "TypeName";
            //绑定客房信息
            BindRoomInfoList();
        }
        /// <summary>
        /// 根据所选客房类型动态得到客房价格
        /// </summary>
        //private void cboTypeName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (!String.IsNullOrEmpty(this.cboTypeName.Text))
        //    {
        //        this.txtPrice.Text = RoomTypeManager.GetRoomPriceByTypeName(this.cboTypeName.Text.Trim());
        //    }
        //}
        /// <summary>
        /// 通过单击客房信息得到客房ＩＤ
        /// </summary>
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //设置内容编辑区
            this.Height = 531;
            this.pnlContent.Visible = true;
            //获取双击客房信息的ＩＤ
            roomId = dgvRoom.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            //调用业务逻辑层通过客房ＩＤ得到客房信息
            room = RoomManager.GetRoomByRoomId(Convert.ToInt32(roomId));
            //将客房信息回绑到编辑控件
            this.txtRoomNO.Text = room.Number;
            this.txtGuestNumber.Text = Convert.ToString(room.GuestNumber);
            this.txtBed.Text = Convert.ToString(room.BedNumber);
            this.cboState.Text = room.State;
            this.txtDescription.Text = room.Description;
            //调用业务逻辑层通过客房类型ＩＤ得到客房类型信息
            roomType = RoomTypeManager.GetRoomTypeByTypeID(room.TypeID);
            //回绑客房类型信息
            this.cboTypeName.Text = roomType.TypeName;
            this.txtPrice.Text = Convert.ToString(roomType.TypePrice);
        }
        #endregion  

    }
}