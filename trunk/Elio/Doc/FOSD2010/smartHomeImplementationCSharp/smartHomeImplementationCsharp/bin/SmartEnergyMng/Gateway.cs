//=====================================================================================================//
// Author: Pablo Sánchez (p.sanchez@unican.es) http://personales.unican.es/sanchezbp                   //
// Author: Elio López                                                                                  //
// Project: SmartHome Implementation using C# partial classes                                          // 
// File: SmartEnergyMng/Gateway.cs                                                                     //
// Papers: Fosd2010                                                                                    //
//=====================================================================================================//     

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
        protected ThermometerCtrl outsideThermo;
        protected ThermometerCtrl indoorThermo;

        public void initSmartEnergyMng()
        {
            this.outsideThermo = new ThermometerCtrl();
            this.indoorThermo = new ThermometerCtrl();
        }


        public  bool smartEnergyAdjustTemparature(int id, double temperature) {

            bool result = false;


            return result;
        
        }
        
    } // Gateway

} // namespace