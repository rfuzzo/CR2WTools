using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskDeathStateDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("destroyAfterAnimDelay")]
public CBehTreeValFloat DestroyAfterAnimDelay { get; set;}

[REDProp("fxName")]
public CBehTreeValCName FxName { get; set;}

[REDProp("setAppearanceTo")]
public CBehTreeValCName SetAppearanceTo { get; set;}

[REDProp("changeAppearanceAfter")]
public CBehTreeValFloat ChangeAppearanceAfter { get; set;}

[REDProp("createReactionEvent")]
public CBehTreeValCName CreateReactionEvent { get; set;}

#endregion
}
}