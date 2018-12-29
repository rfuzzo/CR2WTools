using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeFocusModeAnimationTask : IBehTreeTask
{
#region RED Properties

[REDProp("isReady")]
public bool IsReady { get; set;}

[REDProp("hitAnimation")]
public CName HitAnimation { get; set;}

#endregion
}
}