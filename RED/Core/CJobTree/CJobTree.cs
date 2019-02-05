using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.Core
{
    public class CJobTree : CResource
    {
        [RED] private protected Pointer<CJobTreeNode> jobTreeRootNode;
        [RED] private protected EJobMovementMode movementMode;
        [RED] private protected float customMovementSpeed;
        [RED] private protected SJobTreeSettings settings;
    }
}