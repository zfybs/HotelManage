using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HotelManager.Models;

namespace HotelManager.DAL
{
    public static partial class GuestService
    {
        /// <summary>
        /// 增加客人信息
        /// </summary>
        /// <param name="guest"></param>
        /// <returns>Guest</returns>
        public static Guest AddGuest(Guest guest)
        {
            string sql =
                "INSERT Guest (Name, CategoryID, Sex, Mobile, RoomID, ArriveTime, LeaveTime)" +
                "VALUES (@Name, @CategoryID, @Sex, @Mobile, @RoomID, @ArriveTime, @LeaveTime)";

            sql += " ; SELECT @@IDENTITY";

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@RoomID", guest.RoomId), //FK
					new SqlParameter("@CategoryID", guest.CategoryId), //FK
					new SqlParameter("@Name", guest.Name),
					new SqlParameter("@Sex", guest.Sex),
					new SqlParameter("@Mobile", guest.Mobile),
					new SqlParameter("@ArriveTime", guest.ArriveTime),
					new SqlParameter("@LeaveTime", guest.LeaveTime)
				};

                int newId = DBHelper.GetScalar(sql, para);
                return GetGuestByGuestID(newId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 根据客人实体类删除客人信息
        /// </summary>
        /// <param name="guest"></param>
        public static void DeleteGuest(Guest guest)
        {
            DeleteGuestByGuestID(guest.GuestId);
        }
       /// <summary>
       /// 根据客人ID删除客人信息
       /// </summary>
       /// <param name="guestID"></param>

        public static void DeleteGuestByGuestID(int guestID)
        {
            string sql = "DELETE Guest WHERE GuestID = @GuestID";

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@GuestID", guestID)
				};

                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 修改客人信息
        /// </summary>
        /// <param name="guest"></param>
        public static void ModifyGuest(Guest guest)
        {
            string sql =
                "UPDATE Guest " +
                "SET " +
                    "RoomID = @RoomID, " + //FK
                    "CategoryID = @CategoryID, " + //FK
                    "Name = @Name, " +
                    "Sex = @Sex, " +
                    "Mobile = @Mobile, " +
                    "ArriveTime = @ArriveTime, " +
                    "LeaveTime = @LeaveTime " +
                "WHERE GuestID = @GuestID";


            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@GuestID", guest.GuestId),
					new SqlParameter("@RoomID", guest.RoomId), //FK
					new SqlParameter("@CategoryID", guest.CategoryId), //FK
					new SqlParameter("@Name", guest.Name),
					new SqlParameter("@Sex", guest.Sex),
					new SqlParameter("@Mobile", guest.Mobile),
					new SqlParameter("@ArriveTime", guest.ArriveTime),
					new SqlParameter("@LeaveTime", guest.LeaveTime)
				};

                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
        /// <summary>
        /// 得到客人信息列表
        /// </summary>
        /// <returns></returns>
        public static IList<Guest> GetAllGuests()
        {
            string sqlAll = "SELECT * FROM Guest";
            return GetGuestsBySql(sqlAll);
        }
        /// <summary>
        /// 根据客人ID得到客人信息
        /// </summary>
        /// <param name="guestID"></param>
        /// <returns>Guest</returns>
        public static Guest GetGuestByGuestID(int guestID)
        {
            string sql = "SELECT * FROM Guest WHERE GuestID = @GuestID";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@GuestID", guestID));
                if (reader.Read())
                {
                    Guest guest = new Guest();

                    guest.GuestId = (int)reader["GuestID"];
                    guest.Name = (string)reader["Name"];
                    guest.Sex = (string)reader["Sex"];
                    guest.Mobile = (string)reader["Mobile"];
                    guest.ArriveTime = (DateTime)reader["ArriveTime"];
                    guest.LeaveTime = (DateTime)reader["LeaveTime"];
                    guest.RoomId = (int)reader["RoomID"]; //FK
                    guest.CategoryId = (int)reader["CategoryID"]; //FK

                    reader.Close();

                    //guest.Room = RoomService.GetRoomByRoomId(roomID);
                    //guest.Category = GuestCategoryService.GetGuestCategoryByCategoryID(categoryID);

                    return guest;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        /// <summary>
        /// 根据客人名称得到客人信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Guest</returns>
        public static Guest GetGuestByGuestName(string name)
        {
            string sql = "SELECT * FROM Guest WHERE Name = @Name";
            
            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Name", name));
                if (reader.Read())
                {
                    Guest guest = new Guest();

                    guest.GuestId = (int)reader["GuestID"];
                    guest.Name = (string)reader["Name"];
                    guest.Sex = (string)reader["Sex"];
                    guest.Mobile = (string)reader["Mobile"];
                    guest.ArriveTime = (DateTime)reader["ArriveTime"];
                    guest.LeaveTime = (DateTime)reader["LeaveTime"];
                    guest.RoomId = (int)reader["RoomID"]; //FK
                    guest.CategoryId = (int)reader["CategoryID"];
                    reader.Close();

                    //guest.Room = RoomService.GetRoomByRoomId(roomID);
                    //guest.Category = GuestCategoryService.GetGuestCategoryByCategoryID(categoryID);

                    return guest;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        /// <summary>
        /// 根据sql语句获取客人信息列表
        /// </summary>
        /// <param name="safeSql">查询sql语句</param>
        /// <returns>IList<Guest> </returns>
        private static IList<Guest> GetGuestsBySql(string safeSql)
        {
            //  string safeSql = "SELECT * FROM Guest";
            List<Guest> list = new List<Guest>();

            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql);

                foreach (DataRow row in table.Rows)
                {
                    Guest guest = new Guest();

                    guest.GuestId = (int)row["GuestID"];
                    guest.Name = (string)row["Name"];
                    guest.Sex = (string)row["Sex"];
                    guest.Mobile = (string)row["Mobile"];
                    guest.ArriveTime = (DateTime)row["ArriveTime"];
                    guest.LeaveTime = (DateTime)row["LeaveTime"];
                    guest.RoomId = (int)row["RoomID"];
                    guest.CategoryId = (int)row["CategoryID"];//FK

                    list.Add(guest);
                }

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
    }
}
