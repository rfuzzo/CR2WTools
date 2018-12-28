using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEDSavedAnswer 
{
#region RED Properties

[REDProp("questionName")]
public CName QuestionName { get; set;}

[REDProp("answer")]
public string Answer { get; set;}

#endregion
}
}