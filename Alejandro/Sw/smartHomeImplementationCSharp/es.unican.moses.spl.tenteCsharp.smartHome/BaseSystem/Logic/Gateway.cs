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
        protected Time time = null;

        public void initBaseSystem()
        {
            this.actuators = new List<Actuator>();
            this.sensors = new List<Sensor>();
            this.floors = new List<Floor>();
        } // Gateway()

        public void initTime(Time time)
        {
            this.time = time;
        }//initTime

        public Time getTimer()
        {
            return time;
        }//getTimer

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

        public List<Actuator> getActuatorsByRoom(int id_room)
        {
            List<Actuator> actuatorsRoom = new List<Actuator>();
            for (int i = 0; i < actuators.Count; i++)
            {
                if (actuators[i].getIdRoom() == id_room) actuatorsRoom.Add(actuators[i]);
            }
            if (actuatorsRoom.Count != 0) return actuatorsRoom;
            else return null;
        }// getActuatorsByRoom

        public Floor getFloorById(int id_floor)
        {
            for (int i = 0; i < floors.Count; i++)
            {
                if (floors[i].getId() == id_floor)
                {

                    return floors[i];
                }// if
            }// for
            return null;
        }// getFloorById

        public Floor getFloorByRoom(int id_room)
        {
            Room aux=null;
            for (int i = 0; i < floors.Count; i++)
            {
                aux=floors[i].getRoomById(id_room);
                if(aux!=null){
                    return floors[i];
                }//if
            }//for
            return null;
        }

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

         /// <summary>
         ///  
         /// </summary>
        public void sayHello()
        {
            System.Console.Out.WriteLine("I am the gateway and I am ON");
        }  //say Hello

        public void initializeAll() { 
            // Pone todos los sensores y actuadores en modo funcionar
        }

        public void checkAll() { 
            // Manda un "ping" a todos los sensores y actuadores para ver que respiran
        }

        public void switchDown() { 
            // Apaga todos los sensores y actuadores
        }

      

    } // Gateway

} // namespace
