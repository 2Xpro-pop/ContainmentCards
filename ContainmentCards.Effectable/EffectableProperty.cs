using System;
using System.Collections.Generic;
using System.Text;

namespace ContainmentCards.Effectable
{
    public class EffectableProperty: IEffectable
    {
        protected object value;
        protected object cachedValue;

        protected GetDefaultStrategy getDefaultStrategy;

        public EffectableProperty(object value): this(value, GetDefaultStrategy.Cached)
        {
        }

        public EffectableProperty(object value, GetDefaultStrategy getDefaultStrategy)
        {
            this.value = value;
            cachedValue = value;

            this.getDefaultStrategy = getDefaultStrategy;
        }

        public virtual string Name { get; set; }
        public LinkedList<IEffect> Effects { get; } = new LinkedList<IEffect>();
    }

    public class EffectableProperty<T> : EffectableProperty
    {
        protected new T value;

        public EffectableProperty():base(default(T))
        {
        }
    }
}
