using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterReactionsTreeParams : CAIReactionsParameters
{
#region RED Properties

[REDProp("reactions")]
public Array<Handle<CAIMonsterActionSubtree>> Reactions { get; set;}

[REDProp("canFly")]
public bool CanFly { get; set;}

#endregion
}
}