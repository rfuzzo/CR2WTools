using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestThread : CObject
{
#region RED Properties

[REDProp("suspendedScopesData")]
public Array<SQuestThreadSuspensionData> SuspendedScopesData { get; set;}

#endregion
}
}