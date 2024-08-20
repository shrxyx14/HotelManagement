using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities
{
    public class Hotel
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int categoryId;  // Foreign key to HotelCategory
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        private string location;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        private string contactDetails;
        public string ContactDetails
        {
            get { return contactDetails; }
            set { contactDetails = value; }
        }

        private string owner;
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public Hotel(int id, int categoryId, string location, string contactDetails,string owner)
        {
            Id = id;
            CategoryId = categoryId;
            Location = location;
            ContactDetails = contactDetails;
            Owner = owner;
        }
    }

    public class HotelCategory
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { Id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public HotelCategory(int id,string name)
            {
                Id= id;
            Name= name;
            }
            
    }


    public class Room
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int categoryID;
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private int rateID;

        public int RateID
        {
            get { return rateID; }
            set { rateID = value; }
        }


        public Room(int id,int categoryid,int rateid)
        {
            ID= id;
            CategoryID = categoryid;
            RateID = rateid;
        }

    }

    public class RoomCategory
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        RoomCategory(int id,string name)
        {
            ID = id;
            Name = name;
        }


    }

    public class RoomRates
    {

        public int Id { get; set; }
        public double Rate { get; set; }

        public String UpdateDate { get; set; }
        public int RoomCategoryId { get; set; }

        public RoomRates(int id, double rate, string updateDate, int roomCategoryId)
        {
            Id = id;
            Rate = rate;
            UpdateDate = updateDate;
            RoomCategoryId = roomCategoryId;
        }
    }
    public class RoomInventory
    {
        public int CategoryId { get; set; }
        public int AvailabilityOfRoom { get; set; }

        public RoomInventory(int categoryId, int availabilityOfRoom)
        {
            CategoryId = categoryId;
            AvailabilityOfRoom = availabilityOfRoom;
        }
    }



}


