using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventsLesson
{
    public interface IPropertychanged
    {
        event PropertyeventHandler Propertychanged;
    }
}
