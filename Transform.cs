using System.Numerics;
using BlazorChat.Core;

namespace BlazorChat
{
    public class Transform : BaseComponent
    {
        public Transform(GameObject owner) : base(owner)
        {
        }

        public Vector2 Position { get; set; } = Vector2.Zero;
        public Vector2 Direction { get; set; } = Vector2.One;
    }
}