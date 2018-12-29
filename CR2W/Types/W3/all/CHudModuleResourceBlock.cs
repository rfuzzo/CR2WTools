using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHudModuleResourceBlock : IGuiResourceBlock
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("moduleName")]
public string ModuleName { get; set;}

[REDProp("moduleClass")]
public CName ModuleClass { get; set;}

#endregion
}
}