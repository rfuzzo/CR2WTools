using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4DropPhysicsSetupDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("entityTemplatePaths")]
public Array<string> EntityTemplatePaths { get; set;}

[REDProp("dropSetups")]
public Array<Handle<CDropPhysicsSetup>> DropSetups { get; set;}

#endregion
}
}