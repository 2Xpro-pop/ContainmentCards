using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainmentCards;
public class EffectCollection: ICollection<IEffect>
{
    private readonly List<IEffect> _effects = new();

    public IEffect? MostPriority => _effects.MaxBy(e => e.Priority);
    public IEnumerable SortedByPriority => _effects.OrderBy(e => e.Priority);
    public IEffect? Last => _effects.LastOrDefault();

    #region ICollection implementation
    public int Count => ((ICollection<IEffect>)_effects).Count;
    public bool IsReadOnly => ((ICollection<IEffect>)_effects).IsReadOnly;
    public void Add(IEffect item) => ((ICollection<IEffect>)_effects).Add(item);
    public void Clear() => ((ICollection<IEffect>)_effects).Clear();
    public bool Contains(IEffect item) => ((ICollection<IEffect>)_effects).Contains(item);
    public void CopyTo(IEffect[] array, int arrayIndex) => ((ICollection<IEffect>)_effects).CopyTo(array, arrayIndex);
    public IEnumerator<IEffect> GetEnumerator() => ((IEnumerable<IEffect>)_effects).GetEnumerator();
    public bool Remove(IEffect item) => ((ICollection<IEffect>)_effects).Remove(item);
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_effects).GetEnumerator();
    #endregion
}
