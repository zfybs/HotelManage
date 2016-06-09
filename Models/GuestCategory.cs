using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManager.Models
{

    [Serializable()]
    public class GuestCategory
    {

        private int categoryID;
        private string categoryName = String.Empty;



        public GuestCategory() { }




        public int CategoryID
        {
            get { return this.categoryID; }
            set { this.categoryID = value; }
        }





        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }

    }
}
