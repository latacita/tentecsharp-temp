using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Room
    {
        protected String name;
        protected int id;

        public Room(String name)
        {
            this.name = name;
        }//Room

        public Room(String name, int id)
        {
            this.name = name;
            this.id = id;
        }//Room

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
    }
}
