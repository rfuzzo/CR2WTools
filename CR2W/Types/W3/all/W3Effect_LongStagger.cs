using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_LongStagger : W3Effect_Stagger
{
#region RED Properties

[REDProp("owner")]
public Handle<CEntity> Owner { get; set;}

#endregion
}
}