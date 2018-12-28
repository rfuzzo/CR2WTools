using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeDecoratorSnapToNavigationDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("performActivation")]
public bool PerformActivation { get; set;}

[REDProp("snapOnActivation")]
public bool SnapOnActivation { get; set;}

[REDProp("performDeactivation")]
public bool PerformDeactivation { get; set;}

[REDProp("snapOnDeactivation")]
public bool SnapOnDeactivation { get; set;}

#endregion
}
}