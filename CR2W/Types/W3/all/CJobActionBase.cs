using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CJobActionBase : CObject
{
#region RED Properties

[REDProp("categoryName")]
public string CategoryName { get; set;}

[REDProp("animName")]
public CName AnimName { get; set;}

[REDProp("animBlendIn")]
public float AnimBlendIn { get; set;}

[REDProp("animBlendOut")]
public float AnimBlendOut { get; set;}

[REDProp("fireBlendedEvents")]
public bool FireBlendedEvents { get; set;}

[REDProp("allowedLookAtLevel")]
public ELookAtLevel AllowedLookAtLevel { get; set;}

[REDProp("ignoreIfItemMounted")]
public CName IgnoreIfItemMounted { get; set;}

[REDProp("isSkippable")]
public bool IsSkippable { get; set;}

#endregion
}
}