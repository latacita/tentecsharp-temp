using System;
using System.Collections.Generic;
// This is the content of the class named "WindowCtrl", which is 
// in the package: "MyHome", from the "My_Data" model. 
namespace My_Data{
	public class WindowCtrl{ 
		// Constructor and methods from the from the current class		
		public virtual void open ( Int degree ){
			WindowMng_open ( degree );
		}
		public virtual void WindowCtrl ( ){
			WindowMng_initWindowCtrl ( );
		}

	
	 
	}
} 
  