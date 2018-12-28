using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SFurCulling 
{
#region RED Properties

[REDProp("useViewfrustrumCulling")]
public bool UseViewfrustrumCulling { get; set;}

[REDProp("useBackfaceCulling")]
public bool UseBackfaceCulling { get; set;}

[REDProp("backfaceCullingThreshold")]
public float BackfaceCullingThreshold { get; set;}

#endregion
}
}