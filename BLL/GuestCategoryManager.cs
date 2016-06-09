using System;
using System.Collections.Generic;
using System.Text;
using HotelManager.DAL;
using HotelManager.Models;
namespace HotelManager.BLL
{
    public static partial class GuestCategoryManager
    {
        public static GuestCategory AddGuestCategory(GuestCategory guestCategory)
        {
            return GuestCategoryService.AddGuestCategory(guestCategory);
        }

        public static void DeleteGuestCategory(GuestCategory guestCategory)
        {
            GuestCategoryService.DeleteGuestCategory(guestCategory);
        }

        public static void DeleteGuestCategoryById(int categoryID)
        {
            GuestCategoryService.DeleteGuestCategoryByCategoryID(categoryID);
        }

        public static void ModifyGuestCategory(GuestCategory guestCategory)
        {
            GuestCategoryService.ModifyGuestCategory(guestCategory);
        }
        /// <summary>
        /// 获取客人类型列表
        /// </summary>
        /// <returns>IList<GuestCategory></returns>
        public static IList<GuestCategory> GetAllGuestCategories()
        {
            return GuestCategoryService.GetAllGuestCategories();
        }
        /// <summary>
        /// 根据类型ID获取客人类型实体
        /// </summary>
        /// <param name="categoryID">类型ID</param>
        /// <returns>GuestCategory</returns>
        public static GuestCategory GetGuestCategoryByCategoryID(int categoryID)
        {
            return GuestCategoryService.GetGuestCategoryByCategoryID(categoryID);
        }

    }
}
