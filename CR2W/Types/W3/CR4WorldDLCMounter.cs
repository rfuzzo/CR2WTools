using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4WorldDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("worlds")]
public Array<Handle<CR4WorldDescriptionDLC>> Worlds { get; set;}

#endregion
}
}