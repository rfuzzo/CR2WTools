using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTSaveNamedTargetOnEvent : IBehTreeTask
{
#region RED Properties

[REDProp("namedTargetToSave")]
public CName NamedTargetToSave { get; set;}

[REDProp("saveUnder")]
public CName SaveUnder { get; set;}

[REDProp("gameplayEventToSaveOn")]
public CName GameplayEventToSaveOn { get; set;}

#endregion
}
}