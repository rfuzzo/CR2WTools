using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ActorLatentActionMoveAlongPath : IPresetActorLatentAction
{
#region RED Properties

[REDProp("pathTag")]
public CName PathTag { get; set;}

[REDProp("upThePath")]
public bool UpThePath { get; set;}

[REDProp("fromBeginning")]
public bool FromBeginning { get; set;}

[REDProp("pathMargin")]
public float PathMargin { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("dontCareAboutNavigable")]
public bool DontCareAboutNavigable { get; set;}

#endregion
}
}