using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SpawnEntityOnAnimEvent : CScriptedComponent
{
#region RED Properties

[REDProp("animEvent")]
public CName AnimEvent { get; set;}

[REDProp("entityName")]
public CName EntityName { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

#endregion
}
}