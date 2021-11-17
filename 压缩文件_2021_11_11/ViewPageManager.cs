using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeScreen
{
    internal class ViewPageManager : IDisposable
    {
        private static ViewPageManager _instance;

        private ViewPage _viewPage;

        internal ViewPageManager()
        {

        }

        internal static ViewPageManager GetInstance()
        {
            return _instance ?? (_instance = new ViewPageManager());
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
