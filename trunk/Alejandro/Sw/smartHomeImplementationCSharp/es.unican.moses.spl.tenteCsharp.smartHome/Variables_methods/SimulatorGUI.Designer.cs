﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    partial class SimulatorGUI
    {
        public virtual void observerRefreshDataGrid(){
            fillDataGridViewHeaters();
            fillDataGridViewWindows();
            filldataGridViewLigths();
            fillDataGridViewBlinds();
        }//observerRefreshDataGrid        
    }
}
