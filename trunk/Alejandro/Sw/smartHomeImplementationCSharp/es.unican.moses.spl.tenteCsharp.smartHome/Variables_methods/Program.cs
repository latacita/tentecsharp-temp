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
            Room r1 = new Room("Comedor", 0);
            Room r2 = new Room("Dormitorio", 1);
            Room r3 = new Room("Bano", 2);
            Room r4 = new Room("Cocina", 3);
            Floor f1 = new Floor("Sotano", 0);
            Floor f2 = new Floor("Planta baja", 1);
            Floor f3 = new Floor("Planta alta", 2);
            HeaterCtrl h1 = new HeaterCtrl(0, 0);
            Thermometer t1 = new Thermometer(1, 0);
            HeaterCtrl h2 = new HeaterCtrl(1, 3);
            Thermometer t2 = new Thermometer(2, 1);
            WindowCtrl w1 = new WindowCtrl(2, 0);
            WindowCtrl w2 = new WindowCtrl(3, 2);
            WindowSensor ws1 = new WindowSensor(3, 2);
            WindowSensor ws2 = new WindowSensor(4, 3);
            BlindCtrl b1 = new BlindCtrl(6, 2);
            BlindCtrl b2 = new BlindCtrl(7, 3);
            BlindSensor bs1 = new BlindSensor(7, 6);
            BlindSensor bs2 = new BlindSensor(8, 7);
            LightCtrl l1 = new LightCtrl(4, 0);
            LightCtrl l2 = new LightCtrl(5, 2);
            LightSensor ls1 = new LightSensor(6, 4);
            LightSensor ls2 = new LightSensor(7, 5);
            Time time = new Time(14, 00);

            f1.addRoom(r1);
            f1.addRoom(r2);
            f2.addRoom(r3);
            f3.addRoom(r4);
            Gateway g = new Gateway();
            g.initBaseSystem();
            g.initHeaterMng();
            g.initWindowMng();
            g.initLightMng();
            g.initBlindMng();
            g.initTime(time);
            g.initSmartEnergyMng();
            g.initLightSimulation();
            g.initBlindSimulation();
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
            g.lightMng_addLightCtrl(l1);
            g.lightMng_addLightCtrl(l2);
            g.lightMng_addLightSensor(ls1);
            g.lightMng_addLightSensor(ls2);
            g.blindMng_addBlindCtrl(b1);
            g.blindMng_addBlindCtrl(b2);
            g.blindMng_addBlindSensor(bs1);
            g.blindMng_addBlindSensor(bs2);
            SimulatorGUI sim = new SimulatorGUI(g);
            GatewayGUI gatewayGUI = new GatewayGUI(g, sim);
            gatewayGUI.addBaseSystem();
            gatewayGUI.addHeaterMng();
            gatewayGUI.addWindowMng();
            gatewayGUI.addSmartEnergyMng();
            gatewayGUI.addLightMng();
            gatewayGUI.addBlindMng();
            gatewayGUI.addLightSimulation();
            gatewayGUI.addBlindSimulation();
            sim.addHeaterMng();
            sim.addWindowMng();
            sim.addLightMng();
            sim.addSmartEnergyMng();
            sim.addBlindMng();
            sim.addLightSimulation();
            sim.addBlindSimulation();
            sim.Show();
            gatewayGUI.Show();
            Application.Run(gatewayGUI);
            Application.Run(sim);
        }
    }
}