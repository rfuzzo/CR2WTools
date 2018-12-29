using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFloePiece : CScriptedDestroyableComponent
{
#region RED Properties

[REDProp("totalTime")]
public float TotalTime { get; set;}

[REDProp("currPosition")]
public Vector CurrPosition { get; set;}

#endregion
}
}