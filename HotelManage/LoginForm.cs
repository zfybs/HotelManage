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
    public partial class LoginForm : Form
    {
        public static DialogResult result;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        ///  点击登录按钮时，设置用户名和登录类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (GetValidate())
            {
                //根据用名得到用户实体，并和输入的密码进行比较
                HotelUser user = HotelUserManager.GetHotelUser(this.txtLogInId.Text.Trim());
                string userPwd = user.Password.ToString();
                if (userPwd.Trim() == this.txtLogInPwd.Text.Trim())
                {
                    result = MessageBox.Show("登录成功", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("您的帐号或密码不正确！", "登录判断", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("请填写正确的登录信息！", "登录判断", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        public bool GetValidate()
        {
            //验证用户名是否为空
            if (string.IsNullOrEmpty(this.txtLogInId.Text.Trim()))
            {
                MessageBox.Show("请输入用户名！", "登录判断", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtLogInId.Focus();
                return false;
            }
            //验证用户密码是否为空
            if (string.IsNullOrEmpty(this.txtLogInPwd.Text.Trim()))
            {
                MessageBox.Show("请输入密码！", "登录判断", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtLogInPwd.Focus();
                return false;
            }

            return true;

        }
    }

}
