using System;
using System.Collections.Generic;
using System.Text;
using HotelManager.DAL;
using HotelManager.Models;

namespace HotelManager.BLL
{

    public static partial class HotelUserManager
    {
        //新增用户
        public static bool AddHotelUser(HotelUser hotelUser)
        {
            //判断用户是否存在
            HotelUser user = HotelUserService.GetHotelUserByUserName(hotelUser.UserName);
            if (user == null)
            {
                HotelUserService.AddHotelUser(hotelUser);
                return true;
            }
            else
                return false;
         
        }
        //删除用户
        public static void DeleteHotelUser(HotelUser hotelUser)
        {
            HotelUserService.DeleteHotelUser(hotelUser);
        }
        //根据用户ID删除用户
        public static void DeleteHotelUserById(int userID)
        {
            HotelUserService.DeleteHotelUserByUserID(userID);
        }
        //修改用户
        public static void ModifyHotelUser(HotelUser hotelUser)
        {
            HotelUserService.ModifyHotelUser(hotelUser);
        }
        //得到用户列表
        public static IList<HotelUser> GetAllHotelUsers()
        {
            return HotelUserService.GetAllHotelUsers();
        }
        //根据用户ID得到用户
        public static HotelUser GetHotelUserByUserID(int userID)
        {
            return HotelUserService.GetHotelUserByUserID(userID);
        }
        //根据用户名得到用户
        public static HotelUser GetHotelUser(string userName)
        {
            return HotelUserService.GetHotelUserByUserName(userName);
        }
    }
}
