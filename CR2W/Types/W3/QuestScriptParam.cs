using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class QuestScriptParam 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

/*[REDProp("value")]
public CVariant Value { get; set;}*/

[REDProp("softHandle")]
public bool SoftHandle { get; set;}

#endregion
}
}