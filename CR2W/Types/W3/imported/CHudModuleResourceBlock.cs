using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHudModuleResourceBlock : IGuiResourceBlock
{
#region RED Properties

[REDProp("sockets", 2,0)]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("moduleName")]
public string ModuleName { get; set;}

[REDProp("moduleClass")]
public CName ModuleClass { get; set;}

#endregion
}
}