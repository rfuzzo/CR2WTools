using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3EffectItem : CItemEntity
{
#region RED Properties

[REDProp("effectName")]
public CName EffectName { get; set;}

#endregion
}
}