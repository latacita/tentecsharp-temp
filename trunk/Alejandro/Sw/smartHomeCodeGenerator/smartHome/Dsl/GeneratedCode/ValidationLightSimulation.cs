using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;

namespace Unican.smartHome
{
    [ValidationState(ValidationState.Enabled)]
    public partial class SmartHomeHasLightSimulation
    {
        // Identify the method as a validation method:
        [ValidationMethod
        ( // Specify which events cause the method to be invoked:
          ValidationCategories.Open // On file load.
        | ValidationCategories.Save // On save to file.
        | ValidationCategories.Menu // On user menu command.
        )]

        private void ValidateLightSimulation(ValidationContext context)
        {
            bool resultLight = false;
            LinkedElementCollection<Floor> f = this.SmartHome.Floors;
            for (int i = 0; i < f.Count; i++)
            {
                LinkedElementCollection<Room> r = f[i].Rooms;
                for (int j = 0; j < r.Count; j++)
                {
                    if (r[j].Lights.Count > 0)
                    {
                        resultLight = true;
                        break;
                    }//if                   
                }//for

            }//for
            if (!resultLight)
            {
                context.LogError(
                    // Description:
                                "If lightSimulation is selected, at least one light must be selected",
                    // Unique code for this error:
                                "FAB001LightSimulation");
            }//if        
        }//SmartHomeHasSmartEnergy
    }
}
