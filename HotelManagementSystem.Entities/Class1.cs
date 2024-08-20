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


    public Room()
    {
        id = 0;
        categoryID = 0;
        rateID = 0;
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

    RoomCategory()
    {
        id = 0;
        name = string.Empty;
    }

    static void Main(string[] args) { }
}
