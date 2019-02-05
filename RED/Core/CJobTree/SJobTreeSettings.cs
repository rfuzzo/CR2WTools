using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.Core
{
    public class SJobTreeSettings : REDClass
    {
        [RED] protected bool leftRemoveAtEnd;
        [RED] protected bool leftDropOnBreak;
        [RED] protected bool rightRemoveAtEnd;
        [RED] protected bool rightDropOnBreak;
        [RED] protected bool ignoreHardReactions;
        [RED] protected bool needsPrecision;
        [RED] protected bool isConscious;
        [RED] protected Handle<CJobTree> altJobTreeRes;
        [RED] protected float globalBreakingBlendOutTime;
        [RED] protected bool forceKeepIKactive;
        [RED] protected Int32 jobTreeType;
    }
}
