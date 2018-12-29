using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawnTreeInitializerGuardArea : ISpawnTreeInitializerGuardAreaBase
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("pursuitRange")]
public float PursuitRange { get; set;}

[REDProp("guardAreaTag")]
public CName GuardAreaTag { get; set;}

[REDProp("pursuitAreaTag")]
public CName PursuitAreaTag { get; set;}

[REDProp("findAreasInEncounter")]
public bool FindAreasInEncounter { get; set;}

#endregion
}
}