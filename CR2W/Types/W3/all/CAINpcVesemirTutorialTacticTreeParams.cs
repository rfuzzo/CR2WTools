using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcVesemirTutorialTacticTreeParams : CAINpcTacticTreeParams
{
#region RED Properties

[REDProp("backgroundTraining")]
public bool BackgroundTraining { get; set;}

[REDProp("onlyBlock")]
public bool OnlyBlock { get; set;}

[REDProp("onlyBlocksWithQuen")]
public bool OnlyBlocksWithQuen { get; set;}

[REDProp("useAttacks")]
public bool UseAttacks { get; set;}

[REDProp("useCombos")]
public bool UseCombos { get; set;}

[REDProp("forceIdle")]
public bool ForceIdle { get; set;}

[REDProp("attacksInterval")]
public float AttacksInterval { get; set;}

[REDProp("maxDistFromTarget")]
public float MaxDistFromTarget { get; set;}

#endregion
}
}