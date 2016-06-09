using System;
using System.Collections.Generic;
using System.Text;
using HotelManager.Models;
using HotelManager.DAL;
/*********************************
 * 类名：RoomTypeManager
 * 功能描述：提供客房类型信息业务逻辑
 * ******************************/
namespace HotelManager.BLL
{
   public static class RoomTypeManager
   {
       #region "Public Methods"
       /// <summary>
       /// 得到客房信息集合
       /// </summary>
       /// <returns></returns>
       public static IList<RoomType> GetAllRoomTypes()
        {
           
             return   RoomTypeService.GetAllRoomTypes();
           
        }
       /// <summary>
       /// 根据类型ID得到类型名称
       /// </summary>
       /// <param name="typeID">类型ID</param>
       /// <returns></returns>
       public static string GetTypeNameByTypeID(int typeID)
       {
           
               return RoomTypeService.GetTypeNameByTypeID(typeID);
           
       }
       /// <summary>
       /// 根据类型ID得到客房类型信息实体对象
       /// </summary>
       /// <param name="typeId">类型ID</param>
       /// <returns></returns>
       public static RoomType GetRoomTypeByTypeID(int typeId)
       {
         
               return RoomTypeService.GetRoomTypeByTypeID(typeId);
           
       }
       /// <summary>
       /// 修改客房类型信息
       /// </summary>
       /// <param name="roomType"></param>
       public static void ModifyRoomType(RoomType roomType)
       {
         
               RoomTypeService.ModifyRoomType(roomType);
           

       }
       /// <summary>
       /// 根据类型ID删除客房类型信息
       /// </summary>
       /// <param name="typeId">类型ID</param>
       public static void DeleteRoomTypeByTypeId(int typeId)
       {
           
               RoomTypeService.DeleteRoomTypeByTypeId(typeId);
           
       }
       /// <summary>
       /// 新增客房类信息
       /// </summary>
       /// <param name="roomType">类型实体对象</param>
       /// <returns></returns>
       public static int AddRoomType(RoomType roomType)
       {

           return RoomTypeService.AddRoomType(roomType);
           
       }
       /// <summary>
       /// 根据类型名称得到类型ID
       /// </summary>
       /// <param name="typeName">类型名称</param>
       /// <returns></returns>
       public static int GetTypeIdTypeName(string typeName)
       {

           return RoomTypeService.GetTypeIdByTypeName(typeName);
       }
       /// <summary>
       /// 得到客房类型信息列表
       /// </summary>
       /// <returns>IList<RoomType> </returns>
       public static IList<RoomType> GetRoomTypeList()
       {

           return RoomTypeService.GetAllRoomTypes();
          
       }
       /// <summary>
       /// 根据客房类型名称得到客房类型列表
       /// </summary>
       /// <returns>IList<RoomType></returns>
       public static IList<RoomType> GetRoomTypeListByTypeName(string typeName)
       {

           return RoomTypeService.GetRoomTypeListByTypeName(typeName);
   
       }
       #endregion
    }
}
