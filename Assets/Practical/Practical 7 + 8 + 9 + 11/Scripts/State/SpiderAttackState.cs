using System.Collections;
using UnityEngine;

namespace Practical.Practical_7.Scripts.State
{
    public class SpiderAttackState : SpiderState
    {
        public override void OnEnter()
        {
            base.OnEnter();
            spider.PlayAnim("Bite Attack");
        }
        public SpiderAttackState(SpiderController spider) : base(spider)
        {
        }
    }
}