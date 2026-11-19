using UnityEngine;
//NOTE: i think making sure the right animation is playing is key
// this is not moving at all. Idle animation and idle break may play here.
public class HeroIdleState : HeroBaseState
{
    public override void EnterState(HeroStateManager hero, Animator animator)
    {
        Debug.Log("idle");
        animator.Play("Idle");
    }
    public override void UpdateState(HeroStateManager hero, Animator animator)
    {

        if (Input.GetKey(hero.attackBtn))
        {
            hero.SwitchState(hero.attackState);
        }
        else if (Input.GetKey(hero.dodgeBtn))
        {
            hero.SwitchState(hero.dodgeState);
        }
        else if (Input.GetKey(hero.parryBtn))
        {
            hero.SwitchState(hero.parryState);
        }
        else if (Input.GetKey(hero.leftBtn) || Input.GetKey(hero.rightBtn) || Input.GetKey(hero.forwardBtn) || Input.GetKey(hero.backBtn))
        {
            hero.SwitchState(hero.swimState);
        }
    }
    public override void OnCollisionEnter(HeroStateManager hero, Animator animator)
    {
        //robot.CollisionFunc(collid.launchPow, collid.damage);
        //hero.SwitchState(hero.hitState);
    }
}
