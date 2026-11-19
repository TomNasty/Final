using UnityEngine;
// this is parrying attacks. If you are idle, you can parry an attack and knock the boss off balance.

public class HeroParryState : HeroBaseState
{
    public override void EnterState(HeroStateManager hero, Animator animator)
    {
        Debug.Log("parry");
        animator.Play("Parry");
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
