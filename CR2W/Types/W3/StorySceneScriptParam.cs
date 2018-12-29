using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class StorySceneScriptParam 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

/*[REDProp("value")]
public CVariant Value { get; set;}*/

#endregion
}
}