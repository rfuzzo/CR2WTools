using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFairytaleWitchActions : IBehTreeTask
{
#region RED Properties

[REDProp("action")]
public EFairytaleWitchAction Action { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

#endregion
}
}