using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HotelManager.Models;
using HotelManager.DAL;
/*********************************
 * 类名：RoomManager
 * 功能描述：提供客房信息业务逻辑
 * ******************************/
namespace HotelManager.BLL
{
    public static class RoomManager
    {
        #region "Public Methods"
        /// <summary>
        /// 得到客房信息集合
        /// </summary>
        /// <returns></returns>
        public static IList<Room> GetAllRooms()
        {
            return RoomService.GetAllRooms();
        }
        /// <summary>
        /// 根据客房ID得到客房实体对象
        /// </summary>
        /// <param name="roomId">客房ID</param>
        /// <returns></returns>
        public static Room GetRoomByRoomId(int roomId)
        {
         
         return RoomService.GetRoomByRoomId(roomId);
         
        }
        /// <summary>
        /// 根据客房ID删除客房信息
        /// </summary>
        /// <param name="roomId">客房ID</param>
        public static bool DeleteRoomByRoomId(int roomId)
        {
            IList<Guest> list = GuestService.GetAllGuests();
            //linq查询
            var objroom = from p in list where p.RoomId == roomId select p;
            if (objroom!=null)
            {
                return false;
            }
            else
            {
                RoomService.DeleteRoomByRoomId(roomId);
                return true;
            }
          
        }
        /// <summary>
        /// 修改客房信息
        /// </summary>
        /// <param name="room">客房实体对象</param>
        public static void ModifyRoom(Room room)
        {
           
           RoomService.ModifyRoom(room);
        }
        /// <summary>
        /// 根据房间号得到客房ID
        /// </summary>
        /// <param name="roomNo"></param>
        /// <returns></returns>
        public static int GetRoomIdByRoomNo(string roomNo)
        {
            int roomId;
            roomId = RoomService.GetRoomIdByRoomNo(roomNo);
            return roomId;
        }
        /// <summary>
        /// 新增客房信息
        /// </summary>
        /// <param name="room">客房实体对象</param>
        /// <returns></returns>
        public static int AddRoom(Room room)
        {
            try
            {
                return RoomService.AddRoom(room);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        /// <summary>
        /// 根据客房号获取客房列表
        /// </summary>
        /// <param name="roomNumber">客房号</param>
        /// <returns>IList<Room></returns>
        public static IList<Room> GetRoomListByRoomNumber(string roomNumber)
        {
           
          return RoomService.GetRoomListByRoomNumber(roomNumber);
           
        }
        #endregion
    }
}
