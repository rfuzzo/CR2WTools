using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Mutagen_Effect : CBaseGameplayEffect
{
#region RED Properties

[REDProp("toxicityOffset")]
public float ToxicityOffset { get; set;}

#endregion
}
}