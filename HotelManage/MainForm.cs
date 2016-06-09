using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class MainForm : Form
    {
        #region Public Methods
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 显示客房类型设置窗体
        /// </summary>
        private void SetRoomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomTypeSettingForm roomTypeSetting = new RoomTypeSettingForm();
            roomTypeSetting.Parent = this;
            roomTypeSetting.ShowDialog();
        }
        private void RoomStateManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        //显示客人管理窗体
        private void tsmiManageGuest_Click(object sender, EventArgs e)
        {
            GuestManageForm guest = new GuestManageForm();
             guest.ShowDialog();
        }
        /// <summary>
        /// 显示客房类型信息设置窗体
        /// </summary>
        private void tsmiSetRoomType_Click(object sender, EventArgs e)
        {
            RoomTypeSettingForm roomType = new RoomTypeSettingForm();
            roomType.Parent = this;
            roomType.ShowDialog();
        }
        /// <summary>
        /// 显示客房信息设置窗体
        /// </summary>
        private void tsmiSetRoom_Click(object sender, EventArgs e)
        {
            RoomSettingForm room = new RoomSettingForm();
            room.Parent = this;
            room.ShowDialog();
        }            
        #endregion
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            if (LoginForm.result == DialogResult.OK)
            {
                this.tsmiSetRoom.Enabled = true;
                this.tsmiManageGuest.Enabled = true;
                this.tsmiSetRoomType.Enabled = true;
                this.tsmiUserManage.Enabled = true;
            }
            else
            {
                this.tsmiSetRoom.Enabled = false;
                this.tsmiManageGuest.Enabled = false;
                this.tsmiSetRoomType.Enabled = false;
                this.tsmiUserManage.Enabled = false;
                this.tsmiExit.Enabled = true;
            }

        }
        /// <summary>
        /// 显示用户管理窗体
        /// </summary>
      
        private void tsmiUserManage_Click(object sender, EventArgs e)
        {
            UserManagerForm user = new UserManagerForm();
            user.MdiParent = this;
            user.Show();

        }
    
    }
}