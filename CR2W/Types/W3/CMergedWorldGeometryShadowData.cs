using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMergedWorldGeometryShadowData : IMergedWorldGeometryData
{
#region RED Properties

[REDProp("minExtractMeshRadius")]
public float MinExtractMeshRadius { get; set;}

[REDProp("minMergeMeshRadius")]
public float MinMergeMeshRadius { get; set;}

[REDProp("maxMeshTriangles")]
public uint MaxMeshTriangles { get; set;}

[REDProp("mergeCascade1")]
public bool MergeCascade1 { get; set;}

[REDProp("mergeCascade2")]
public bool MergeCascade2 { get; set;}

[REDProp("mergeCascade3")]
public bool MergeCascade3 { get; set;}

[REDProp("mergeCascade4")]
public bool MergeCascade4 { get; set;}

[REDProp("excludeProxies")]
public bool ExcludeProxies { get; set;}

[REDProp("streamingDistance")]
public float StreamingDistance { get; set;}

[REDProp("useInCascade1")]
public bool UseInCascade1 { get; set;}

[REDProp("useInCascade2")]
public bool UseInCascade2 { get; set;}

[REDProp("useInCascade3")]
public bool UseInCascade3 { get; set;}

[REDProp("useInCascade4")]
public bool UseInCascade4 { get; set;}

[REDProp("killZ")]
public float KillZ { get; set;}

[REDProp("killAngle")]
public float KillAngle { get; set;}

#endregion
}
}