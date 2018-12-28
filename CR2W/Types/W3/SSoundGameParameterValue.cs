using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SSoundGameParameterValue 
{
#region RED Properties

[REDProp("gameParameterName")]
public StringAnsi GameParameterName { get; set;}

[REDProp("gameParameterValue")]
public float GameParameterValue { get; set;}

#endregion
}
}