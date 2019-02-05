using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.Core
{
    public class CJobForceOutAction : CJobActionBase
    {
        [RED] protected EJobForceOutDropMode itemDropMode;
        [RED] protected float speedMul;
    }
}
