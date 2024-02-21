namespace Practical.Practical_7.Scripts.State
{
    public class SpiderMoveState : SpiderState
    {
        public override void OnEnter()
        {
            base.OnEnter();
            spider.PlayAnim("Crawl Forward Fast In Place");
        }

        public SpiderMoveState(SpiderController spider) : base(spider)
        {
        }
    }
}