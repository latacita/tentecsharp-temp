using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using SmartHome;

namespace MyHome
{
	class Program
	{
		static void Main(string[] args)
		{
			MyHome_Gateway g = new MyHome_Gateway();
			MyHome_Floor f0 = new MyHome_Floor("Planta baja",0);
			MyHome_Room r0 = new MyHome_Room("Comedor",0);
			f0.addRoom(r0);
			MyHome_HeaterCtrl h0 = new MyHome_HeaterCtrl(0,0);
			MyHome_Thermometer t0 = new MyHome_Thermometer(1,0);
			MyHome_LightCtrl l0 = new MyHome_LightCtrl(2,0);
            MyHome_LightSensor ls0 = new MyHome_LightSensor(3,2);
			MyHome_WindowCtrl w0 = new MyHome_WindowCtrl(4,0);
			MyHome_WindowSensor ws0 = new MyHome_WindowSensor(5,4);
			MyHome_BlindCtrl b0 = new MyHome_BlindCtrl(6,4);
			MyHome_BlindSensor bs0 = new MyHome_BlindSensor(7,6);
			MyHome_Time time = new MyHome_Time(14,00);
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
			g.heaterMng_addHeaterCtrl(h0);
			g.heaterMng_addThermometer(t0);
			g.lightMng_addLightCtrl(l0);
			g.lightMng_addLightSensor(ls0);
			g.windowMng_addWindowCtrl(w0);
			g.windowMng_addWindowSensor(ws0);
			g.blindMng_addBlindCtrl(b0);
			g.blindMng_addBlindSensor(bs0);
			MyHome_SimulatorGUI sim = new MyHome_SimulatorGUI(g);
            MyHome_GatewayGUI gatewayGUI = new MyHome_GatewayGUI(g);
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







