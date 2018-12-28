using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SSoundParameterCullSettings 
{
#region RED Properties

[REDProp("gameParameterName")]
public StringAnsi GameParameterName { get; set;}

[REDProp("gameParameterCullValue")]
public float GameParameterCullValue { get; set;}

[REDProp("invertCullCheck")]
public bool InvertCullCheck { get; set;}

#endregion
}
}