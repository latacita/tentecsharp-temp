using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class TypeComponent
    {
        public String id;

        public TypeComponent(String id)
        {
            this.id = id;
        }
        public String getID()
        {
            return id;
        }
        //método que inicializa el componente
        public void init() { }
    }
}