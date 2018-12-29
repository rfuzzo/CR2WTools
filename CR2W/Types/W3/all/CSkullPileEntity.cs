using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSkullPileEntity : CGameplayEntity
{
#region RED Properties

[REDProp("factName")]
public string FactName { get; set;}

[REDProp("tagToCollideWith")]
public CName TagToCollideWith { get; set;}

[REDProp("intact")]
public bool Intact { get; set;}

[REDProp("destructionComp")]
public Handle<CDestructionSystemComponent> DestructionComp { get; set;}

#endregion
}
}