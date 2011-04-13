using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;

namespace Unican.smartHome
{
    [ValidationState(ValidationState.Enabled)]
    public partial class SmartHomeHasSmartEnergy
    {
        // Identify the method as a validation method:
        [ValidationMethod
        ( // Specify which events cause the method to be invoked:
          ValidationCategories.Open // On file load.
        | ValidationCategories.Save // On save to file.
        | ValidationCategories.Menu // On user menu command.
        )]

        private void ValidateSmartEnergy(ValidationContext context)
        {
            // In this DSL, the role names of this relationship
            // are "Child" and "Parent": 
            //Error	1	Cannot implicitly convert type 'Microsoft.VisualStudio.Modeling.LinkedElementCollection<Unican.smartHome.Floor>' to 'System.Collections.Generic.List<Unican.smartHome.Floor>'	C:\Users\Iskander\Desktop\Universidad\PFC\Source\Alejandro\Sw\smartHomeCodeGenerator\smartHome\Dsl\GeneratedCode\Class1.cs	22	57	Dsl
           bool resultHeater = false;
           bool resultWindow = false;
           LinkedElementCollection<Floor> f = this.SmartHome.Floors;
           for (int i = 0; i < f.Count; i++)
           {
               LinkedElementCollection<Room> r = f[i].Rooms;
               for (int j = 0; j < r.Count; j++)
               {
                   if (r[j].Heaters.Count > 0)
                   {
                       resultHeater = true;
                   }//if
                   if (r[j].Windows.Count > 0)
                   {
                       resultWindow = true;
                   }//
               }//for

           }//for
           if (!resultHeater || !resultWindow)
           {
               context.LogError(
                   // Description:
                               "If smartEnergy is selected, at least one window and one heater must be selected",
                   // Unique code for this error:
                               "FAB001SmartEnergy");                   
           }//if        
        }//SmartHomeHasSmartEnergy
    }
}
