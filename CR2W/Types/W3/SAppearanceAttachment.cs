using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SAppearanceAttachment 
{
#region RED Properties

[REDProp("parentClass")]
public CName ParentClass { get; set;}

[REDProp("parentName")]
public CName ParentName { get; set;}

[REDProp("childClass")]
public CName ChildClass { get; set;}

[REDProp("childName")]
public CName ChildName { get; set;}

#endregion
}
}