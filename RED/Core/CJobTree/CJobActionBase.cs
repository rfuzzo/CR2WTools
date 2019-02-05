using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.Core
{
    public class CJobActionBase : CObject
    {
        [RED] protected string categoryName;
        [RED] protected CName animName;
        [RED] protected float animBlendIn;
        [RED] protected float animBlendOut;
        [RED] protected bool fireBlendedEvents;
        [RED] protected ELookAtLevel allowedLookAtLevel;
        [RED] protected CName ignoreIfItemMounted;
        [RED] protected bool isSkippable;
    }
}
