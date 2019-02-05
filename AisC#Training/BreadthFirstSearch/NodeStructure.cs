using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearch
{
    // Structure of a node.
    public class NodeStructure                   
    {
        public int data;
        public NodeStructure left, right;
        public NodeStructure(int item)
        {
            data = item;
            left = right = null;
        }
    }
}
