using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public partial class Device
    {
        // Device identifier
        protected int id;

        public Device(int id)
        {
            this.id = id;
        }//Device(int)

        public virtual int getId()
        {
            return id;
        }//getId

        public virtual void setId(int id)
        {
            this.id = id;
        }//setId
    }//Device
}//SmartHome
