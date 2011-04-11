using System;
using System.Collections.Generic;
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
			Floor f0 = new Floor("Planta baja",0);
			Room r0 = new Room("Comedor",0);
			f0.addRoom(r0);
			HeaterCtrl h0 = new HeaterCtrl(0,0);
			Thermometer t0 = new Thermometer(1,0);
			LigthCtrl l0 = new LigthCtrl(2,0);
            LigthSensor ls0 = new LigthSensor(3,2);
			WindowCtrl w0 = new WindowCtrl(4,0);
			WindowSensor ws0 = new WindowSensor(5,4);
			BlindCtrl b0 = new BlindCtrl(6,4);
			BlindSensor bs0 = new BlindSensor(7,6);
			Floor f1 = new Floor("Sotano",1);
			Room r1 = new Room("Cocina",1);
			f1.addRoom(r1);
			HeaterCtrl h1 = new HeaterCtrl(8,1);
			Thermometer t1 = new Thermometer(9,8);
			Time time = new Time(14,00);
			g.initBaseSystem();
			g.initHeaterMng();
			g.initLightMng();
			g.initWindowMng();
			g.initBlindMng();
			g.initTime(time);
			g.initBlindSimulation();
			g.initLightSimulation();
			g.initSmartEnergyMng();
			g.addFloor(f0);
			g.addFloor(f1);
			g.heaterMng_addHeaterCtrl(h0);
			g.heaterMng_addThermometer(t0);
			g.heaterMng_addHeaterCtrl(h1);
			g.heaterMng_addThermometer(t1);
			g.lightMng_addLightCtrl(l0);
			g.lightMng_addLightSensor(ls0);
			g.windowMng_addWindowCtrl(w0);
			g.windowMng_addWindowSensor(ws0);
			g.blindMng_addBlindCtrl(b0);
			g.blindMng_addBlindSensor(bs0);
			SimulatorGUI sim = new SimulatorGUI(g);
            GatewayGUI gatewayGUI = new GatewayGUI(g,sim);
			gatewayGUI.addBaseSystem();
			gatewayGUI.addHeaterMng();
			gatewayGUI.addLightMng();
			gatewayGUI.addWindowMng();
			gatewayGUI.addBlindMng();
			gatewayGUI.addBlindSimulation();
			gatewayGUI.addLightSimulation();
			gatewayGUI.addSmartEnergyMng();
			sim.addHeaterMng();
			sim.addLightMng();
			sim.addWindowMng();
			sim.addBlindMng();
			sim.addBlindSimulation();
			sim.addLightSimulation();
			sim.addSmartEnergyMng();
			sim.Show();
            gatewayGUI.Show();            
            Application.Run(gatewayGUI);
            Application.Run(sim);
		}// Main
	}//Program
}//namespace
