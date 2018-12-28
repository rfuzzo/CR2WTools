using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CInterestPoint : CObject
{
#region RED Properties

[REDProp("fieldName")]
public CName FieldName { get; set;}

[REDProp("potentialField")]
public Ptr<IPotentialField> PotentialField { get; set;}

#endregion
}
}