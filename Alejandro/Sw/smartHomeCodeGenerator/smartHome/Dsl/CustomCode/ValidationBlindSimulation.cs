using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;

namespace Unican.smartHome
{
    [ValidationState(ValidationState.Enabled)]
    public partial class SmartHomeHasBlindSimulation
    {
        // Identify the method as a validation method:
        [ValidationMethod
        ( // Specify which events cause the method to be invoked:
          ValidationCategories.Open // On file load.
        | ValidationCategories.Save // On save to file.
        | ValidationCategories.Menu // On user menu command.
        )]

        private void ValidateBlindSimulation(ValidationContext context)
        {
            
            bool resultBlind = false;
            LinkedElementCollection<Floor> f = this.SmartHome.Floors;
            for (int i = 0; i < f.Count; i++)
            {
                LinkedElementCollection<Room> r = f[i].Rooms;
                for (int j = 0; j < r.Count; j++)
                {
                    LinkedElementCollection<Window> w = r[j].Windows;
                    for (int k = 0; k < w.Count; k++)
                    {
                        LinkedElementCollection<Blind> b = w[k].Blinds;
                        if(b.Count > 0)
                        {
                            resultBlind = true;
                            break;
                        }//if
                    }//for
                }//for

            }//for
            if (!resultBlind)
            {
                context.LogError(
                    // Description:
                                "If BlindSimulation is selected, at least one blind must be selected",
                    // Unique code for this error:
                                "FAB002BlindSimulation");
            }//if        
        }//SmartHomeHasSmartEnergy
    }//SmartHomeHasBlindSimulation
}//Unican.smartHome
