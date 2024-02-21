namespace Practical.Practical_7.Scripts.State
{
    public class SpiderDieState : SpiderState
    {
        public override void OnEnter()
        {
            base.OnEnter();
            spider.PlayAnim("Die");
            spider.GetNavMesh.isStopped = true;
        }

        public SpiderDieState(SpiderController spider) : base(spider)
        {
        }
    }
}