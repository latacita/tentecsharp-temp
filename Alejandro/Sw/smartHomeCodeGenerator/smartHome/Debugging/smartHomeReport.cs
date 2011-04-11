
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using SmartHome;


namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			Gateway g = new Gateway();
						g.initBaseSystem();
					
			SimulatorGUI sim = new SimulatorGUI(g);
            GatewayGUI gatewayGUI = new GatewayGUI(g,sim);
			gatewayGUI.addBaseSystem();
			sim.Show();
            gatewayGUI.Show();            
            Application.Run(gatewayGUI);
            Application.Run(sim);
		}// Main
	}//Program
}//namespace
