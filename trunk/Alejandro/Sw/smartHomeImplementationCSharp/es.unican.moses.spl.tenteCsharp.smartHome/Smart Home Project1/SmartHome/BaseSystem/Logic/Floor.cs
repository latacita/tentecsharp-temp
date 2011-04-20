using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    //====================================================================================================//
    // This class represents a floor in the smart home                                                    //
    //====================================================================================================//

    public partial class Floor
    {

        //Room list
        protected List<Room> rooms = null;
        //Floor name
        protected String name;
        //Floor identifier
        protected int id = 0;

        #region Constructor

        /// <summary>
        /// Constructor with 1 parameter
        /// </summary>
        /// <param name="name">Floor name</param>
        public Floor(String name)
        {
            this.name = name;
            this.rooms = new List<Room>();
        } //Floor(String)

        /// <summary>
        /// Constructor with 2 parameters
        /// </summary>
        /// <param name="name">Floor name</param>
        /// <param name="id">Identifier for the floor</param>
        public Floor(String name, int id)
        {
            this.name = name;
            this.id = id;
            this.rooms = new List<Room>();
        }//Floor(String, int)
        #endregion

        /// <summary>
        /// Method to add a new room in the current floor
        /// </summary>
        /// <param name="r">Room</param>
        public void addRoom(Room r)
        {
            rooms.Add(r);
        }//addRoom(Room)
        #region Getters and Setters
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
                roomAux = rooms[i];
                i++;
                if (roomAux.getId() == id)
                {
                    return roomAux;
                }// if
            }// while
            return null;
        }// getRoomById
        #endregion
    }//Floor
}//SmartHome
