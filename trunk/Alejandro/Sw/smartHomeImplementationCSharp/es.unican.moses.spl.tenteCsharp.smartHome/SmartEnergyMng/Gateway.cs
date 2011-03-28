using System;
using System.Collections.Generic;

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

        public void initSmartEnergyMng(GatewayGUI gGUI)
        {
            this.gGUI = gGUI;
        }// initSmartEnergyMng

        public void switchOnSmartEnergyMng()
        {
            this.statusSmartEnergyMng = true;
            List<HeaterCtrl> h = getHeaters();
            for (int i = 0; i < h.Count; i++)
            {
                if (h[i].getStatus())
                {
                    List<WindowCtrl> w = findWindowsCtrlByRoom(h[i].getIdRoom());
                    for (int j = 0; j < w.Count; j++)
                    {
                        if (w[j].getValue() > 0)
                        {
                            adjustWindow(w[j].getId(), 0);                     
                        }//if
                       
                    }//for
                }//if
            }//for            
        }//switchOnSmartEnergyMng

        public void switchOffSmartEnergyMng()
        {
            this.statusSmartEnergyMng = false;
        }//switchOffSmartEnergyMng

        public void smartEnergyHeaterAdjustTemperature(int id, double temperature)
        {

            if (this.statusSmartEnergyMng)
            {
                HeaterCtrl h = findHeater(id);
                int id_room = h.getIdRoom();
                List<WindowCtrl> w = findWindowsCtrlByRoom(id_room);
                for (int i = 0; i < w.Count; i++)
                {
                    adjustWindow(w[i].getId(), 0);
                    gGUI.refreshWindow(0, w[i].getId());
                }//for
            }//if
            this.heaterMngHeaterAdjustTemperature(id, temperature);
        }//smartEnergyHeaterAdjustTemperature

    } // Gateway

} // namespace
