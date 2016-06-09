using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManager.Models;
using HotelManager.BLL;
using System.Text.RegularExpressions;
/**************************************
 * 类名：RoomTypeSettingForm
 * 创建日期：2008-9-15
 * 功能描述：提供客房类型信息设置功能
 * ***********************************/
namespace HotelManager
{
    public partial class RoomTypeSettingForm : Form
    {
        #region Private Members
       
        RoomType roomType = new RoomType();
       
        string typeID = string.Empty;
        #endregion

        #region Public Methods
        public RoomTypeSettingForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 绑定客房类型信息列表
        /// </summary>
        public void BindRoomTypeList()
        {
            //取消DataGridView自动生成列功能
            this.dgvRoomType.AutoGenerateColumns = false;
            if (string.IsNullOrEmpty(this.txtTypeName.Text.Trim()))
                this.dgvRoomType.DataSource = RoomTypeManager.GetRoomTypeList();
            else
                this.dgvRoomType.DataSource = RoomTypeManager.GetRoomTypeListByTypeName(this.txtTypeName.Text.Trim());

        }
        /// <summary>
        /// 隐藏编辑区
        /// </summary>
        public void HideEditSection()
        {
            //将窗体高度设置为原始大小
            this.Height = 　388;
            //将编辑内容设置为不可操作状态
            this.txtAddBedPrice.Enabled = false;
            this.txtPrice.Enabled = false;
            this.txtRemark.Enabled = false;
            this.txtType.Enabled = false;
            this.chkIsAddBed.Enabled = false;
            //隐藏编辑区
            this.pnlRoomTypeContent.Visible = false;
        }
        /// <summary>
        /// 显示编辑区
        /// </summary>
        public void VisibleEditSection()
        {
            //设置编辑内容为可操作状态
            this.txtAddBedPrice.Enabled = true;
            this.txtPrice.Enabled = true;
            this.txtRemark.Enabled = true;
            this.txtType.Enabled = true;
            this.chkIsAddBed.Enabled = true;
            //设置内容编辑区
            this.Height = 498;
            this.pnlRoomTypeContent.Visible = true;
        }
        /// <summary>
        /// 清空编辑区
        /// </summary>
        public void ClearEditSection()
        {
            this.txtAddBedPrice.Text ="";
            this.txtPrice.Text = "";
            this.txtRemark.Text = "";
            this.txtType.Text = "";
            this.chkIsAddBed.Checked = false;;
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// 搜索客房类型信息
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //通过类型名称得到类型列表
            BindRoomTypeList();
        }
        /// <summary>
        /// 新增客房类型信息
        /// </summary>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            //显示编辑区
            VisibleEditSection();
            //清空编辑区
            ClearEditSection();
        }
        /// <summary>
        /// 修改客房类型信息
        /// </summary>
        private void tsbtnModify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtType.Text) && string.IsNullOrEmpty(typeID))
                MessageBox.Show("没有可修改信息，请选择要修改的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //现在编辑区
                VisibleEditSection();
            }
        }
        /// <summary>
        /// 删除客房类型信息
        /// </summary>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(typeID) && !string.IsNullOrEmpty(txtType.Text.Trim()))
            {
                //调用业务逻辑层客房信息删除功能
                DialogResult result = MessageBox.Show("您确实要删除此信息吗？", "提交提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                   RoomTypeManager.DeleteRoomTypeByTypeId(Convert.ToInt32(typeID));
                    //刷新房屋信息列表
                    BindRoomTypeList();
                    MessageBox.Show("信息删除成功！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 保存客房类型信息
        /// </summary>
        private void tsbtnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtType.Text))
            {
                MessageBox.Show("类型名称不能为空！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IsWholeNumber(this.txtPrice.Text.Trim()))
            {
                MessageBox.Show("请输入有效的价格！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IsWholeNumber(this.txtAddBedPrice.Text.Trim()))
            {
                MessageBox.Show("请输入有效的加床价格！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //提示信息
            string message = string.Empty;
            //用实体对象封装信息
            roomType.TypeName = this.txtType.Text.Trim();
            roomType.TypePrice = Convert.ToDecimal(this.txtPrice.Text.Trim());
            roomType.AddBedPrice = Convert.ToDecimal(this.txtAddBedPrice.Text.Trim());
            if (this.chkIsAddBed.Checked)
                roomType.IsAddBed = "是";
            else
                roomType.IsAddBed = "否";
            roomType.Remark = this.txtRemark.Text.Trim();
            //调用业务逻辑客房类型信息增加功能
            message = RoomTypeManager.AddRoomType(roomType).ToString();
            //刷新房屋信息列表
            BindRoomTypeList();
            //弹出提示信息框
            MessageBox.Show(message, "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 取消内容编辑区
        /// </summary>
        private void tsbtnCancle_Click(object sender, EventArgs e)
        {
            //隐藏编辑区
            HideEditSection();
            //清空编辑区
            ClearEditSection();
        }
        /// <summary>
        /// 退出窗体
        /// </summary>
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 窗体加载时执行
        /// </summary>
        private void RoomTypeSettingForm_Load(object sender, EventArgs e)
        {　
            //绑定客房类型信息列表
            BindRoomTypeList();
        }
        /// <summary>
        /// 单击客房信息列表某行获得客房类型ＩＤ
        /// </summary>
        private void dgvRoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //显示编辑区
            this.pnlRoomTypeContent.Visible = true;
            this.Height = 498;
            //获取客房类型ＩＤ
            typeID = dgvRoomType.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            //调用业务逻辑层通过类型ＩＤ得到客房类型信息
            roomType = RoomTypeManager.GetRoomTypeByTypeID(Convert.ToInt32(typeID));
            //回绑数据
            this.txtType.Text = roomType.TypeName.Trim();
            this.txtPrice.Text = Convert.ToString(roomType.TypePrice);
            this.txtAddBedPrice.Text = Convert.ToString(roomType.AddBedPrice);
            if (roomType.IsAddBed.Trim() == "是")
                this.chkIsAddBed.Checked = true;
            else
                this.chkIsAddBed.Checked = false;
            this.txtRemark.Text = roomType.Remark;
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
        #endregion
    }
}