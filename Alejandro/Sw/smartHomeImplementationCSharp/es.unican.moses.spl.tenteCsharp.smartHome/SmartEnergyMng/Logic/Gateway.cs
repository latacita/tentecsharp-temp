using System;
using System.Collections.Generic;
using System.Xml;

namespace SmartHome
{

    //=================================================================================================//
    // This class represent the central gateway of the Smart Home which process all commands           //
    // This file only contains the functionality related to the SmartEnergyMng feature                 //
    //=================================================================================================//

    public partial class Gateway : ITimeObserver, ISubjectGatewaySmartEnergy
    {
        protected bool statusSmartEnergyMng = false;
        protected List<String> timeTables = new List<String>();
        protected Dictionary<int, List<double>> dictTimesTables = new Dictionary<int, List<double>>();
        protected List<Double> emptyTime = new List<double>();
        protected int id_window;
        //List of observers
        ICollection<IGatewayGUISmartEnergyObserver> observersGatewaySmartEnergy = new LinkedList<IGatewayGUISmartEnergyObserver>();
       
       
        #region Constructor

        public void initSmartEnergyMng()
        {
            smartEnergy_readTimeTables();
            time.registerObserver(this);
            
        }// initSmartEnergyMng

        #endregion Constructor

        /// <summary>
        ///     Checks the current timer to check if the house is busy or empty to 
        ///     switch on/off heaters and devices
        /// </summary>
        public void smartEnergy_checkTime(int hour, int minutes)
        {
            String t = hour.ToString() + "," + minutes.ToString();
            double time = Convert.ToDouble(t);
            if (statusSmartEnergyMng == true)
            {
                for (int i = 0; i < emptyTime.Count; i = i + 2)
                {
                    if (emptyTime[i] <= time && time<= emptyTime[i + 1])
                    {
                        if ((emptyTime[i + 1] - time) <= 0.60) //20 minutes before    
                              heaterMng_allSwitchOnHeaters(desiredTemperature);                            
                        else
                            heaterMng_allSwitchOffHeaters();
                    }//if                
                }//for
            }//if
        }//checkTime


        public List<Double> smartEnergy_getEmptyTime()
        {
            return emptyTime;
        }//smartEnergy_getEmptyTime

        
        public void smartEnergy_switchOnSmartEnergyMng(int hour, int minutes)
        {
            String t = hour.ToString() + "," + minutes.ToString();
            double time = Convert.ToDouble(t);
            this.statusSmartEnergyMng = true;
            List<HeaterCtrl> h = heaterMng_getHeaters();
            for (int i = 0; i < h.Count; i++)
            {
                if (h[i].getStatus())
                {
                    List<WindowCtrl> w = windowMng_findWindowsCtrlByRoom(h[i].getIdRoom());
                    for (int j = 0; j < w.Count; j++)
                    {
                        if (w[j].getValue() > 0)
                        {
                            this.id_window = w[j].getId();
                            windowMng_adjustWindow(id_window, 0);                           
                        }//if
                       
                    }//for
                }//if
            }//for  
            //Check the timer
            smartEnergy_checkTime(hour,minutes);
            notifySwitchOnSmartEnergyToObsevers();
        }//smartEnergy_switchOnSmartEnergyMng

        public void smartEnergy_switchOffSmartEnergyMng()
        {
            this.statusSmartEnergyMng = false;
            heaterMng_setDesiredTemperature(20.0);
            notifySwitchOffSmartEnergyToObsevers();
        }//smartEnergy_switchOffSmartEnergyMng

        public void smartEnergy_HeaterAdjustTemperature(int id, double temperature)
        {

            if (this.statusSmartEnergyMng)
            {
                HeaterCtrl h = heaterMng_findHeater(id);
                int id_room = h.getIdRoom();
                List<WindowCtrl> w = windowMng_findWindowsCtrlByRoom(id_room);
                for (int i = 0; i < w.Count; i++)
                {
                    this.id_window = w[i].getId();
                    windowMng_adjustWindow(id_window, 0);                   
                }//for
            }//if
            this.heaterMng_HeaterAdjustTemperature(id, temperature);
        }//smartEnergy_HeaterAdjustTemperature

