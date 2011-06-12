﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartHome;

namespace MyHome
{
    partial class MyHome_SimulatorGUI: SimulatorGUI
    {
        public MyHome_SimulatorGUI(Gateway g)
            : base(g) { }

        public override void observerRefreshDataGrid()
        {
             this.fillDataGridViewHeaters();
             this.fillDataGridViewWindows();
             this.filldataGridViewLigths();
           
        }//observerRefreshDataGrid        
    }
}