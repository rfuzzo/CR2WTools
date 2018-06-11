using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CR2W.IO;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class CRagdoll : CResource
    {
        float WindScaler { get; set; }
        float DensityScaler { get; set; }
        float AutoStopDelay { get; set; }
        float AutoStopTime { get; set; }
        float AutoStopSpeed { get; set; }
        bool ResetDampingAfterStop { get; set; }
        bool ForceWakeUpOnAttach { get; set; }
        //CPhysicalCollision customDynamicGroup { get; set; }
        bool DisableConstrainsTwistAxis { get; set; }
        bool DisableConstrainsSwing1Axis { get; set; }
        bool DisableConstrainsSwing2Axis { get; set; }
        float JointBounce { get; set; }
        float ModifyTwistLower { get; set; }
        float ModifyTwistUpper { get; set; }
        float ModifySwingY { get; set; }
        float ModifySwingZ { get; set; }
        Int32 ProjectionIterations { get; set; }

        XmlDocument Data { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            //Parse the bytes at the beginning which will map the class structure
            base.ParseBytes(br, size);

            //Now read the XML document at the end of the object data
            Data = br.ReadXMLDocument();
        }
    }
}
