using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW014Rubakha.Interfaces;

namespace HW014Rubakha.Implementations
{
    public class MyDoubleLinkedList : HW014Rubakha.Interfaces.IList, IEnumerator<int>, IEnumerable
    {
        public MyDoubleLinkedList()
        {
             int count=0;
            IListNode Head=null;
            IListNode Tail=null;
         }

        private IListNode currentNode = null;

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

        int IEnumerator<int>.Current
        {
            get
            {
                return currentNode.Data;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return currentNode.Data;
            }
            
        }

        public IListNode AddFirst(int data)
        {
            IListNode tmpNode = new MyListNode();
            tmpNode.Data = data;

            if (count==0)
            {
                Head = tmpNode;
                Tail = tmpNode;
            }
            else if (count==1)
            {
                Tail.Previous = tmpNode;
                tmpNode.Next = Tail;
                Head = tmpNode;
            }
            else
            {
                tmpNode.Next = Head;
                Head.Previous = tmpNode;
                Head = tmpNode;
            }
            count += 1;
            return tmpNode;

        }

        public Interfaces.IListNode AddLast(int data)
        {
            IListNode tmpNode = new MyListNode();
            tmpNode.Data = data;

            if (count == 0)
            {
                Head = tmpNode;
                Tail = tmpNode;
            }
            else if (count == 1)
            {
                Tail.Next = tmpNode;
                tmpNode.Previous = Tail;
                Tail = tmpNode;
            }
            else
            {
                Tail.Next = tmpNode;
                tmpNode.Previous = Tail;
                Tail = tmpNode;
            }
            count += 1;
            return tmpNode;
        }

        public IEnumerator<int> BackEnumerator()
        {
            return this;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public bool Contains(int data)
        {
            if (count==0)
            {
                return false;
            }
            else
            {
                IListNode currentNode = Head;
                do
                {
                    if (currentNode.Data == data)
                    {
                        return true;
                    }
                    currentNode = currentNode.Next;

                } while (currentNode != null);
                
                return false;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IListNode RemoveByValue(int data)
        {
            if (count==0)
            {
                throw new ArgumentException("Can't delete node by value from empty list");
            }
            else
            {
                IListNode currentNode = Head;
                do
                {
                    if (currentNode.Data == data)
                    {

                        if (currentNode == Head)
                        {
                            return RemoveFirst();
                        }
                        else if (currentNode == Tail)
                        {
                            return RemoveLast();
                        }
                        else
                        {
                            currentNode.Previous.Next = currentNode.Next;
                            currentNode.Next.Previous = currentNode.Previous;
                            count -= 1;
                            return currentNode;
                        }
                        
                    }
                    currentNode = currentNode.Next;

                } while (currentNode != null);

                throw new ArgumentException("Value not found in list");
            }
        }

        public IListNode InsertAfter(int data, IListNode previousNode)
        {
            if (IsNodeFromThisList(previousNode))
            {
                count += 1;
                if (previousNode==Tail)
                {
                    return AddLast(data);
                }
                else
                {
                    IListNode tmpNode = new MyListNode();
                    tmpNode.Data = data;
                    tmpNode.Previous = previousNode;
                    tmpNode.Next = previousNode.Next;
                    previousNode.Next.Previous = tmpNode;
                    previousNode.Next = tmpNode;
                    return tmpNode;
                }
            }
            else
            {
                throw new ArgumentException("This node don't belong to this list");
            }

        }

        public bool IsNodeFromThisList(IListNode node)
        {
            
            if (count==0)
            {
                return false;
            }
            else
            {
                IListNode currentNode = Head;
                do
                {
                    if (currentNode == node)
                    {
                        return true;
                    }
                    currentNode = currentNode.Next;

                } while (currentNode != null);
            }
            return false;
        }

        public IListNode RemoveFirst()
        {
            if (count==0)
            {
                throw new ArgumentException("Cant remove first item from epmty list");
            }
            else if (count==1)
            {
                IListNode tmpNode = Head;
                Head = null;
                Tail = null;
                count -= 1;
                return tmpNode;
            }
            else
            {
                IListNode tmpNode = Head;
                Head.Next.Previous = null;
                Head = Head.Next;
                count -= 1;
                return tmpNode;
            }
        }

        public IListNode RemoveLast()
        {
            if (count == 0)
            {
                throw new ArgumentException("Cant remove first item from epmty list");
            }
            else if (count == 1)
            {
                IListNode tmpNode = Head;
                Head = null;
                Tail = null;
                count -= 1;
                return tmpNode;
            }
            else
            {
                IListNode tmpNode = Tail;
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
                count -= 1;
                return tmpNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        bool IEnumerator.MoveNext()
        {
            if (currentNode==null)
            {
                currentNode = Tail;
            }
            else
            {
                currentNode = currentNode.Previous;
            }
            if (currentNode != null)
            { return true; }
            else
            { return false; }


        }

        void IEnumerator.Reset()
        {
            currentNode = null;
        }

        void IDisposable.Dispose()
        {
            
        }
    }
}
