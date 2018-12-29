using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFoodBoidPointOfInterest : CBoidPointOfInterestComponentScript
{
#region RED Properties

[REDProp("expirationTime")]
public Int32 ExpirationTime { get; set;}

[REDProp("useCounter")]
public float UseCounter { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("poiDisp")]
public Handle<W3POIDispenser> PoiDisp { get; set;}

[REDProp("poi")]
public Handle<W3PointOfInterestEntity> Poi { get; set;}

#endregion
}
}