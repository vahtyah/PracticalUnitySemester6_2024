namespace Practical.Practical_7.Scripts.State
{
    public interface IState
    {
        void OnEnter();
        void OnUpdate();
        void OnExit();
    }
}