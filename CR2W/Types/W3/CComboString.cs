using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CComboString : CObject
{
#region RED Properties

[REDProp("attacks")]
public Array<SComboAnimationData> Attacks { get; set;}

[REDProp("distAttacks")]
public Array<Array<SComboAnimationData>> DistAttacks { get; set;}

[REDProp("dirAttacks")]
public Array<Array<Array<SComboAnimationData>>> DirAttacks { get; set;}

[REDProp("leftSide")]
public bool LeftSide { get; set;}

#endregion
}
}