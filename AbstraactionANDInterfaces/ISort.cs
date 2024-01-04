using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraactionANDInterfaces
{
    internal interface ISort
    {
        void SortAsc(); // сортування за зростанням;       
        void SortDesc(); // сортування за зменшенням;
        void SortByParam(bool isAsc); // сортування залежно від переданого параметра.
    }
}
