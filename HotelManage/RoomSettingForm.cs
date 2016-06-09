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
 * ������RoomSettingForm
 * �������ڣ�2008-9-15
 * �����������ṩ�ͷ���Ϣ���ù���
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
        /// ���ر༭��
        /// </summary>
        public void HideEditSection()
        {
            //������߶�����Ϊԭʼ��С
            this.Height = 417;
            //���༭��������Ϊ���ɲ���״̬
            this.txtRoomNO.Enabled = false;
            this.txtBed.Enabled = false;
            this.txtDescription.Enabled = false;
            this.txtGuestNumber.Enabled = false;
            this.cboState.Enabled = false;
            this.cboTypeName.Enabled = false;
            //���ر༭��
            this.pnlContent.Visible = false;
        }
        /// <summary>
        /// ��ʾ�༭��
        /// </summary>
        public void VisibleEditSection()
        {
            //���ñ༭����Ϊ�ɲ���״̬
            this.txtBed.Enabled = true;
            this.txtDescription.Enabled = true;
            this.txtGuestNumber.Enabled = true;
            this.cboState.Enabled = true;
            this.cboTypeName.Enabled = true;
            this.txtRoomNO.Enabled = true;
            //�������ݱ༭��
            this.Height = 531;
            this.pnlContent.Visible = true;
        }
        /// <summary>
        /// ��ձ༭��
        /// </summary>
        public void ClearEditSection()
        {
            this.txtRoomNO.Text = "";
            this.cboState.Text = "����";
            this.txtDescription.Text = "";
            this.txtBed.Text = "";
            this.txtGuestNumber.Text = "";
            this.cboTypeName.Text = "���";
            this.txtPrice.Text = "100.0000";
        }
        /// <summary>
        /// �󶨷�����Ϣ�б�
        /// </summary>
        public void BindRoomInfoList()
        {
            //ȡ��DataGridView�Զ������й���
            this.dgvRoom.AutoGenerateColumns = false;
            if (string.IsNullOrEmpty(this.txtRoomNumber.Text.Trim()))
            {
                //������Դ
                this.dgvRoom.DataSource = RoomManager.GetAllRooms();
            }
            else
                this.dgvRoom.DataSource = RoomManager.GetRoomListByRoomNumber(this.txtRoomNumber.Text.Trim());
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// ������¼
        /// </summary>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            //    ��ʾ�༭��
            VisibleEditSection();
            //    ��ձ༭��
            ClearEditSection();
        }
        /// <summary>
        /// �޸�
        /// </summary>
        private void tsbtnModify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(roomId) && string.IsNullOrEmpty(txtRoomNO.Text.Trim()))
                MessageBox.Show("û�п��޸���Ϣ����ѡ��Ҫ�޸ĵ���Ϣ��", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //���ڱ༭��
                VisibleEditSection();
            }
    
        }
        /// <summary>
        /// ɾ��
        /// </summary>
        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(roomId) && !string.IsNullOrEmpty(txtRoomNO.Text.Trim()))
            {
                //����ҵ���߼���ͷ���Ϣɾ������
                DialogResult result = MessageBox.Show("��ȷʵҪɾ������Ϣ��", "�ύ��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    if (RoomManager.DeleteRoomByRoomId(Convert.ToInt32(roomId)))
                    {
                        //ˢ�·�����Ϣ�б�
                        BindRoomInfoList();
                        MessageBox.Show("��Ϣɾ���ɹ���", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("�ÿͷ��п�����ס������ɾ��");
                }
            }
            else
            {
                MessageBox.Show("��ѡ��Ҫɾ������Ϣ��", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// ������֤
        /// </summary>
        /// <param name="strNumber">����֤��Ϣ</param>
        /// <returns></returns>
        public bool IsWholeNumber(string strNumber)
        {
            Regex notWholePattern = new Regex(@"^[-]?\d+[.]?\d*$");
            return notWholePattern.IsMatch(strNumber, 0);
        }
        /// <summary>
        /// ����
        /// </summary>
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRoomNO.Text))
            {
                MessageBox.Show("����Ų���Ϊ�գ�", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsWholeNumber(this.txtGuestNumber.Text.Trim()))
            {
                MessageBox.Show("��ס������������Ч��������", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsWholeNumber(this.txtBed.Text.Trim()))
            {
                MessageBox.Show("��λ����������Ч��������", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(this.txtDescription.Text))
            {
                MessageBox.Show("������Ϣ����Ϊ�գ�", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //��ʾ��Ϣ
            string message = string.Empty;
            //��ʵ������װ��Ϣ
            //room.Number = this.txtRoomNO.Text.Trim();
            //room.TypeID = RoomTypeManager.GetRoomTypeList(this.cboTypeName.Text.Trim());
            //room.BedNumber = Convert.ToInt32(this.txtBed.Text.Trim());
            //room.Description = this.txtDescription.Text.Trim();
            //room.State = this.cboState.Text.Trim();
            //room.GuestNumber = Convert.ToInt32(this.txtGuestNumber.Text.Trim());         
            ////����ҵ���߼��ͷ���Ϣ���ӹ���
            //message = RoomManager.AddRoom(room).ToString();
            ////ˢ�·�����Ϣ�б�
            //BindRoomInfoList();
            ////������ʾ��Ϣ��
            //MessageBox.Show(message, "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// ȡ��
        /// </summary>
        private void tsbtnCancle_Click(object sender, EventArgs e)
        {
            //    //���ر༭��
            HideEditSection();
            //    //��ձ༭��
            ClearEditSection();
        }
        /// <summary>
        /// �˳�
        /// </summary>
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// �����������������
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRoomNumber.Text.Trim()))
                MessageBox.Show("�����뷿��ţ�", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                //���ݷ���Ų�����Ϣ
                BindRoomInfoList();
        }
        /// <summary>
        /// �������ʱִ�� 
        /// </summary>
        private void RoomSettingForm_Load(object sender, EventArgs e)
        {
            //�󶨿ͷ���������
            this.cboTypeName.DataSource = RoomTypeManager.GetAllRoomTypes();
            this.cboTypeName.DisplayMember = "TypeName";
            //�󶨿ͷ���Ϣ
            BindRoomInfoList();
        }
        /// <summary>
        /// ������ѡ�ͷ����Ͷ�̬�õ��ͷ��۸�
        /// </summary>
        //private void cboTypeName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (!String.IsNullOrEmpty(this.cboTypeName.Text))
        //    {
        //        this.txtPrice.Text = RoomTypeManager.GetRoomPriceByTypeName(this.cboTypeName.Text.Trim());
        //    }
        //}
        /// <summary>
        /// ͨ�������ͷ���Ϣ�õ��ͷ��ɣ�
        /// </summary>
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //�������ݱ༭��
            this.Height = 531;
            this.pnlContent.Visible = true;
            //��ȡ˫���ͷ���Ϣ�ģɣ�
            roomId = dgvRoom.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            //����ҵ���߼���ͨ���ͷ��ɣĵõ��ͷ���Ϣ
            room = RoomManager.GetRoomByRoomId(Convert.ToInt32(roomId));
            //���ͷ���Ϣ�ذ󵽱༭�ؼ�
            this.txtRoomNO.Text = room.Number;
            this.txtGuestNumber.Text = Convert.ToString(room.GuestNumber);
            this.txtBed.Text = Convert.ToString(room.BedNumber);
            this.cboState.Text = room.State;
            this.txtDescription.Text = room.Description;
            //����ҵ���߼���ͨ���ͷ����ͣɣĵõ��ͷ�������Ϣ
            roomType = RoomTypeManager.GetRoomTypeByTypeID(room.TypeID);
            //�ذ�ͷ�������Ϣ
            this.cboTypeName.Text = roomType.TypeName;
            this.txtPrice.Text = Convert.ToString(roomType.TypePrice);
        }
        #endregion  

    }
}