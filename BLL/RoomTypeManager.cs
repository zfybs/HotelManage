using System;
using System.Collections.Generic;
using System.Text;
using HotelManager.Models;
using HotelManager.DAL;
/*********************************
 * ������RoomTypeManager
 * �����������ṩ�ͷ�������Ϣҵ���߼�
 * ******************************/
namespace HotelManager.BLL
{
   public static class RoomTypeManager
   {
       #region "Public Methods"
       /// <summary>
       /// �õ��ͷ���Ϣ����
       /// </summary>
       /// <returns></returns>
       public static IList<RoomType> GetAllRoomTypes()
        {
           
             return   RoomTypeService.GetAllRoomTypes();
           
        }
       /// <summary>
       /// ��������ID�õ���������
       /// </summary>
       /// <param name="typeID">����ID</param>
       /// <returns></returns>
       public static string GetTypeNameByTypeID(int typeID)
       {
           
               return RoomTypeService.GetTypeNameByTypeID(typeID);
           
       }
       /// <summary>
       /// ��������ID�õ��ͷ�������Ϣʵ�����
       /// </summary>
       /// <param name="typeId">����ID</param>
       /// <returns></returns>
       public static RoomType GetRoomTypeByTypeID(int typeId)
       {
         
               return RoomTypeService.GetRoomTypeByTypeID(typeId);
           
       }
       /// <summary>
       /// �޸Ŀͷ�������Ϣ
       /// </summary>
       /// <param name="roomType"></param>
       public static void ModifyRoomType(RoomType roomType)
       {
         
               RoomTypeService.ModifyRoomType(roomType);
           

       }
       /// <summary>
       /// ��������IDɾ���ͷ�������Ϣ
       /// </summary>
       /// <param name="typeId">����ID</param>
       public static void DeleteRoomTypeByTypeId(int typeId)
       {
           
               RoomTypeService.DeleteRoomTypeByTypeId(typeId);
           
       }
       /// <summary>
       /// �����ͷ�����Ϣ
       /// </summary>
       /// <param name="roomType">����ʵ�����</param>
       /// <returns></returns>
       public static int AddRoomType(RoomType roomType)
       {

           return RoomTypeService.AddRoomType(roomType);
           
       }
       /// <summary>
       /// �����������Ƶõ�����ID
       /// </summary>
       /// <param name="typeName">��������</param>
       /// <returns></returns>
       public static int GetTypeIdTypeName(string typeName)
       {

           return RoomTypeService.GetTypeIdByTypeName(typeName);
       }
       /// <summary>
       /// �õ��ͷ�������Ϣ�б�
       /// </summary>
       /// <returns>IList<RoomType> </returns>
       public static IList<RoomType> GetRoomTypeList()
       {

           return RoomTypeService.GetAllRoomTypes();
          
       }
       /// <summary>
       /// ���ݿͷ��������Ƶõ��ͷ������б�
       /// </summary>
       /// <returns>IList<RoomType></returns>
       public static IList<RoomType> GetRoomTypeListByTypeName(string typeName)
       {

           return RoomTypeService.GetRoomTypeListByTypeName(typeName);
   
       }
       #endregion
    }
}
