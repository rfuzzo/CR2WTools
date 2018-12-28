using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CUmbraTile : CResource
{
#region RED Properties

[REDProp("dataStatus")]
public EUmbraTileDataStatus DataStatus { get; set;}

[REDProp("data")]
public DeferredDataBuffer Data { get; set;}

#endregion
}
}