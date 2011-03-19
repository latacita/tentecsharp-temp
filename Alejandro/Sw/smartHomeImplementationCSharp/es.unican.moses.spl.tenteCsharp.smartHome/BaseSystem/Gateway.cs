using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class represent the central gateway of the Smart Home which process all commands           //
    //=================================================================================================//

    public partial class Gateway
    {
        protected List<Sensor> sensors = null;
        protected List<Actuator> actuators = null;
        protected List<Floor> floors = null;

        public void initBaseSystem()
        {
            this.actuators = new List<Actuator>();
            this.sensors = new List<Sensor>();
            this.floors = new List<Floor>();
        } // Gateway()

        public void addSensor(Sensor s)
        {
            this.sensors.Add(s);
        } // addSensor

        public void addActuator(Actuator a)
        {
            this.actuators.Add(a);
        } // addActuator

        public void addFloor(Floor f)
        {
            this.floors.Add(f);
        }// addFloor

        public List<Floor> getFloors()
        {
            return this.floors;
        }//getFloors

        // Class methods
        public void emergence(Sensor s, double value)
        {
            System.Console.Out.WriteLine("Sensor " + s.getId() + " has notified anormal situation with value " + value);
        } // emergence

        // Pre: actuator list must be not null
        // TODO: Change return value by an exception
        public bool changeValue(int id, double value)
        {

            bool result = false;
            Actuator ac = null;

            List<Actuator>.Enumerator it = actuators.GetEnumerator();

            while ((it.MoveNext() == true) && (ac == null))
            {
                if (it.Current.getId() == id)
                {
                    ac = it.Current;
                } // if
            } // while

            if (ac != null)
            {
                ac.setValue(value);
                result = true;
            } // if

            return result;

        } // changeValue

        public void sayHello()
        {
            System.Console.Out.WriteLine("I am the gateway and I am ON");
        }  //say Hello


    } // Gateway

} // namespace
