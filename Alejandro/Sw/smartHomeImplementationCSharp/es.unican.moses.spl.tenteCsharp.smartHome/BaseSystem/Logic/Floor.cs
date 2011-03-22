using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Floor
    {
        protected List<Room> rooms = null;
        protected String name;
        protected int id = 0;

        public Floor(String name)
        {
            this.name = name;
            this.rooms = new List<Room>();
        } //Floor(String)

        public Floor(String name, int id)
        {
            this.name = name;
            this.id = id;
            this.rooms = new List<Room>();
        }//Floor(String, int)
        
        public void addRoom(Room r)
        {
            rooms.Add(r);
        }//addRoom

        public int getId()
        {
            return id;
        }//getId

        public void setId(int id)
        {
            this.id = id;
        }//setId

        public String getName()
        {
            return name;
        }//getName

        public void setName(String name)
        {
            this.name = name;
        }//setName

        public List<Room> getRooms()
        {
            return this.rooms;
        }//getRooms

        public void setRooms(List<Room> value)
        {
            rooms = value;
        }//setRooms

        
        public Room getRoomById(int id)
        {
            int i = 0;
            Room roomAux = null;
            while (i < rooms.Count())
            {
                roomAux = rooms[i]; //Ojo
                i++;
                if (roomAux.getId()==id)
                {
                    return roomAux;
                }
            }
            return null;
        }//getRoomById
        
    }//Floor
}//SmartHome
