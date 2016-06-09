using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HotelManager.Models;
using HotelManager.DAL;
/*********************************
 * ������RoomManager
 * �����������ṩ�ͷ���Ϣҵ���߼�
 * ******************************/
namespace HotelManager.BLL
{
    public static class RoomManager
    {
        #region "Public Methods"
        /// <summary>
        /// �õ��ͷ���Ϣ����
        /// </summary>
        /// <returns></returns>
        public static IList<Room> GetAllRooms()
        {
            return RoomService.GetAllRooms();
        }
        /// <summary>
        /// ���ݿͷ�ID�õ��ͷ�ʵ�����
        /// </summary>
        /// <param name="roomId">�ͷ�ID</param>
        /// <returns></returns>
        public static Room GetRoomByRoomId(int roomId)
        {
         
         return RoomService.GetRoomByRoomId(roomId);
         
        }
        /// <summary>
        /// ���ݿͷ�IDɾ���ͷ���Ϣ
        /// </summary>
        /// <param name="roomId">�ͷ�ID</param>
        public static bool DeleteRoomByRoomId(int roomId)
        {
            IList<Guest> list = GuestService.GetAllGuests();
            //linq��ѯ
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
        /// �޸Ŀͷ���Ϣ
        /// </summary>
        /// <param name="room">�ͷ�ʵ�����</param>
        public static void ModifyRoom(Room room)
        {
           
           RoomService.ModifyRoom(room);
        }
        /// <summary>
        /// ���ݷ���ŵõ��ͷ�ID
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
        /// �����ͷ���Ϣ
        /// </summary>
        /// <param name="room">�ͷ�ʵ�����</param>
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
        /// ���ݿͷ��Ż�ȡ�ͷ��б�
        /// </summary>
        /// <param name="roomNumber">�ͷ���</param>
        /// <returns>IList<Room></returns>
        public static IList<Room> GetRoomListByRoomNumber(string roomNumber)
        {
           
          return RoomService.GetRoomListByRoomNumber(roomNumber);
           
        }
        #endregion
    }
}
