using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW014Rubakha.Interfaces
{
    public interface IListNode
    {
        public IListNode Next { get; internal set; }
        public IListNode Previous { get; internal set; }
        public int Data { get; set; }

        

    }
}
