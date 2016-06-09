using System;
using System.Collections.Generic;
using System.Text;
using HotelManager.DAL;
using HotelManager.Models;

namespace HotelManager.BLL
{

    public static partial class GuestManager
    {
        /// <summary>
        /// 增加客人信息
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        public static Guest AddGuest(Guest guest)
        {
            return GuestService.AddGuest(guest);
        }
        /// <summary>
        /// 删除客人信息
        /// </summary>
        /// <param name="guest"></param>
        public static void DeleteGuest(Guest guest)
        {
            GuestService.DeleteGuest(guest);
        }
        /// <summary>
        /// 根据客人ID删除客人信息
        /// </summary>
        /// <param name="guestID"></param>
        public static void DeleteGuestById(int guestID)
        {
            GuestService.DeleteGuestByGuestID(guestID);
          }
        /// <summary>
        /// 修改客人信息
        /// </summary>
        /// <param name="guest"></param>
        public static void ModifyGuest(Guest guest)
        {
            GuestService.ModifyGuest(guest);
        }
        /// <summary>
        /// 获得客人信息列表
        /// </summary>
        /// <returns></returns>
        public static IList<Guest> GetAllGuests()
        {
            return GuestService.GetAllGuests();
        }
        /// <summary>
        /// 通过客人姓名获得客人信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Guest GetGuestByGuestName(string name)
        {
            return GuestService.GetGuestByGuestName(name);
        }
        public static Guest GetGuestByID(int id)
        {
            return GuestService.GetGuestByGuestID(id);
        }

    }
}
