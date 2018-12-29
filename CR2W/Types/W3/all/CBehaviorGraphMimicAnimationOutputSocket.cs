using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphMimicAnimationOutputSocket : CGraphSocket
{
#region RED Properties

[REDProp("block")]
public Ptr<CGraphBlock> Block { get; set;}

[REDProp("name")]
public CName Name { get; set;}

[REDProp("connections")]
public Array<Ptr<CGraphConnection>> Connections { get; set;}

#endregion
}
}