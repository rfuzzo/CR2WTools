using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_HasWeaponDrawn : CQCActorScriptedCondition
{
#region RED Properties

[REDProp("treatFistsAsWeapon")]
public bool TreatFistsAsWeapon { get; set;}

[REDProp("ofSpecificCategory")]
public CName OfSpecificCategory { get; set;}

[REDProp("ofSpecificName")]
public CName OfSpecificName { get; set;}

#endregion
}
}