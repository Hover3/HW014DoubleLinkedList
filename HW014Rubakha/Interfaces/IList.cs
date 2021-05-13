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

        IListNode RemoveFirst();
        IListNode RemoveLast();

        IListNode InsertAfter(int data, IListNode previousNode);

        IListNode RemoveByValue(int data);

        bool Contains(int data);

        void Clear();

        int Count { get; }
        bool IsEmpty { get; }

        IEnumerator<int> BackEnumerator();



    }
}