        #region Timetables in XML
        public void smartEnergy_readTimeTables()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("..\\..\\xml\\timetables.xml"); //RUTA TEMPORAL
            XmlNodeList users = xDoc.GetElementsByTagName("users");
            XmlNodeList list = ((XmlElement)users[0]).GetElementsByTagName("user");

            foreach (XmlElement node in list)
            {
                XmlNodeList nTimeTable = node.GetElementsByTagName("timetable");
                timeTables.Add(nTimeTable[0].InnerText);                
            }// foreach
            smartEnergy_storeTimeTables();
            //findEmptyTime();
            emptyTime=smartEnergy_findEmptyTime();
        }// smartEnergy_readTimeTable
        protected void smartEnergy_storeTimeTables()
        {
            for (int i = 0; i < timeTables.Count; i++)
            {
                String temp = timeTables[i];
                bool more = false;
                List<double> listHours = new List<double>();
                do
                {

                    String time1 = temp.Substring(0, 2)+ "," + temp.Substring(3, 2);                    
                    String time2 = temp.Substring(6, 2) + "," + temp.Substring(9, 2);                    
                    listHours.Add(Convert.ToDouble(time1));
                    listHours.Add(Convert.ToDouble(time2));
                    
                    if (temp.Contains(","))
                    {
                        more = true;
                        temp=temp.Remove(0, temp.IndexOf(',')+1);
                    }
                    else
                    {
                        more = false;
                    }//else
                } while (more);
                dictTimesTables.Add(i, listHours);
            }//for
        }//smartEnergy_storeTimeTables

        public List<Double> smartEnergy_findEmptyTime()
        {
            List<Double> Result = new List<double>();          
           
            for (int i = 0; i < dictTimesTables[0].Count; i=i+2) //Guardamos en resultado los horarios del primero
            {
                Result.Add(dictTimesTables[0][i]);
                Result.Add(dictTimesTables[0][i + 1]);
            }//for
            
            for (int i = 1; i < dictTimesTables.Count; i++)
            {
                for (int k = 0; k < Result.Count; k = k + 2)
                {                  
                 
                    bool flag = false;                    
                    for (int j = 0; j < dictTimesTables[i].Count; j=j+2)
                    {
                        if (Result[k] < dictTimesTables[i][j + 1] && Result[k + 1] > dictTimesTables[i][j])
                        {
                            if(Result[k] <= dictTimesTables[i][j])
                            {
                                Result[k] = dictTimesTables[i][j];
                            }//if
                            if(Result[k + 1] >= dictTimesTables[i][j + 1])
                            {
                                Result[k + 1] = dictTimesTables[i][j + 1];
                            }//if
                            flag = true;
                        }//if                        
                     
                    }//for                    
                    if (flag == false)
                    {
                       int temp = Result.Count;       
                       Result.RemoveAt(k);
                       Result.RemoveAt(k);
                       if (temp > k + 1)  k = k - 2;                            
                    }//if                                  
                }//for                
            }//for
            return Result;
        }//prueba

        #endregion

        #region Subject-Observer Pattern
        /// <summary>
        ///     Register a new observer in the observer list
        /// </summary>
        /// <param name="obs">The observer to be registered</param>
        public void registerObserverSmartEnergy(IGatewayGUISmartEnergyObserver observer)
        {
            this.observersGatewaySmartEnergy.Add(observer);
        }// registerObserverSmartEnergy

        protected void notifySwitchOnSmartEnergyToObsevers()
        {
            foreach (IGatewayGUISmartEnergyObserver observer in observersGatewayLigth)
            {
                observer.switchOnSmartEnergy();
            } // foreach
        } // notifySwitchOnSmartEnergyToObsevers

        protected void notifySwitchOffSmartEnergyToObsevers()
        {
            foreach (IGatewayGUISmartEnergyObserver observer in observersGatewayLigth)
            {
                observer.switchOffSmartEnergy();
            } // foreach
        } // notifySwitchOffSmartEnergyToObsevers
        #endregion

    }// Gateway

} // namespace
