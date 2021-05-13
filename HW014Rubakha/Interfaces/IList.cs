using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW014Rubakha.Interfaces
{
    interface IList<T>

    {
        IListNode<T> AddLast(T data);
        IListNode<T> AddFirst(T data);

        bool RemoveByValue(T data);

        bool Contains(T data);

        void Clear();

        int Count { get; }
        bool IsEmpty { get; }

        IEnumerable<T> BackEnumerator();



    }
}
