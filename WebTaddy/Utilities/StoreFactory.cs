using System;
using System.Collections.Generic;
using System.Text;
using WebTaddy.Stores;

namespace WebTaddy.Utilities
{
    static class StoreFactory
    {

        public static NavigationStore GetNewNavigationStore()
        {
            return new NavigationStore();
        }
    }
}
