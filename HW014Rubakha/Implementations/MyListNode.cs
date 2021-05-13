using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW014Rubakha.Interfaces;

namespace HW014Rubakha.Implementations
{
    class MyListNode : IListNode
    {
        
        IListNode IListNode.Next 
        { get; set ; }
        IListNode IListNode.Previous 
        { get; set; }
        int IListNode.Data 
        { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
