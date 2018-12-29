using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IgniProjectile : W3SignProjectile
{
#region RED Properties

[REDProp("channelCollided")]
public bool ChannelCollided { get; set;}

[REDProp("dt")]
public float Dt { get; set;}

[REDProp("isUsed")]
public bool IsUsed { get; set;}

#endregion
}
}