using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskCompleteOnAnimEvent : IBehTreeTask
{
#region RED Properties

[REDProp("animEvent")]
public CName AnimEvent { get; set;}

[REDProp("sucess")]
public bool Sucess { get; set;}

#endregion
}
}