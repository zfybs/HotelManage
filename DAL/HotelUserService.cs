using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HotelManager.Models;

namespace HotelManager.DAL
{
    public static partial class HotelUserService
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="hotelUser"></param>
        /// <returns></returns>
        public static HotelUser AddHotelUser(HotelUser hotelUser)
        {
            string sql =
                "INSERT HotelUser (UserName, Password)" +
                "VALUES (@UserName, @Password)";

            sql += " ; SELECT @@IDENTITY";

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@UserName", hotelUser.UserName),
					new SqlParameter("@Password", hotelUser.Password)
				};

                int newId = DBHelper.GetScalar(sql, para);
                return GetHotelUserByUserID(newId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 根据用户实体删除用户
        /// </summary>
        /// <param name="hotelUser"></param>

        public static void DeleteHotelUser(HotelUser hotelUser)
        {
            DeleteHotelUserByUserID(hotelUser.UserID);
        }
        /// <summary>
        /// 根据用户ID删除用户
        /// </summary>
        /// <param name="userID"></param>
        public static void DeleteHotelUserByUserID(int userID)
        {
            string sql = "DELETE HotelUser WHERE UserID = @UserID";

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@UserID", userID)
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
        /// 更新用户信息
        /// </summary>
        /// <param name="hotelUser"></param>
        public static void ModifyHotelUser(HotelUser hotelUser)
        {
            string sql =
                "UPDATE HotelUser " +
                "SET " +
                    "UserName = @UserName, " +
                    "Password = @Password " +
                "WHERE UserID = @UserID";


            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@UserID", hotelUser.UserID),
					new SqlParameter("@UserName", hotelUser.UserName),
					new SqlParameter("@Password", hotelUser.Password)
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
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public static IList<HotelUser> GetAllHotelUsers()
        {
            string sqlAll = "SELECT * FROM HotelUser";
            return GetHotelUsersBySql(sqlAll);
        }
        /// <summary>
        /// 根据用户ID获取用户
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static HotelUser GetHotelUserByUserID(int userID)
        {
            string sql = "SELECT * FROM HotelUser WHERE UserID = @UserID";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@UserID", userID));
                if (reader.Read())
                {
                    HotelUser hotelUser = new HotelUser();

                    hotelUser.UserID = (int)reader["UserID"];
                    hotelUser.UserName = (string)reader["UserName"];
                    hotelUser.Password = (string)reader["Password"];

                    reader.Close();

                    return hotelUser;
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
        /// 根据用户名获取用户
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>

        public static HotelUser GetHotelUserByUserName(string userName)
        {
            string sql = "SELECT * FROM HotelUser WHERE UserName = @UserName";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@UserName", userName));
                if (reader.Read())
                {
                    HotelUser hotelUser = new HotelUser();

                    hotelUser.UserID = (int)reader["UserID"];
                    hotelUser.UserName = (string)reader["UserName"];
                    hotelUser.Password = (string)reader["Password"];

                    reader.Close();

                    return hotelUser;
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



        private static IList<HotelUser> GetHotelUsersBySql(string safeSql)
        {
            List<HotelUser> list = new List<HotelUser>();

            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql);

                foreach (DataRow row in table.Rows)
                {
                    HotelUser hotelUser = new HotelUser();

                    hotelUser.UserID = (int)row["UserID"];
                    hotelUser.UserName = (string)row["UserName"];
                    hotelUser.Password = (string)row["Password"];

                    list.Add(hotelUser);
                }

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        //private static IList<HotelUser> GetHotelUsersBySql(string sql, params SqlParameter[] values)
        //{
        //    List<HotelUser> list = new List<HotelUser>();

        //    try
        //    {
        //        DataTable table = DBHelper.GetDataSet(sql, values);

        //        foreach (DataRow row in table.Rows)
        //        {
        //            HotelUser hotelUser = new HotelUser();

        //            hotelUser.UserID = (int)row["UserID"];
        //            hotelUser.UserName = (string)row["UserName"];
        //            hotelUser.Password = (string)row["Password"];

        //            list.Add(hotelUser);
        //        }

        //        return list;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        throw e;
        //    }

        //}

    }
}
