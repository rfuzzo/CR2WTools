using System;
using System.Numerics;

namespace RED
{
    /// <summary>
    /// Represents a quaternion based redengine transformation, 
    /// with position and scale values as 3 point elemental vectors and rotation as a quaterion vector.
    /// </summary>
    public struct EngineQsTransform
    {
        public Vector3    Scale;
        public Quaternion Rotation;
        public Vector3    Position;

        public override string ToString()
        {
            return String.Format("[Scale: ({0},{1},{2}) Rotation: ({3},{4},{5},{6}) Position: ({7},{8},{9})]",
                Scale.X, Scale.Y, Scale.Z, Rotation.X, Rotation.Y, Rotation.Z, Rotation.W, Position.X, Position.Y, Position.Z);
        }
    }
}
