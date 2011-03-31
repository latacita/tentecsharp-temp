using System;
using System.Collections.Generic;
using System.Xml;

namespace SmartHome
{

    //=================================================================================================//
    // This class represent the central gateway of the Smart Home which process all commands           //
    // This file only contains the functionality related to the SmartEnergyMng feature                 //
    //=================================================================================================//

    public partial class Gateway
    {
        protected bool statusSmartEnergyMng = false;
        protected GatewayGUI gGUI;
        //<Name-LastName, timeTable>
        protected Dictionary<String, String> timeTables = new Dictionary<String, String>();

        public void initSmartEnergyMng(GatewayGUI gGUI)
        {
            this.gGUI = gGUI;
            readTimeTables();
        }// initSmartEnergyMng

        public void switchOnSmartEnergyMng()
        {
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
                            windowMng_adjustWindow(w[j].getId(), 0);                     
                        }//if
                       
                    }//for
                }//if
            }//for            
        }//switchOnSmartEnergyMng

        public void switchOffSmartEnergyMng()
        {
            this.statusSmartEnergyMng = false;
        }//switchOffSmartEnergyMng

        public void smartEnergy_HeaterAdjustTemperature(int id, double temperature)
        {

            if (this.statusSmartEnergyMng)
            {
                HeaterCtrl h = heaterMng_findHeater(id);
                int id_room = h.getIdRoom();
                List<WindowCtrl> w = windowMng_findWindowsCtrlByRoom(id_room);
                for (int i = 0; i < w.Count; i++)
                {
                    windowMng_adjustWindow(w[i].getId(), 0);
                    gGUI.refreshWindow(0, w[i].getId());
                }//for
            }//if
            this.heaterMng_HeaterAdjustTemperature(id, temperature);
        }//smartEnergy_HeaterAdjustTemperature

        public void readTimeTables()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("..\\..\\xml\\timetables.xml"); //RUTA TEMPORAL
            XmlNodeList users = xDoc.GetElementsByTagName("users");
            XmlNodeList list = ((XmlElement)users[0]).GetElementsByTagName("user");

            foreach (XmlElement node in list)
            {

                
                int i = 0;

                XmlNodeList nName =
                node.GetElementsByTagName("name");

                XmlNodeList nLastName =
                node.GetElementsByTagName("lastname");

                XmlNodeList nTimeTable =
                node.GetElementsByTagName("timetable");
                Console.WriteLine("Elemento nombre ... {0} {1} {2}",
                             nName[i].InnerText,
                             nLastName[i].InnerText,
                             nTimeTable[i++].InnerText);
               
                //timeTables.Add(nName[i].ToString()+nLastName[i].ToString(), nTimeTable[i++].ToString());
            }// foreach
        }// readTimeTable

    }// Gateway

} // namespace
