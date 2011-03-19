using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace SmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r1 = new Room("Comedor");
            Room r2 = new Room("Dormitorio");
            Floor f1 = new Floor("Planta baja");
            Floor f2 = new Floor("Planta alta");
            f1.addRoom(r1);
            f1.addRoom(r2);
            Gateway g = new Gateway();
            g.initBaseSystem();
            g.addFloor(f1);
            g.addFloor(f2);
            GatewayGUI gatewayGUI = new GatewayGUI();
            gatewayGUI.addFloors(g.getFloors());
            Application.Run(gatewayGUI);
        }
    }
}
