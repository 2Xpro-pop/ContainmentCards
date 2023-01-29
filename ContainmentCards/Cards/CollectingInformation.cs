using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainmentCards.Cards;
public class CollectingInformation : ICard
{
    public string Name { get; set; }

    public string Description { get; set; }
    
    public int Cost { get; set; }
}