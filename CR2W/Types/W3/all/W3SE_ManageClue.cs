using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_ManageClue : W3SwitchEvent
{
#region RED Properties

[REDProp("clueHandle")]
public Array<EntityHandle> ClueHandle { get; set;}

[REDProp("clueTag")]
public CName ClueTag { get; set;}

[REDProp("operations")]
public Array<EClueOperation> Operations { get; set;}

[REDProp("myTags")]
public Array<CName> MyTags { get; set;}

#endregion
}
}