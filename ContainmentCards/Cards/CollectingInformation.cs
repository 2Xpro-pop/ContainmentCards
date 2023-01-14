using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainmentCards.Startups;

namespace ContainmentCards.Cards;
public class CollectingInformation : ICard<SimpleStartup>
{
    public string Name { get; set; }

    public string Description { get; set; }
    
    public int Cost { get; set; }

    public void Startup(SimpleStartup startup)
    {
        Name = startup.Name;
        Description = startup.Description;
        Cost = startup.Cost;
    }
}