using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFirstHome
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstHome_Room r1 = new MyFirstHome_Room("Comedor", 0);
            MyFirstHome_Room r2 = new MyFirstHome_Room("Dormitorio", 1);
            MyFirstHome_Room r3 = new MyFirstHome_Room("Bano", 2);
            MyFirstHome_Room r4 = new MyFirstHome_Room("Cocina", 3);
            MyFirstHome_Floor f1 = new MyFirstHome_Floor("Sotano", 0);
            MyFirstHome_Floor f2 = new MyFirstHome_Floor("Planta baja", 1);
            MyFirstHome_Floor f3 = new MyFirstHome_Floor("Planta alta", 2);
            MyFirstHome_HeaterCtrl h1 = new MyFirstHome_HeaterCtrl(0, 0);
            MyFirstHome_Thermometer t1 = new MyFirstHome_Thermometer(1, 0);
            MyFirstHome_HeaterCtrl h2 = new MyFirstHome_HeaterCtrl(1, 3);
            MyFirstHome_Thermometer t2 = new MyFirstHome_Thermometer(2, 1);
            MyFirstHome_WindowsCtrl w1 = new MyFirstHome_WindowsCtrl(2, 0);
            MyFirstHome_WindowsCtrl w2 = new MyFirstHome_WindowsCtrl(3, 2);
            MyFirstHome_WindowSensor ws1 = new MyFirstHome_WindowSensor(3, 2);
            MyFirstHome_WindowSensor ws2 = new MyFirstHome_WindowSensor(4, 3);
            f1.addRoom(r1);
            f1.addRoom(r2);
            f2.addRoom(r3);
            f3.addRoom(r4);
            MyFirstHome_Gateway g = new MyFirstHome_Gateway();
            g.initBaseSystem();
            g.initHeaterMng();
            g.initWindowMng();
            g.addFloor(f1);
            g.addFloor(f2);
            g.addFloor(f3);
            g.heaterMng_addHeaterCtrl(h1);
            g.heaterMng_addThermometer(t1);
            g.heaterMng_addHeaterCtrl(h2);
            g.heaterMng_addThermometer(t2);
            g.windowMng_addWindowCtrl(w1);
            g.windowMng_addWindowCtrl(w2);
            g.windowMng_addWindowSensor(ws1);
            g.windowMng_addWindowSensor(ws2);
            MyFirstHome_SimulatorGUI sim = new MyFirstHome_SimulatorGUI(g);
            MyFirstHome_GatewayGUI gatewayGUI = new MyFirstHome_GatewayGUI(g, sim);
            g.initSmartEnergyMng(gatewayGUI);
            gatewayGUI.addBaseSystem();
            gatewayGUI.addHeaterMng();
            gatewayGUI.addWindowMng();
            gatewayGUI.addSmartEnergy();
            sim.addHeaterMng();
            sim.addWindowMng();
            sim.Show();
            
            gatewayGUI.Show();
            Application.Run(gatewayGUI);
            Application.Run(sim);

            // Observers are registered properly
            h1.registerObserver(sim);
            h2.registerObserver(sim);

        }
    }
}
