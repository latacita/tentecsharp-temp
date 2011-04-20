using System;
using System.Collections.Generic;

namespace SmartHome
{

    //=================================================================================================//
    // This class represent the central gateway of the Smart Home which process all commands           //
    //=================================================================================================//

    public partial class Gateway
    {
        //Sensor list
        protected List<Sensor> sensors = null;

        //Actuator list
        protected List<Actuator> actuators = null;

        //Floor list
        protected List<Floor> floors = null;

        //Time
        protected Time time = null;

        /// <summary>
        /// Constructor for the BaseSystem feature
        /// </summary>
        public void initBaseSystem()
        {
            this.actuators = new List<Actuator>();
            this.sensors = new List<Sensor>();
            this.floors = new List<Floor>();
        } // initBaseSystem()

        /// <summary>
        /// Method to initializate the time.
        /// </summary>
        /// <param name="time">Time object</param>
        public void initTime(Time time)
        {
            this.time = time;
        }//initTime

        #region Getters and Setters

        public Time getTimer()
        {
            return time;
        }//getTimer

        public List<Floor> getFloors()
        {
            return this.floors;
        }//getFloors

        /// <summary>
        /// Method to obtain an Actuator through the room identifier that it belongs
        /// </summary>
        /// <param name="id_room">Room identifier</param>
        /// <returns>Actuator list</returns>
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

        /// <summary>
        /// Method to obtain a Floor through its identifier
        /// </summary>
        /// <param name="id_floor">Floor identifier</param>
        /// <returns>A Floor</returns>
        public Floor getFloorById(int id_floor)
        {
            for (int i = 0; i < floors.Count; i++)
            {
                if (floors[i].getId() == id_floor)  return floors[i];                
            }// for
            return null;
        }// getFloorById

        /// <summary>
        /// Method to obtain a Floor that a room belongs
        /// </summary>
        /// <param name="id_room">Room identifier</param>
        /// <returns>Floor</returns>
        public Floor getFloorByRoom(int id_room)
        {
            Room aux = null;
            for (int i = 0; i < floors.Count; i++)
            {
                aux = floors[i].getRoomById(id_room);
                if (aux != null) return floors[i];               
            }// for
            return null;
        }// getFloorByRoom

        #endregion

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

        /// <summary>
        ///  Method to swith On all sensors and actuators
        /// </summary>        
        public void initializeAll()
        {
            for (int i = 0; i<sensors.Count; i++)
            {
                sensors[i].setStatus(true);
            }//for
            for (int i = 0; i < actuators.Count; i++)
            {
                actuators[i].setStatus(true);
            }//for            
        }//initializeAll

        /// <summary>
        /// Method to check all sensors and actuators
        /// </summary>
        public void checkAll()
        {
            for (int i = 0; i < sensors.Count; i++)
            {
                Console.WriteLine("status sensor " + sensors[i].getId() + " :" + sensors[i].getStatus());
            }// for
            for (int i = 0; i < actuators.Count; i++)
            {
                Console.WriteLine("status actuator "+actuators[i].getId()+" :"+actuators[i].getStatus());                
            }// for            
        }// checkAll

        /// <summary>
        /// Method to switch down all sensors and actuators
        /// </summary>
        public void switchDown()
        {
            for (int i = 0; i < sensors.Count; i++)
            {
                sensors[i].setStatus(false);
            }//for
            for (int i = 0; i < actuators.Count; i++)
            {
                actuators[i].setStatus(false);
            }//for            
        }//switchDown
    } // Gateway
} // namespace
