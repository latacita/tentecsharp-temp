using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{

    //====================================================================================================//
    // This class represents a room in the smart home                                                     //
    //====================================================================================================//

    public partial class Room
    {
        //Room name
        protected String name;

        //Room identifier
        protected int id;

        #region Constructors
        /// <summary>
        /// Constructor with 1 parameter
        /// </summary>
        /// <param name="id">Unique identifier for the room</param>
        public Room(int id)
        {
            this.id = id;
        }// Room(int)

        /// <summary>
        /// Constructor with 2 parameters
        /// </summary>
        /// <param name="name">A name for the room</param>
        /// <param name="id">Unique identifier for the room</param>
        public Room(String name, int id)
        {
            this.name = name;
            this.id = id;
        }// Room(String, int)
        #endregion

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
        #endregion
    }
}
