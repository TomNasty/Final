using UnityEngine;
//NOTE: i think making sure the right animation is playing is key
// this is not moving at all. Idle animation and idle break may play here.
public class HeroIdleState : HeroBaseState
{
    public override void EnterState(HeroStateManager hero, Animator animator)
    {
        Debug.Log("idle");
        animator.SetInteger("AnimID", 0);
    }
    public override void UpdateState(HeroStateManager hero, Animator animator)
    {

        /*if (Input.GetKey(robot.weakBtn))
        {
            robot.SwitchState(robot.punchState);
        }
        else if (Input.GetKey(robot.strongBtn))
        {
            robot.SwitchState(robot.punchFinal);
        }*/
    }
    public override void OnCollisionEnter(HeroStateManager hero, Animator animator)
    {
        //robot.CollisionFunc(collid.launchPow, collid.damage);
        //hero.SwitchState(hero.hitState);
    }
}
