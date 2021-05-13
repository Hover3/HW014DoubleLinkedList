using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW014Rubakha.Interfaces
{
    public interface IListNode<T>
    {
        public IListNode<T> Next { get; internal set; }
        public IListNode<T> Previous { get; internal set; }
        public T Data { get; set; }

        

    }
}
