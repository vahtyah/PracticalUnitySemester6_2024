namespace Practical.Practical_7.Scripts.State
{
    public class StateComponent
    {
        private StateMachine stateMachine = new();

        public StateComponent(SpiderController spider)
        {
            var moveState = new SpiderMoveState(spider);
            var attackState = new SpiderAttackState(spider);
            var dieState = new SpiderDieState(spider);
            
            stateMachine.At(moveState, attackState, new FuncPredicate(spider.CanAttack));
            stateMachine.At(attackState, moveState, new FuncPredicate((() => !spider.CanAttack())));
            stateMachine.Any(dieState, new FuncPredicate((() => spider.IsDie)));
            
            stateMachine.SetState(moveState);
        }
        
        public void Update() { stateMachine.Update(); }
    }
}