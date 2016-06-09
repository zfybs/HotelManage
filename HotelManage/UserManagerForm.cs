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
    public partial class UserManagerForm : Form
    {
        private HotelUser user;
        private int userid;
        public UserManagerForm()
        {
            InitializeComponent();
        }

       /// <summary>
       /// 窗体载入时
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       
        private void UserManagerForm_Load(object sender, EventArgs e)
        {
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = HotelUserManager.GetAllHotelUsers();
            this.pnlUserContent.Visible = false;
        }
/// <summary>
/// 单击新增按钮事件处理
/// </summary>

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            this.pnlUserContent.Visible = true;
            this.txtName.Text = "";
            this.txtPwd.Text = "";
           
        }
        /// <summary>
        /// 保存按钮单击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            //检验用户名和密码框是否为空
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("用户名不能为空！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(this.txtPwd.Text))
            {
                MessageBox.Show("密码不能为空！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //实体对象赋值
            user.UserName = this.txtName.Text.Trim();
            user.Password = this.txtPwd.Text.Trim();

            if (HotelUserManager.AddHotelUser(user))
            {
                //刷新显示
                this.dgvUser.DataSource = HotelUserManager.GetAllHotelUsers();
                MessageBox.Show("保存成功");
            }
            else
                MessageBox.Show("用户已经存在");
        }
/// <summary>
/// 修改用户信息
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void tsbtnModify_Click(object sender, EventArgs e)
        {

            if (userid == 0)
            {
                MessageBox.Show("请选择修改项目");
                return;
            
            }
            user.UserName = this.txtName.Text.Trim();
            user.Password = this.txtPwd.Text.Trim();
            user.UserID = userid;
            HotelUserManager.ModifyHotelUser(user);//调用业务层添加用户方法
            this.dgvUser.DataSource = HotelUserManager.GetAllHotelUsers();
            MessageBox.Show("修改成功");

        }
        /// <summary>
        /// 取消按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnCancle_Click(object sender, EventArgs e)
        {
            //隐藏编辑区
            this.pnlUserContent.Visible = false;
            //清空编辑区
            this.txtName.Text = "";
            this.txtPwd.Text = "";
        }
        /// <summary>
        /// 退出按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 删除按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (userid!=0)
            {
                //调用业务逻辑层用户信息删除功能
                DialogResult result = MessageBox.Show("您确实要删除此信息吗？", "提交提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    HotelUserManager.DeleteHotelUserById(userid);
                    //刷新用户信息列表
                    this.dgvUser.DataSource = HotelUserManager.GetAllHotelUsers();
                    MessageBox.Show("信息删除成功！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //显示编辑区
        //    this.pnlUserContent.Visible = true;
        //    //获取用户ＩＤ
        //    userid = Convert.ToInt32(this.dgvUser.Rows[e.RowIndex].Cells["userID"].Value);
        //    //调用业务逻辑层通过类型ＩＤ得到用户信息
        //    user = HotelUserManager.GetHotelUserByUserID(userid);
        //    //回绑数据
        //    this.txtName.Text = user.UserName.ToString();
        //    this.txtPwd.Text = user.Password.ToString();
        //}
        /// <summary>
        /// DataGridView控件的click事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUser_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //显示编辑区
            this.pnlUserContent.Visible = true;
            //获取用户ＩＤ
            userid = Convert.ToInt32(this.dgvUser.Rows[e.RowIndex].Cells["id"].Value);
            //调用业务逻辑层通过类型ＩＤ得到用户信息
            user = HotelUserManager.GetHotelUserByUserID(userid);
            //回绑数据
            this.txtName.Text = user.UserName.ToString();
            this.txtPwd.Text = user.Password.ToString();
        }
    }
}
