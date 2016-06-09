using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelManager.Models;
using HotelManager.BLL;

namespace HotelManager
{
    public partial class GuestManageForm : Form
    {
       Guest guest ;    //声明客人实体对象
        int id;         //定义整型变量
        public GuestManageForm()
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
            this.txtName.Enabled = false;
            this.txtPhone.Enabled = false;
            this.txtRoomID.Enabled = false;
            this.txtSex.Enabled = false;
            this.cboCatagory.Enabled = false;
            this.txtLeaveTime.Enabled = false;
            this.txtArriveTime.Enabled =false;
            //隐藏编辑区
            this.pnlContent.Visible = false;
        }
        /// <summary>
        /// 显示编辑区
        /// </summary>
        public void VisibleEditSection()
        {
            //设置编辑内容为可操作状态
            this.txtName.Enabled = true;
            this.txtPhone.Enabled = true;
            this.txtRoomID.Enabled = true;
            this.txtSex.Enabled = true;
            this.cboCatagory.Enabled = true;
            this.txtLeaveTime.Enabled = true;
            this.txtArriveTime.Enabled = true;
            //设置内容编辑区
            this.Height = 531;
            this.pnlContent.Visible = true;
        }
        /// <summary>
        /// 清空编辑区
        /// </summary>
        public void ClearEditSection()
        {
            this.txtName.Text = "";
            this.cboCatagory.Text = "普通客人";
            this.txtPhone.Text = "";
            this.txtSex.Text = "";
            this.txtRoomID.Text = "";
            this.txtLeaveTime.Text = "";
            this.txtArriveTime.Text = "";
        }
 
        /// <summary>
        /// 新增功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleEditSection();   // 显示编辑区
            ClearEditSection();     //  清空编辑区
            SetEnable();            //设置可编辑状态
        }
        /// <summary>
        /// 修改功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guest.Name) && string.IsNullOrEmpty(this.txtName.Text.Trim()))
                MessageBox.Show("没有可修改信息，请选择要修改的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                
                VisibleEditSection();//显示编辑区
                SetEnable();//设置可编辑状态
            }
        }
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
 
        private void GuestManageForm_Load(object sender, EventArgs e)
        {
            this.pnlContent.Visible = false;//隐藏编辑区
            this.dgvGuest.AutoGenerateColumns = false;
            if (string.IsNullOrEmpty(this.txtGuestName.Text.Trim()))
            {
                this.dgvGuest.DataSource = GuestManager.GetAllGuests();

             }
            else
            this.dgvGuest.DataSource = GuestManager.GetGuestByGuestName(this.txtGuestName.Text.Trim());
        }
        /// <summary>
        /// 退出功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       /// <summary>
       /// 取消功能
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlContent.Visible = false;
        }
        /// <summary>
        /// 保存功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guest guest=new Guest();
                guest.Name=this.txtName.Text.Trim();
                guest.LeaveTime = Convert.ToDateTime(this.txtLeaveTime.Text);
                guest.ArriveTime = Convert.ToDateTime(this.txtArriveTime.Text);
                guest.CategoryId = 1;
                guest.Mobile = this.txtPhone.Text.Trim();
                guest.Sex = this.txtSex.Text.Trim();
                guest.RoomId=Convert.ToInt32(this.txtRoomID.Text.Trim());
                GuestManager.AddGuest(guest);
                MessageBox.Show("保存成功");
                
                this.dgvGuest.DataSource = GuestManager.GetAllGuests();

               

        }
        /// <summary>
        /// 单击DataGridView控件中的单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //显示编辑区
            VisibleEditSection(); 
            //获取双击客人信息的ＩＤ
            id = Convert.ToInt32(this.dgvGuest.Rows[e.RowIndex].Cells["GuestID"].Value);
            //调用业务逻辑层通过客人ＩＤ得到客房信息
            guest = GuestManager.GetGuestByID(Convert.ToInt32(id));
            //将客人信息回绑到编辑控件
            this.txtName.Text = guest.Name.ToString();
            this.txtSex.Text = guest.Sex.ToString();
            this.txtPhone.Text = guest.Mobile.ToString();
            //Room room = RoomManager.GetRoomByRoomId(Convert.ToInt32(guest.RoomId));
            this.txtRoomID.Text = guest.RoomId.ToString();
           this.txtArriveTime.Text=guest.ArriveTime.ToString();
            this.txtLeaveTime.Text=guest.LeaveTime.ToString();
            //调用业务逻辑层通过客人类型ＩＤ得到客人类型信息
            GuestCategory gc = GuestCategoryManager.GetGuestCategoryByCategoryID(Convert.ToInt32(guest.CategoryId));
            //回绑客房类型信息
            this.cboCatagory.Text =gc.CategoryName.ToString();
           
           
        }
        /// <summary>
        /// 设置编辑区控件不可编辑状态
        /// </summary>
        private void SetUnEnable()
        {
            this.txtArriveTime.Enabled = false;
            this.txtLeaveTime.Enabled = false;
            this.txtName.Enabled = false;
            this.txtPhone.Enabled = false;
            this.cboCatagory.Enabled = false;
            this.txtRoomID.Enabled = false;
            this.txtSex.Enabled = false;

        
        }
        /// <summary>
        /// 设置控件为可编辑状态
        /// </summary>
        private void SetEnable()
        {
            this.txtArriveTime.Enabled = true;
            this.txtLeaveTime.Enabled = true;
            this.txtName.Enabled = true;
            this.txtPhone.Enabled = true;
            this.cboCatagory.Enabled = true;
            this.txtRoomID.Enabled = true;
            this.txtSex.Enabled = true;


        }
        /// <summary>
        /// 删除功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("没有删除的信息");
                return;
            }
            else
            {
                DialogResult result=MessageBox.Show("确认要删除该信息吗？","消息提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    GuestManager.DeleteGuestById(id);
                    MessageBox.Show("删除成功");
                    this.dgvGuest.DataSource = GuestManager.GetAllGuests();
                
                }
            }
        }

    }
}
