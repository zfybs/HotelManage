using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HotelManager.Models;
/*********************************
 * 类名：RoomService
 * 功能描述：提供客房信息数据访问
 * ******************************/

namespace HotelManager.DAL
{
    public static class RoomService
    {
        #region Private Members
        static string sql = string.Empty;
        #endregion

        #region Public Methods
        /// <summary>
        /// 得到客房信息集合
        /// </summary>
        /// <returns></returns>
        public static IList<Room> GetAllRooms()
        {
            IList<Room> rooms = new List<Room>();
            sql = "select * from Room";
            using (SqlDataReader dataReader = DBHelper.GetReader(sql))
            {
                while (dataReader.Read())
                {
                    Room room = new Room();
                    room.RoomId = Convert.ToInt32(dataReader["RoomId"]);
                    room.TypeID = Convert.ToInt32(dataReader["TypeID"]);
                    room.Number = Convert.ToString(dataReader["Number"]);
                    room.State = Convert.ToString(dataReader["State"]);
                    room.Description = Convert.ToString(dataReader["Description"]);
                    room.BedNumber = Convert.ToInt32(dataReader["BedNumber"]);
                    room.GuestNumber = Convert.ToInt32(dataReader["GuestNumber"]);
                    rooms.Add(room);
                }
            }
            return rooms;
        }
        /// <summary>
        /// 根据客房ID得到客房信息实体对象
        /// </summary>
        /// <param name="roomId">客房ID</param>
        /// <returns></returns>
        public static Room GetRoomByRoomId(int roomId)
        {               
            Room room = new Room();
            sql = "select * from Room where RoomId ="+ roomId.ToString();
            using (SqlDataReader dataReader = DBHelper.GetReader(sql))
            {
                if (dataReader.Read())
                {
                    room.Number = Convert.ToString(dataReader["Number"]);
                    room.TypeID = Convert.ToInt32(dataReader["TypeID"]);
                    room.State = Convert.ToString(dataReader["State"]);
                    room.Description = Convert.ToString(dataReader["Description"]);
                    room.BedNumber = Convert.ToInt32(dataReader["BedNumber"]);
                    room.GuestNumber = Convert.ToInt32(dataReader["GuestNumber"]);
                }
            }
            return room;
        }
        
        /// <summary>
        /// 根据客房ID删除客房信息
        /// </summary>
        /// <param name="roomId">客房ID</param>
        public static void DeleteRoomByRoomId(int roomId)
        {
            sql = "delete from Room where RoomID=" + Convert.ToString(roomId);
            DBHelper.ExecuteCommand(sql);
        }
        /// <summary>
        /// 修改客房信息
        /// </summary>
        /// <param name="room">客房信息实体对象</param>
        public static void ModifyRoom(Room room)
        {
            StringBuilder updateString = new StringBuilder();
            updateString.Append("update Room set ");
            updateString.Append("Number="+"'"+room.Number+"'");
            updateString.Append(",TypeID=" + room.TypeID);
            updateString.Append(",BedNumber=" + room.BedNumber);
            updateString.Append(",GuestNumber=" + room.GuestNumber);
            updateString.Append(",State=" + "'" + room.State + "'");
            updateString.Append(",Description=" + "'" + room.Description + "'");
            updateString.Append(" where RoomId=" + room.RoomId );

            sql = updateString.ToString();
            DBHelper.ExecuteCommand(sql);
        }
        /// <summary>
        /// 根据客房类型名称得到客房类型列表
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static IList<Room> GetRoomListByRoomNumber(string roomNumber)
        {
            IList<Room> room = new List<Room>();
            sql = "select * from Room where Number='" + roomNumber + "'";
            using (SqlDataReader dataReader = DBHelper.GetReader(sql))
            {
                while (dataReader.Read())
                {
                    Room objroom = new Room();
                    objroom.RoomId = Convert.ToInt32(dataReader["RoomId"]);
                    objroom.TypeID = Convert.ToInt32(dataReader["TypeID"]);
                    objroom.Number = Convert.ToString(dataReader["Number"]);
                    objroom.State = Convert.ToString(dataReader["State"]);
                    objroom.Description = Convert.ToString(dataReader["Description"]);
                    objroom.BedNumber = Convert.ToInt32(dataReader["BedNumber"]);
                    objroom.GuestNumber = Convert.ToInt32(dataReader["GuestNumber"]);
                    room.Add(objroom);
                }
            }
            return room;

        }
        /// <summary>
        /// 根据房间号得到客房ID
        /// </summary>
        /// <param name="roomNo">房间号</param>
        /// <returns></returns>
        public static int GetRoomIdByRoomNo(string roomNo)
        {
            int roomId=0;
            sql = "select RoomID from Room where Number=" + "'" + roomNo + "'";
            using (SqlDataReader dataReader = DBHelper.GetReader(sql))
            {
                if (dataReader.Read())
                {
                    roomId = Convert.ToInt32(dataReader["RoomID"]);
                }
            }
            return roomId;
        }
        /// <summary>
        /// 新增客房信息
        /// </summary>
        /// <param name="room">客房信息实体对象</param>
        /// <returns>客房ID</returns>
        public static int AddRoom(Room room)
        {
            int roomId = 0;
            StringBuilder addString = new StringBuilder();
            addString.Append("insert into Room ( Number,TypeID,BedNumber,GuestNumber,State,Description) values(");
            addString.Append(" '" + room.Number + "'");
            addString.Append("," + room.TypeID);
            addString.Append("," + room.BedNumber);
            addString.Append("," + room.GuestNumber);
            addString.Append(",'" + room.State + "'");
            addString.Append(",'" + room.Description + "') select @@IDENTITY");
            sql = addString.ToString();
            roomId =DBHelper.GetScalar(sql);
            return roomId;
        }
        #endregion
    }
}
