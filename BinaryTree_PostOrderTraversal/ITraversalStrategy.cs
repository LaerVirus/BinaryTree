using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_PostOrderTraversal
{
    public interface ITraversalStrategy
    {
        IEnumerable<int> Traversal(Node node);
    }
}
