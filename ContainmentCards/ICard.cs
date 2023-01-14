namespace ContainmentCards;

public interface ICard<T> where T: CardStartup
{
    public string Name { get; }
    public string Description { get; }
    public int Cost { get;}

    public void Startup(T startup);

}