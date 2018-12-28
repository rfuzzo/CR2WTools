using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4TutorialSystem : IGameSystem
{
#region RED Properties

[REDProp("needsTickEvent")]
public bool NeedsTickEvent { get; set;}

#endregion
}
}