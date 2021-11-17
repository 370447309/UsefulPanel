using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negative.Common.Plugin
{
    public interface IViewer
    {
        void ViewContext();

        List<ComponentObject> GetAllComponent();

        ContextObject GetPluginView();
    }
}
