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
        [W3Type("windScaler")]
        public float WindScaler { get; set; }

        [W3Type("densityScaler")]
        public float DensityScaler { get; set; }

        [W3Type("autoStopDelay")]
        public float AutoStopDelay { get; set; }

        [W3Type("autoStopTime")]
        public float AutoStopTime { get; set; }

        [W3Type("autoStopSpeed")]
        public float AutoStopSpeed { get; set; }

        [W3Type("resetDampingAfterStop")]
        public bool ResetDampingAfterStop { get; set; }

        [W3Type("forceWakeUpOnAttach")]
        public bool ForceWakeUpOnAttach { get; set; }

        //No idea about this type - rttidump does not have it.
        //and no w2ragdoll file has this type used.
        //[W3Type("customDynamicGroup")]
        //public CPhysicalCollision CustomDynamicGroup { get; set; }

        [W3Type("disableConstrainsTwistAxis")]
        public bool DisableConstrainsTwistAxis { get; set; }

        [W3Type("disableConstrainsSwing1Axis")]
        public bool DisableConstrainsSwing1Axis { get; set; }

        [W3Type("disableConstrainsSwing2Axis")]
        public bool DisableConstrainsSwing2Axis { get; set; }

        [W3Type("jointBounce")]
        public float JointBounce { get; set; }

        [W3Type("modifyTwistLower")]
        public float ModifyTwistLower { get; set; }

        [W3Type("modifyTwistUpper")]
        public float ModifyTwistUpper { get; set; }

        [W3Type("modifySwingY")]
        public float ModifySwingY { get; set; }

        [W3Type("modifySwingZ")]
        public float ModifySwingZ { get; set; }

        [W3Type("projectionIterations")]
        public Int32 ProjectionIterations { get; set; }

        public XmlDocument Data { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            //Parse the bytes at the beginning which will map the class structure
            base.ParseBytes(br, size);

            //Now read the XML document at the end of the object data
            Data = br.ReadXMLDocument();
        }
    }
}