using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW014.Interfaces;

namespace HW014.Implementations
{
    class MyListNode : IListNode
    {
        
        IListNode IListNode.Next 
        { get; set ; }
        IListNode IListNode.Previous 
        { get; set; }
        int IListNode.Data 
        { get ; set; }
    }
}
