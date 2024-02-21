using UnityEngine;

namespace Practical.Practical_7.Scripts.State
{
    public class SpiderState : IState
    {
        protected SpiderController spider;

        protected SpiderState(SpiderController spider)
        {
            this.spider = spider;
        }
        public virtual void OnEnter()
        {
            
        }

        public virtual void OnUpdate()
        {
            spider.GetNavMesh.SetDestination(spider.PlayerTransform.position);

        }

        public virtual void OnExit() {  }
    }
}