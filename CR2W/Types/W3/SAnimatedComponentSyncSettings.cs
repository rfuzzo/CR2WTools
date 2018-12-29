using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SAnimatedComponentSyncSettings 
{
#region RED Properties

[REDProp("instanceName")]
public CName InstanceName { get; set;}

[REDProp("syncAllInstances")]
public bool SyncAllInstances { get; set;}

[REDProp("syncEngineValueSpeed")]
public bool SyncEngineValueSpeed { get; set;}

#endregion
}
}