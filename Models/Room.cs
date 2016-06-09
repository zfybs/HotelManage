using System;
using System.Collections.Generic;
using System.Text;
/*********************************
 * ������Room
 * �������ڣ�2008-9-14
 * �����������ṩ������Ϣʵ����
 * ******************************/
namespace HotelManager.Models
{
    [Serializable]
   public class Room
   {
       #region Protected Members
       protected int roomId;
       protected string number = String.Empty;
       protected int typeID;
       protected int bedNumber;
       protected string description = String.Empty;
       protected string state = String.Empty;
       protected int guestNumber;
       #endregion

        #region Public Methods
        public Room()
		{
        }
        #endregion

        #region Public Properties
        public int RoomId
		{
            get { return roomId; }
            set { roomId = value; }
		}
		
		public string Number
		{
			get {return number;}
			set {number = value;}
		}

		public int TypeID
		{
			get {return typeID;}
			set {typeID = value;}
		}

		public int BedNumber
		{
			get {return bedNumber;}
			set {bedNumber = value;}
		}

		public string Description
		{
			get {return description;}
			set {description = value;}
		}

		public string State
		{
			get {return state;}
			set {state = value;}
		}

		public int GuestNumber
		{
			get {return guestNumber;}
			set {guestNumber = value;}
		}
		#endregion	
    }
}
