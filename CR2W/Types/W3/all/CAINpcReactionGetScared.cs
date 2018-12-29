using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcReactionGetScared : CAINpcReaction
{
#region RED Properties

[REDProp("scaredTime")]
public float ScaredTime { get; set;}

[REDProp("scaredTimeMax")]
public float ScaredTimeMax { get; set;}

[REDProp("checkLineOfSight")]
public bool CheckLineOfSight { get; set;}

[REDProp("tryToBeHostileFirst")]
public bool TryToBeHostileFirst { get; set;}

#endregion
}
}