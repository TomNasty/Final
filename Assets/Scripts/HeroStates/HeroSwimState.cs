using UnityEngine;
// this is regular movement.

public class HeroSwimState : HeroBaseState
{
    public override void EnterState(HeroStateManager hero, Animator animator)
    {
        Debug.Log("swim");
        animator.Play("Swim");
    }
    public override void UpdateState(HeroStateManager hero, Animator animator)
    {

        if (!Input.GetKey(hero.leftBtn) && !Input.GetKey(hero.rightBtn) && !Input.GetKey(hero.forwardBtn) && !Input.GetKey(hero.backBtn))
        {
            hero.SwitchState(hero.idleState);
        }
    }
    public override void OnCollisionEnter(HeroStateManager hero, Animator animator)
    {

    }
}
