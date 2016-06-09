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
 * ������RoomTypeSettingForm
 * �������ڣ�2008-9-15
 * �����������ṩ�ͷ�������Ϣ���ù���
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
        /// �󶨿ͷ�������Ϣ�б�
        /// </summary>
        public void BindRoomTypeList()
        {
            //ȡ��DataGridView�Զ������й���
            this.dgvRoomType.AutoGenerateColumns = false;
            if (string.IsNullOrEmpty(this.txtTypeName.Text.Trim()))
                this.dgvRoomType.DataSource = RoomTypeManager.GetRoomTypeList();
            else
                this.dgvRoomType.DataSource = RoomTypeManager.GetRoomTypeListByTypeName(this.txtTypeName.Text.Trim());

        }
        /// <summary>
        /// ���ر༭��
        /// </summary>
        public void HideEditSection()
        {
            //������߶�����Ϊԭʼ��С
            this.Height = ��388;
            //���༭��������Ϊ���ɲ���״̬
            this.txtAddBedPrice.Enabled = false;
            this.txtPrice.Enabled = false;
            this.txtRemark.Enabled = false;
            this.txtType.Enabled = false;
            this.chkIsAddBed.Enabled = false;
            //���ر༭��
            this.pnlRoomTypeContent.Visible = false;
        }
        /// <summary>
        /// ��ʾ�༭��
        /// </summary>
        public void VisibleEditSection()
        {
            //���ñ༭����Ϊ�ɲ���״̬
            this.txtAddBedPrice.Enabled = true;
            this.txtPrice.Enabled = true;
            this.txtRemark.Enabled = true;
            this.txtType.Enabled = true;
            this.chkIsAddBed.Enabled = true;
            //�������ݱ༭��
            this.Height = 498;
            this.pnlRoomTypeContent.Visible = true;
        }
        /// <summary>
        /// ��ձ༭��
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
        /// �����ͷ�������Ϣ
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //ͨ���������Ƶõ������б�
            BindRoomTypeList();
        }
        /// <summary>
        /// �����ͷ�������Ϣ
        /// </summary>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            //��ʾ�༭��
            VisibleEditSection();
            //��ձ༭��
            ClearEditSection();
        }
        /// <summary>
        /// �޸Ŀͷ�������Ϣ
        /// </summary>
        private void tsbtnModify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtType.Text) && string.IsNullOrEmpty(typeID))
                MessageBox.Show("û�п��޸���Ϣ����ѡ��Ҫ�޸ĵ���Ϣ��", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //���ڱ༭��
                VisibleEditSection();
            }
        }
        /// <summary>
        /// ɾ���ͷ�������Ϣ
        /// </summary>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(typeID) && !string.IsNullOrEmpty(txtType.Text.Trim()))
            {
                //����ҵ���߼���ͷ���Ϣɾ������
                DialogResult result = MessageBox.Show("��ȷʵҪɾ������Ϣ��", "�ύ��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                   RoomTypeManager.DeleteRoomTypeByTypeId(Convert.ToInt32(typeID));
                    //ˢ�·�����Ϣ�б�
                    BindRoomTypeList();
                    MessageBox.Show("��Ϣɾ���ɹ���", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("��ѡ��Ҫɾ������Ϣ��", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// ����ͷ�������Ϣ
        /// </summary>
        private void tsbtnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtType.Text))
            {
                MessageBox.Show("�������Ʋ���Ϊ�գ�", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IsWholeNumber(this.txtPrice.Text.Trim()))
            {
                MessageBox.Show("��������Ч�ļ۸�", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IsWholeNumber(this.txtAddBedPrice.Text.Trim()))
            {
                MessageBox.Show("��������Ч�ļӴ��۸�", "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //��ʾ��Ϣ
            string message = string.Empty;
            //��ʵ������װ��Ϣ
            roomType.TypeName = this.txtType.Text.Trim();
            roomType.TypePrice = Convert.ToDecimal(this.txtPrice.Text.Trim());
            roomType.AddBedPrice = Convert.ToDecimal(this.txtAddBedPrice.Text.Trim());
            if (this.chkIsAddBed.Checked)
                roomType.IsAddBed = "��";
            else
                roomType.IsAddBed = "��";
            roomType.Remark = this.txtRemark.Text.Trim();
            //����ҵ���߼��ͷ�������Ϣ���ӹ���
            message = RoomTypeManager.AddRoomType(roomType).ToString();
            //ˢ�·�����Ϣ�б�
            BindRoomTypeList();
            //������ʾ��Ϣ��
            MessageBox.Show(message, "�ύ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// ȡ�����ݱ༭��
        /// </summary>
        private void tsbtnCancle_Click(object sender, EventArgs e)
        {
            //���ر༭��
            HideEditSection();
            //��ձ༭��
            ClearEditSection();
        }
        /// <summary>
        /// �˳�����
        /// </summary>
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// �������ʱִ��
        /// </summary>
        private void RoomTypeSettingForm_Load(object sender, EventArgs e)
        {��
            //�󶨿ͷ�������Ϣ�б�
            BindRoomTypeList();
        }
        /// <summary>
        /// �����ͷ���Ϣ�б�ĳ�л�ÿͷ����ͣɣ�
        /// </summary>
        private void dgvRoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //��ʾ�༭��
            this.pnlRoomTypeContent.Visible = true;
            this.Height = 498;
            //��ȡ�ͷ����ͣɣ�
            typeID = dgvRoomType.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            //����ҵ���߼���ͨ�����ͣɣĵõ��ͷ�������Ϣ
            roomType = RoomTypeManager.GetRoomTypeByTypeID(Convert.ToInt32(typeID));
            //�ذ�����
            this.txtType.Text = roomType.TypeName.Trim();
            this.txtPrice.Text = Convert.ToString(roomType.TypePrice);
            this.txtAddBedPrice.Text = Convert.ToString(roomType.AddBedPrice);
            if (roomType.IsAddBed.Trim() == "��")
                this.chkIsAddBed.Checked = true;
            else
                this.chkIsAddBed.Checked = false;
            this.txtRemark.Text = roomType.Remark;
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
        #endregion
    }
}