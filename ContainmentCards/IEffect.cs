using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainmentCards;
public interface IEffect
{
    public int Priority { get; set; }
}
