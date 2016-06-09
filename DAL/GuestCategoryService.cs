using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HotelManager.Models;

namespace HotelManager.DAL
{
    public static partial class GuestCategoryService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="guestCategory"></param>
        /// <returns></returns>
        public static GuestCategory AddGuestCategory(GuestCategory guestCategory)
        {
            string sql =
                "INSERT GuestCategory (CategoryName)" +
                "VALUES (@CategoryName)";

            sql += " ; SELECT @@IDENTITY";

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@CategoryName", guestCategory.CategoryName)
				};

                int newId = DBHelper.GetScalar(sql, para);
                return GetGuestCategoryByCategoryID(newId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public static void DeleteGuestCategory(GuestCategory guestCategory)
        {
            DeleteGuestCategoryByCategoryID(guestCategory.CategoryID);
        }

        public static void DeleteGuestCategoryByCategoryID(int categoryID)
        {
            string sql = "DELETE GuestCategory WHERE CategoryID = @CategoryID";

            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@CategoryID", categoryID)
				};

                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public static void ModifyGuestCategory(GuestCategory guestCategory)
        {
            string sql =
                "UPDATE GuestCategory " +
                "SET " +
                    "CategoryName = @CategoryName " +
                "WHERE CategoryID = @CategoryID";


            try
            {
                SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@CategoryID", guestCategory.CategoryID),
					new SqlParameter("@CategoryName", guestCategory.CategoryName)
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
        /// 获取客户类型列表
        /// </summary>
        /// <returns>IList<GuestCategory></returns>
        public static IList<GuestCategory> GetAllGuestCategories()
        {
            string sqlAll = "SELECT * FROM GuestCategory";//查询sql语句
            return GetGuestCategoriesBySql(sqlAll);//获取数据
        }
/// <summary>
/// 根据ID获取实体对象
/// </summary>
/// <param name="categoryID"></param>
/// <returns></returns>
        public static GuestCategory GetGuestCategoryByCategoryID(int categoryID)
        {
            string sql = "SELECT * FROM GuestCategory WHERE CategoryID = @CategoryID";//sql语句

            try
            {
                using (SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@CategoryID", categoryID)))
                {
                    if (reader.Read())
                    {
                        GuestCategory guestCategory = new GuestCategory();

                        guestCategory.CategoryID = (int)reader["CategoryID"];
                        guestCategory.CategoryName = (string)reader["CategoryName"];
                        return guestCategory;
                    }
                    else
                    {
                         return null;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        /// <summary>
        /// 根据SQL语句获取客人类型列表
        /// </summary>
        /// <param name="safeSql">查询sql语句</param>
        /// <returns>IList<GuestCategory></returns>
        private static IList<GuestCategory> GetGuestCategoriesBySql(string safeSql)
        {
            List<GuestCategory> list = new List<GuestCategory>();//创建泛型集合

            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql);//执行sql语句
                //遍历数据表记录获取数据
                foreach (DataRow row in table.Rows)
                {
                    GuestCategory guestCategory = new GuestCategory();

                    guestCategory.CategoryID = (int)row["CategoryID"];
                    guestCategory.CategoryName = (string)row["CategoryName"];

                    list.Add(guestCategory); //添加到集合对象中
                }

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        //private static IList<GuestCategory> GetGuestCategoriesBySql(string sql, params SqlParameter[] values)
        //{
        //    List<GuestCategory> list = new List<GuestCategory>();

        //    try
        //    {
        //        DataTable table = DBHelper.GetDataSet(sql, values);

        //        foreach (DataRow row in table.Rows)
        //        {
        //            GuestCategory guestCategory = new GuestCategory();

        //            guestCategory.CategoryID = (int)row["CategoryID"];
        //            guestCategory.CategoryName = (string)row["CategoryName"];

        //            list.Add(guestCategory);
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