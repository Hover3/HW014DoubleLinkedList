﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW014Rubakha.Implementations
{
    public class MyDoubleLinkedList<T> : HW014Rubakha.Interfaces.IList<T>, IEnumerable<T>
    {
        public int Count => throw new NotImplementedException();

        public bool IsEmpty => throw new NotImplementedException();

        public Interfaces.IListNode<T> AddFirst(T data)
        {
            throw new NotImplementedException();
        }

        public Interfaces.IListNode<T> AddLast(T data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> BackEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T data)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool RemoveByValue(T data)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}