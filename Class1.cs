using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeederSchedule
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.ReadOnly)]
    public class ShowWelcomeDialog : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("D4515F49 - 2CB6 - 4AFE - 9EBD - 7BD2803C4462"));
        public Result Execute (ExternalCommandData commandData,ref string message, ElementSet elementSet )
        {
            TaskDialog.Show("Hello","Welcome Snippet Code");
            return Result.Succeeded;
        }
    }
}
