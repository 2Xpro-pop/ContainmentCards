using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainmentCards;
public abstract class CardStartup
{
    public abstract T GetProperty<T>(string key)
    {
        /* Return generic type T. */
    }
}
