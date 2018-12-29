using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CJobTreeNode : CObject
{
#region RED Properties

[REDProp("onEnterAction")]
public Ptr<CJobAction> OnEnterAction { get; set;}

[REDProp("onLeaveAction")]
public Ptr<CJobAction> OnLeaveAction { get; set;}

[REDProp("onFastLeaveAction")]
public Ptr<CJobForceOutAction> OnFastLeaveAction { get; set;}

[REDProp("childNodes")]
public Array<Ptr<CJobTreeNode>> ChildNodes { get; set;}

[REDProp("validCategories")]
public Array<CName> ValidCategories { get; set;}

[REDProp("selectionMode")]
public EJobTreeNodeSelectionMode SelectionMode { get; set;}

[REDProp("iterations")]
public uint Iterations { get; set;}

[REDProp("leftItem")]
public CName LeftItem { get; set;}

[REDProp("rightItem")]
public CName RightItem { get; set;}

[REDProp("looped")]
public bool Looped { get; set;}

#endregion
}
}