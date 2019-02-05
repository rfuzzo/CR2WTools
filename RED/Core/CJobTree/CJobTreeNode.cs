using RED.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.Core
{
    public class CJobTreeNode : CObject
    {
        [RED] protected Pointer<CJobAction> onEnterAction;
        [RED] protected Pointer<CJobAction> onLeaveAction;
        [RED] protected Pointer<CJobForceOutAction> onFastLeaveAction;
        [RED(2, 0)] protected TDynArray<Pointer<CJobTreeNode>> childNodes;
        [RED(2, 0)] protected TDynArray<CName> validCategories;
        [RED] protected EJobTreeNodeSelectionMode selectionMode;
        [RED] protected UInt32 iterations;
        [RED] protected CName leftItem;
        [RED] protected CName rightItem;
        [RED] protected bool looped;
    }
}