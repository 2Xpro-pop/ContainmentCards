using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContainmentCards;
public class ContainmentCardsContext
{
    public IServiceProvider Services { get; }

    public ContainmentCardsContext(
        IServiceProvider services
    )
    {
        Services = services;
    }

}
