using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterTaunt : CAITauntTree
{
#region RED Properties

[REDProp("canBury")]
public bool CanBury { get; set;}

[REDProp("params")]
public Handle<CAIMonsterTauntParams> Params { get; set;}

#endregion
}
}