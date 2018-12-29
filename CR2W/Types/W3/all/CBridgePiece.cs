using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBridgePiece : CScriptedDestroyableComponent
{
#region RED Properties

[REDProp("entityPos")]
public Vector EntityPos { get; set;}

[REDProp("compPos")]
public Vector CompPos { get; set;}

[REDProp("totalTime")]
public float TotalTime { get; set;}

[REDProp("z")]
public Handle<CEntity> Z { get; set;}

#endregion
}
}