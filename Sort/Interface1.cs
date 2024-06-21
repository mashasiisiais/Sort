using kursee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{

    public interface IActions_Table
    {
        List<Event> Filter(List<Event> eventList, int filterOption, DateTime filterDate);
    }
}
