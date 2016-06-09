using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HotelManager.Models;
/*********************************
 * ������RoomTypeService
 * �����������ṩ�ͷ�������Ϣ���ݷ���
 * ******************************/
namespace HotelManager.DAL
{
   public static class RoomTypeService
   {
       #region Private Members
       static string sql = string.Empty;
       #endregion

       #region "Public Methods"
       /// <summary>
       /// �õ��ͷ�������Ϣ����
       /// </summary>
       /// <returns></returns>
       public static IList<RoomType> GetAllRoomTypes()
       {
           IList<RoomType> roomTypes = new List<RoomType>();
           sql = "select * from RoomType";
           using (SqlDataReader dataReader = DBHelper.GetReader(sql))
           {
               while (dataReader.Read())
               {
                   RoomType roomType = new RoomType();
                   roomType.TypeId = Convert.ToInt32(dataReader["TypeId"]);
                   roomType.TypeName = Convert.ToString(dataReader["TypeName"]);
                   roomType.TypePrice = Convert.ToDecimal(dataReader["TypePrice"]);
                   roomType.AddBedPrice = Convert.ToDecimal(dataReader["AddBedPrice"]);
                   roomType.Remark = Convert.ToString(dataReader["Remark"]);
                   roomType.IsAddBed = Convert.ToString(dataReader["IsAddBed"]);
                   roomTypes.Add(roomType);
               }
           }
           return roomTypes;
       }
       /// <summary>
       /// ���ݿͷ��������Ƶõ��ͷ������б�
       /// </summary>
       /// <param name="typeName"></param>
       /// <returns></returns>
       public static IList<RoomType> GetRoomTypeListByTypeName(string typeName)
       {
           IList<RoomType> roomTypes = new List<RoomType>();
           sql = "select * from RoomType where TypeName='"+typeName+"'";
           using (SqlDataReader dataReader = DBHelper.GetReader(sql))
           {
               while (dataReader.Read())
               {
                   RoomType roomType = new RoomType();
                   roomType.TypeId = Convert.ToInt32(dataReader["TypeId"]);
                   roomType.TypeName = Convert.ToString(dataReader["TypeName"]);
                   roomType.TypePrice = Convert.ToDecimal(dataReader["TypePrice"]);
                   roomType.AddBedPrice = Convert.ToDecimal(dataReader["AddBedPrice"]);
                   roomType.Remark = Convert.ToString(dataReader["Remark"]);
                   roomType.IsAddBed = Convert.ToString(dataReader["IsAddBed"]);
                   roomTypes.Add(roomType);
               }
           }
           return roomTypes;
       
       }
       /// <summary>
       /// ��������ID�õ���������
       /// </summary>
       /// <param name="typeID">����ID</param>
       /// <returns></returns>
       public static string GetTypeNameByTypeID(int typeID)
       {
           string typeName = string.Empty;
           sql = "select TypeName from RoomType where TypeID ="+"'"+typeID+"'";
           using (SqlDataReader dataReader = DBHelper.GetReader(sql))
           {
               if (dataReader.Read())
               {
                   typeName = Convert.ToString(dataReader["TypeName"]);
               }
           }
           return typeName;
       }
       /// <summary>
       /// ��������ID�õ��ͷ�����ʵ�����
       /// </summary>
       /// <param name="typeId">����ID</param>
       /// <returns></returns>
       public static RoomType GetRoomTypeByTypeID(int typeId)
       {                  
           RoomType roomType = new RoomType();
           sql = "select * from RoomType where TypeID =" + "'" + typeId + "'";
           using (SqlDataReader dataReader = DBHelper.GetReader(sql))
           {
               if (dataReader.Read())
               {
                   roomType.TypeName = Convert.ToString(dataReader["TypeName"]);
                   roomType.TypePrice = Convert.ToDecimal(dataReader["TypePrice"]);
                   roomType.AddBedPrice = Convert.ToDecimal(dataReader["AddBedPrice"]);
                   roomType.Remark = Convert.ToString(dataReader["Remark"]);
                   roomType.IsAddBed = Convert.ToString(dataReader["IsAddBed"]);
               }
           }
           return roomType;
       }
       /// <summary>
       /// �޸Ŀͷ�������Ϣ
       /// </summary>
       /// <param name="roomType">����ʵ�����</param>
       public static void ModifyRoomType(RoomType roomType)
       {
           StringBuilder updateString = new StringBuilder();
           updateString.Append("update RoomType set ");
           updateString.Append("TypeName=" + "'" + roomType.TypeName + "'");
           updateString.Append(",TypePrice=" + "'"+roomType.TypePrice+"'");
           updateString.Append(",AddBedPrice=" +"'"+ roomType.AddBedPrice+"'");
           updateString.Append(",IsAddBed=" +"'"+ roomType.IsAddBed+"'");
           updateString.Append(",Remark=" + "'" + roomType.Remark + "'");
           updateString.Append(" where TypeId=" + roomType.TypeId);

           sql = updateString.ToString();
           DBHelper.ExecuteCommand(sql);
       }
       /// <summary>
       /// ��������IDɾ���ͷ�������Ϣ
       /// </summary>
       /// <param name="typeId">����ID</param>
       public static void DeleteRoomTypeByTypeId(int typeId)
       {
           sql = "delete from RoomType where TypeID=" + Convert.ToString(typeId);
           DBHelper.ExecuteCommand(sql);
       }
       /// <summary>
       /// �����ͷ�������Ϣ
       /// </summary>
       /// <param name="roomType">����ʵ�����</param>
       /// <returns>����ID</returns>
       public static int AddRoomType(RoomType roomType)
       {
           int typeId = 0;
           StringBuilder addString = new StringBuilder();
           addString.Append("insert into RoomType ( TypeName,TypePrice,AddBedPrice,IsAddBed,Remark) values(");
           addString.Append(" '" + roomType.TypeName + "'");
           addString.Append(",'" + roomType.TypePrice+"'");
           addString.Append(",'" + roomType.AddBedPrice+"'");
           addString.Append(",'" + roomType.IsAddBed+"'");
           addString.Append(",'" + roomType.Remark + "') select @@IDENTITY");
           sql = addString.ToString();
           typeId = DBHelper.GetScalar(sql);
           return typeId;
       }
       /// <summary>
       /// �����������Ƶõ�����ID
       /// </summary>
       /// <param name="typeName">��������</param>
       /// <returns></returns>
       public static int GetTypeIdByTypeName(string typeName)
       {
           int typeId =0;
           sql = "select TypeID from RoomType where TypeName='" + typeName+"'";
           using (SqlDataReader dataReader = DBHelper.GetReader(sql))
           {
               if(dataReader.Read())
               {
                   typeId = Convert.ToInt32(dataReader["TypeID"]);
               }
           }
          return typeId;
       }
       
       #endregion
   }
}
