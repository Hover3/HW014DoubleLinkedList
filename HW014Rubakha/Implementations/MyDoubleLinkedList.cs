using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW014Rubakha.Interfaces;

namespace HW014Rubakha.Implementations
{
    public class MyDoubleLinkedList : HW014Rubakha.Interfaces.IList, IEnumerable
    {
        public MyDoubleLinkedList()
        {
             int count=0;
            IListNode Head=null;
            IListNode Tail=null;
         }

        public int count;
        public IListNode Head;
        public IListNode Tail;
        
        public int Count
        {
            get
            {
                return count;
            }
            
        }

        public bool IsEmpty
        {
            get
            {
                if (count==0)
                { return true; }
                else
                {
                    return false;
                }
            }
        }

        public IListNode AddFirst(int data)
        {
            if (count==0)
            {

            }
            else if (count==1)
            {

            }
            else
            {

            }

        }

        public Interfaces.IListNode AddLast(int data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable BackEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public bool Contains(int data)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool RemoveByValue(int data)
        {
            throw new NotImplementedException();
        }

        //IEnumerator<int> IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
