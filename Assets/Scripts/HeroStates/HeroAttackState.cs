using UnityEngine;
// this is attacking. 

public class HeroAttackState : HeroBaseState
{
    public override void EnterState(HeroStateManager hero, Animator animator)
    {
        Debug.Log("attack");
        animator.Play("Stab");
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
