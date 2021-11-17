using Negative.Common.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negative.Plugin.CommonComponent
{
    public class Plugin : IViewer
    {
        public void ViewContext()
        {
            throw new NotImplementedException();
        }

        List<ComponentObject> IViewer.GetAllComponent()
        {
            List<ComponentObject> objects = new List<ComponentObject>();

            objects.Add(new ComponentObject
            {
                Title = "日历",
                Description = "日历",
                ComponentView = new TestComponent()
            });


            return objects;
        }

        ContextObject IViewer.GetPluginView()
        {
            throw new NotImplementedException();
        }

        void IViewer.ViewContext()
        {
            throw new NotImplementedException();
        }
    }
}
