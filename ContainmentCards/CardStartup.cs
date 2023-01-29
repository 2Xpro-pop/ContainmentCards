using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContainmentCards;
public abstract class CardStartup
{
    public abstract T GetProperty<T>(string key);
}

public abstract class CardStartup<TCard> : CardStartup
{
    public T GetProperty<T>(Expression<Func<TCard, T>> propertySelector)
    {
        if (propertySelector.Body is not MemberExpression property)
        {
            throw new ArgumentException("Select property!", nameof(propertySelector));
        }

        var key = property.Member.Name;

        return GetProperty<T>(key); ;
    }
}
