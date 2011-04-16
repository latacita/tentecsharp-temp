
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
             this.fillDataGridViewBlinds();
           
        }//observerRefreshDataGrid        
        public override void refreshTime()
        {
            this.smartEnergy_refreshTime();
            this.lightSimulation_refreshTime();
            this.blindSimulation_refreshTime();
        }//refreshTime
    }
}