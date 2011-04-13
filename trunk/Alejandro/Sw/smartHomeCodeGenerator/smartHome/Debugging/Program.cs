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
			MyHome_Gateway g = new MyHome_Gateway();
			MyHome_Floor f0 = new MyHome_Floor("Planta baja",0);
			MyHome_Room r0 = new MyHome_Room("Comedor",0);
			f0.addRoom(r0);
			MyHome_LigthCtrl l0 = new MyHome_LigthCtrl(0,0);
            MyHome_LigthSensor ls0 = new MyHome_LigthSensor(1,0);
			MyHome_WindowCtrl w0 = new MyHome_WindowCtrl(2,0);
			MyHome_WindowSensor ws0 = new MyHome_WindowSensor(3,2);
			MyHome_BlindCtrl b0 = new MyHome_BlindCtrl(4,2);
			MyHome_BlindSensor bs0 = new MyHome_BlindSensor(5,4);
			MyHome_Floor f1 = new MyHome_Floor("Sotano",1);
			MyHome_Room r1 = new MyHome_Room("Cocina",1);
			f1.addRoom(r1);
			MyHome_Time time = new MyHome_Time(14,00);
			g.initBaseSystem();
			g.initLightMng();
			g.initWindowMng();
			g.initBlindMng();
			g.initTime(time);
			g.initBlindSimulation();
			g.initLightSimulation();
			g.addFloor(f0);
			g.addFloor(f1);
			g.lightMng_addLightCtrl(l0);
			g.lightMng_addLightSensor(ls0);
			g.windowMng_addWindowCtrl(w0);
			g.windowMng_addWindowSensor(ws0);
			g.blindMng_addBlindCtrl(b0);
			g.blindMng_addBlindSensor(bs0);
			MyHome_SimulatorGUI sim = new MyHome_SimulatorGUI(g);
            MyHome_GatewayGUI gatewayGUI = new MyHome_GatewayGUI(g,sim);
			gatewayGUI.addBaseSystem();
			gatewayGUI.addLightMng();
			gatewayGUI.addWindowMng();
			gatewayGUI.addBlindMng();
			gatewayGUI.addBlindSimulation();
			gatewayGUI.addLightSimulation();
			sim.addLightMng();
			sim.addWindowMng();
			sim.addBlindMng();
			sim.addBlindSimulation();
			sim.addLightSimulation();
			sim.Show();
            gatewayGUI.Show();            
            Application.Run(gatewayGUI);
            Application.Run(sim);
		}// Main
	}//Program
}//namespace
