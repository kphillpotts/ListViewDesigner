using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewDesigner
{
    public static class ViewModelLocator
    {
        static NewsViewModel newsViewModel;

        public static NewsViewModel NewsViewModel
        => newsViewModel ?? (newsViewModel = new NewsViewModel());
    }

}
