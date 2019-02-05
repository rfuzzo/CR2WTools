using System;
using System.Numerics;

namespace RED
{
    /// <summary>
    /// Represents an elemental based redengine transformation, 
    /// with position, rotation, and scale values as 3 point elemental vectors.
    /// </summary>
    public struct EngineTransform
    {
        public Vector3 Scale;
        public Vector3 Rotation;
        public Vector3 Position;

        public override string ToString()
        {
            return String.Format("[Scale: ({0},{1},{2}) Rotation: ({3},{4},{5}) Position: ({6},{7},{8})]", 
                Scale.X, Scale.Y, Scale.Z, Rotation.X, Rotation.Y, Rotation.Z, Position.X, Position.Y, Position.Z);
        }
    }
}