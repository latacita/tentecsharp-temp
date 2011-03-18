using System;
using System.Collections;
using System.Text;

namespace SmartHome
{
	public partial class HouseGateway : TypeComponent
	{
			
		public HouseGateway (String id) 
			: base(id)
		{
		}



		public class House_windowManagement 
		{		

			public House_windowManagement()
			{
			}
		public Window getWindowById(String  id)
		{
			return null;		
		}
		public Blind getBlindById(String  id)
		{
			return null;		
		}

		}
			
			public House getHouseInstance()
			{
				House house=new House();
				return house;
			}

		public class Room_windowManagement 
		{		
			public ArrayList  windows = new ArrayList(); 
			public ArrayList  blinds = new ArrayList(); 

			public Room_windowManagement()
			{
			}
			public ArrayList getWindows()
			{
				return windows;
			}
			public void setWindows(ArrayList value)
			{
				this.windows=value;
			}
		
			public void addWindowsElement(Window value)
			{
				this.windows.Add(value);
			}
	
			public ArrayList getBlinds()
			{
				return blinds;
			}
			public void setBlinds(ArrayList value)
			{
				this.blinds=value;
			}
		
			public void addBlindsElement(Blind value)
			{
				this.blinds.Add(value);
			}
	
		public void addWindow(Window  window)
		{
		
		}
		public Window getWindowById(String  id)
		{
			return null;		
		}
		public void addBlind(Blind  value)
		{
		
		}
		public Blind getBlindById()
		{
			return null;		
		}

		}
			
			public Room getRoomInstance()
			{
				Room room=new Room();
				return room;
			}

		public class Window 
		{		
			public String id; 
			public String name; 

			public Window()
			{
			}
			public String   getId()
			{
				return id;
			}
			public void setId(String value)
			{
				this.id=value;
			}
	
			public String   getName()
			{
				return name;
			}
			public void setName(String value)
			{
				this.name=value;
			}
	

		}
			
			public Window getWindowInstance()
			{
				Window window=new Window();
				return window;
			}

		public class Floor_windowManagement 
		{		

			public Floor_windowManagement()
			{
			}
		public Window getWindowById(String  id)
		{
			return null;		
		}
		public Blind getBlindById(String  id)
		{
			return null;		
		}

		}
			
			public Floor getFloorInstance()
			{
				Floor floor=new Floor();
				return floor;
			}

		public class Blind 
		{		
			public String name; 
			public String id; 

			public Blind()
			{
			}
			public String   getName()
			{
				return name;
			}
			public void setName(String value)
			{
				this.name=value;
			}
	
			public String   getId()
			{
				return id;
			}
			public void setId(String value)
			{
				this.id=value;
			}
	

		}
			
			public Blind getBlindInstance()
			{
				Blind blind=new Blind();
				return blind;
			}	
		
		public class ActuatorPort_windowManagement : TypePort , IBlindGUINotify,IWindowGUINotify,IGeneralWindowNotify,IGeneralBlindNotify
		{
 		public ArrayList portsIBlindDimmer = new ArrayList();
		public ArrayList portsIBlindController = new ArrayList();
		public ArrayList portsIWindowDimmer = new ArrayList();
		public ArrayList portsIWindowController = new ArrayList();

			public ActuatorPort_windowManagement()
				: base()
			{
				portsIBlindDimmer=new ArrayList();
				portsIBlindController=new ArrayList();
				portsIWindowDimmer=new ArrayList();
				portsIWindowController=new ArrayList();

			}


		public void changeBlindAperture(String blindId,int value)
			{
		
			}

		public void changeWindowAperture(String windowId,int value)
			{
		
			}

		public void changeAllWindowsAperture(int aperture,String floorId,String roomId)
			{
		
			}

		public void changeAllBlindsAperture(int aperture,String floorId,String roomId)
			{
		
			}

			public ArrayList getPortsIBlindDimmer()
			{
	        	return portsIBlindDimmer;
	        }
				
			public void connectPort(IBlindDimmer port)
			{
				portsIBlindDimmer.Add(port);
			}

			public ArrayList getPortsIBlindController()
			{
	        	return portsIBlindController;
	        }
				
			public void connectPort(IBlindController port)
			{
				portsIBlindController.Add(port);
			}

			public ArrayList getPortsIWindowDimmer()
			{
	        	return portsIWindowDimmer;
	        }
				
			public void connectPort(IWindowDimmer port)
			{
				portsIWindowDimmer.Add(port);
			}

			public ArrayList getPortsIWindowController()
			{
	        	return portsIWindowController;
	        }
				
			public void connectPort(IWindowController port)
			{
				portsIWindowController.Add(port);
			}
	
		}	
		
		public class ServicesPort_windowManagement : TypePort
		{
 		public ArrayList portsIWindowNotifiy = new ArrayList();
		public ArrayList portsIBlindNotifiy = new ArrayList();

			public ServicesPort_windowManagement()
				: base()
			{
				portsIWindowNotifiy=new ArrayList();
				portsIBlindNotifiy=new ArrayList();

			}


			public ArrayList getPortsIWindowNotifiy()
			{
	        	return portsIWindowNotifiy;
	        }
				
			public void connectPort(IWindowNotifiy port)
			{
				portsIWindowNotifiy.Add(port);
			}

			public ArrayList getPortsIBlindNotifiy()
			{
	        	return portsIBlindNotifiy;
	        }
				
			public void connectPort(IBlindNotifiy port)
			{
				portsIBlindNotifiy.Add(port);
			}
	
		}	
		
		public class SensorPort_windowManagement : TypePort , IBlindDimmerNotify,IWindowDimmerNotify
		{
 
			public SensorPort_windowManagement()
				: base()
			{

			}


		public void blindDimmerValueChanged(int value,String blindId)
			{
		
			}

		public void windowDimmerValueChanged(int value,String windowId)
			{
		
			}
	
		}
	}
}