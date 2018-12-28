using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEntityAppearance 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("voicetag")]
public CName Voicetag { get; set;}

[REDProp("appearanceParams")]
public Array<Ptr<CEntityTemplateParam>> AppearanceParams { get; set;}

[REDProp("useVertexCollapse")]
public bool UseVertexCollapse { get; set;}

[REDProp("usesRobe")]
public bool UsesRobe { get; set;}

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("includedTemplates")]
public Array<Handle<CEntityTemplate>> IncludedTemplates { get; set;}

[REDProp("collapsedComponents")]
public Array<CName> CollapsedComponents { get; set;}

#endregion
}
}