using System;
using System.Collections.Generic;
using System.Text;
/*********************************
 * ������RoomType
 * �������ڣ�2008-9-14
 * �����������ṩ���������Ϣʵ����
 * ******************************/
namespace HotelManager.Models
{
   [Serializable]
   public class RoomType
   {
       #region Protected Members
       protected int typeId;
       protected string typeName = String.Empty;
       protected decimal typePrice;
       protected decimal addBedPrice;
       protected string isAddBed;
       protected string remark;
       #endregion

       #region Public Methods
       public RoomType()
       {
       }
       #endregion

       #region Public Properties
       public int TypeId
       {
           get { return typeId; }
           set { typeId = value; }
       }

       public string TypeName
       {
           get { return typeName; }
           set { typeName = value; }
       }

       public decimal TypePrice
       {
           get { return typePrice; }
           set { typePrice = value; }
       }

       public decimal AddBedPrice
       {
           get { return addBedPrice; }
           set { addBedPrice = value; }
       }

       public string IsAddBed
       {
           get { return isAddBed; }
           set { isAddBed = value; }
       }
       public string Remark
       {
           get { return remark; }
           set { remark = value; }
       }
       #endregion
    }
}
