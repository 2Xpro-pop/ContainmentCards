using System;
using System.Collections.Generic;
using System.Text;

namespace ContainmentCards.Effectable
{
    public class GetDefaultStrategy
    {
        public static readonly GetDefaultStrategy Cached = new GetDefaultStrategy();
        public static readonly GetDefaultStrategy NonModified = new GetDefaultStrategy();

        public static GetDefaultStrategy ByModificator(Modificator modificator) => new ByModificatorStrategy();

        internal class ByModificatorStrategy : GetDefaultStrategy
        {
            public Modificator Modificator { get; }
        }
    }
}
