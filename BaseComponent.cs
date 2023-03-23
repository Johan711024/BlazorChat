using System;
using System.Threading.Tasks;
using BlazorChat.Core;
using BlazorChat.Core.Components;

namespace BlazorChat
{
    public abstract class BaseComponent : IComponent
    {
        protected BaseComponent(GameObject owner)
        {
            this.Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            this.Owner.Components?.Add(this);
        }

        public virtual async ValueTask Update(GameContext game)
        {
        }

        public GameObject Owner { get; }
    }
}