using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ContainmentCards.Effectable
{
    public interface IEffectable
    {
        public LinkedList<IEffect> Effects { get; }
    }
}
