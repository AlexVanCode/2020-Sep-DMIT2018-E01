using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookSystem.ViewModels
{
   public class SelectionList
    {
        //use this class to carry data for a drop down list. all the lists
        // drop down list needs value and to display a string. any 
        public int ValueId { get; set; }
        public string DisplayText { get; set; }

    }
}
