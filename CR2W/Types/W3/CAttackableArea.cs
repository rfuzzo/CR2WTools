using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAttackableArea : CGameplayEntityParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("overrideInherited")]
public bool OverrideInherited { get; set;}

[REDProp("offset")]
public Vector Offset { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("height")]
public float Height { get; set;}

#endregion
}
}