using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SnowMound : CInteractiveEntity
{
#region RED Properties

[REDProp("TagRemovedAfterMelt")]
public CName TagRemovedAfterMelt { get; set;}

[REDProp("isMelted")]
public bool IsMelted { get; set;}

#endregion
}
}