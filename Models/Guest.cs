using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Data;
using System.Data.SqlTypes;

namespace HotelManager.Models
{
    [Serializable]
    
    public class Guest
    {
        private int guestId;

        public int GuestId
        {
            get { return guestId; }
            set { guestId = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int categoryId;

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        private int roomId;

        public int RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }

          private DateTime arriveTime;

        public DateTime ArriveTime
        {
            get { return arriveTime; }
            set { arriveTime = value; }
        }
        private DateTime leaveTime;

        public DateTime LeaveTime
        {
            get { return leaveTime; }
            set { leaveTime = value; }
        }
    }
}
