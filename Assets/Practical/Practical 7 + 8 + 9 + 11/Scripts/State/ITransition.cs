namespace Practical.Practical_7.Scripts.State
{
    public interface ITransition
    {
        IState To { get; }
        IPredicate Condition { get; }
    }
}