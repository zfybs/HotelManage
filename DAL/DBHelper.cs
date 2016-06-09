using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/*********************************
 * ������DBHelper
 * �����������ṩ�������ݷ��ʹ���
 * ******************************/

namespace HotelManager.DAL
{
    public static class DBHelper
    {
        //���ݿ���������
        private static SqlConnection connection;
        public static SqlConnection Connection
        {
            get
            {
                string connectionString = @"Data Source=(local)\SQLZFY;AttachDbFilename=F:\Software\Programming\VB.NET\zengfy�ʼ�\�����ѧC# Դ����\C17\HotelManage\db\HotelManager.mdf;Integrated Security=True;User Instance=True";
                //string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=HotelManager;uid=sa;pwd=1234";
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }
        /// <summary>
        /// ִ���޲�SQL���
        /// </summary>
        public static int ExecuteCommand(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            int result = cmd.ExecuteNonQuery();
            return result;
        }

        /// <summary>
        /// ִ�д���SQL���
        /// </summary>
        public static int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// ִ���޲�SQL��䣬������ִ�м�¼��
        /// </summary>
        public static int GetScalar(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }
        /// <summary>
        /// ִ���в�SQL��䣬������ִ�м�¼��
        /// </summary>
        public static int GetScalar(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }
        /// <summary>
        /// ִ���޲�SQL��䣬������SqlDataReader
        /// </summary>
        public static SqlDataReader GetReader(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// ִ���в�SQL��䣬������SqlDataReader
        /// </summary>
        public static SqlDataReader GetReader(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// ִ���в�SQL��䣬����DataTable
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static DataTable GetDataSet(string safeSql)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
