using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManager.Models
{

    [Serializable()]
    public class HotelUser
    {

        private int userID;
        private string userName = String.Empty;
        private string password = String.Empty;



        public HotelUser() { }




        public int UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }





        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }


        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

    }
}