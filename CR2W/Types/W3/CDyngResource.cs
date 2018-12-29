using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CDyngResource : CResource
{
#region RED Properties

[REDProp("name")]
public string Name { get; set;}

[REDProp("dyngSkeleton")]
public Handle<CSkeleton> DyngSkeleton { get; set;}

[REDProp("nodeNames")]
public Array<string> NodeNames { get; set;}

[REDProp("nodeParents")]
public Array<string> NodeParents { get; set;}

[REDProp("nodeMasses")]
public Array<float> NodeMasses { get; set;}

[REDProp("nodeStifnesses")]
public Array<float> NodeStifnesses { get; set;}

[REDProp("nodeDistances")]
public Array<float> NodeDistances { get; set;}

[REDProp("nodeTransforms")]
public Array<Matrix> NodeTransforms { get; set;}

[REDProp("linkTypes")]
public Array<Int32> LinkTypes { get; set;}

[REDProp("linkLengths")]
public Array<float> LinkLengths { get; set;}

[REDProp("linkAs")]
public Array<Int32> LinkAs { get; set;}

[REDProp("linkBs")]
public Array<Int32> LinkBs { get; set;}

[REDProp("triangleAs")]
public Array<Int32> TriangleAs { get; set;}

[REDProp("triangleBs")]
public Array<Int32> TriangleBs { get; set;}

[REDProp("triangleCs")]
public Array<Int32> TriangleCs { get; set;}

[REDProp("collisionParents")]
public Array<string> CollisionParents { get; set;}

[REDProp("collisionRadiuses")]
public Array<float> CollisionRadiuses { get; set;}

[REDProp("collisionHeights")]
public Array<float> CollisionHeights { get; set;}

[REDProp("collisionTransforms")]
public Array<Matrix> CollisionTransforms { get; set;}

#endregion
}
}