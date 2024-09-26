using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection

using Collections;

namespace Lists
{
    internal interface List : Collection
    {
        void Add(int index, object e);
        void Remove(int index);
        object Get(int index);
        void set(int index, object e);
        int indexOf(object e);
    }
}
