using UnityEngine;
// this is dodging attacks. You are generally invulnerable in this state.

public class HeroDodgeState : HeroBaseState
{
    public override void EnterState(HeroStateManager hero, Animator animator)
    {
        Debug.Log("dodge");
        animator.Play("Dodge");
    }
    public override void UpdateState(HeroStateManager hero, Animator animator)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).length <= animator.GetCurrentAnimatorStateInfo(0).normalizedTime)
        {
            hero.SwitchState(hero.idleState);
        }
    }
    public override void OnCollisionEnter(HeroStateManager hero, Animator animator)
    {

    }
}
