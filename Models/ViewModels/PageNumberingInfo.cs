using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign10Bowling.Models.ViewModels
{
    public class PageNumberingInfo
    {
        public int NumItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumItems { get; set; }


        //calc num of pages
        public int NumPages => (int) (Math.Ceiling((decimal) TotalNumItems / NumItemsPerPage ));
    }
}
