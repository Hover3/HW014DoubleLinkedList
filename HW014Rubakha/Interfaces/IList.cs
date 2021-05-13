using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW014Rubakha.Interfaces
{
    interface IList

    {
        IListNode AddLast(int data);
        IListNode AddFirst(int data);

        bool RemoveByValue(int data);

        bool Contains(int data);

        void Clear();

        int Count { get; }
        bool IsEmpty { get; }

        //IEnumerable<int> BackEnumerator();



    }
}
