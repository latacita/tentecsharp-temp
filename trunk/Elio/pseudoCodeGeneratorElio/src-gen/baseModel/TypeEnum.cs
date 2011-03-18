using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public abstract class TypeEnum 
    {
       public ArrayList values = new ArrayList();

        public int value = -1; // inicializa array 

          public TypeEnum()
        {
            values = new ArrayList();
        }
    } 
}