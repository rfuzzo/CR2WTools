using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;

namespace CR2W.Types.W3
{
    class CRagdoll : CResource
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

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);
            /* - TODO:
             *   Read the XML file embedded inside.
             */
        }
    }
}
