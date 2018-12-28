using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SSoundAmbientDynamicSoundEvents 
{
#region RED Properties

[REDProp("eventName")]
public StringAnsi EventName { get; set;}

[REDProp("repeatTime")]
public float RepeatTime { get; set;}

[REDProp("repeatTimeVariance")]
public float RepeatTimeVariance { get; set;}

[REDProp("triggerOnActivation")]
public bool TriggerOnActivation { get; set;}

#endregion
}
}