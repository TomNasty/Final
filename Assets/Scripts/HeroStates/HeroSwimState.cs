using UnityEngine;
// this is regular movement.

public class HeroSwimState : HeroBaseState
{
    float left = 0.0f;
    float right = 0.0f;
    float forward = 0.0f;
    float back = 0.0f;
    public override void EnterState(HeroStateManager hero, Animator animator)
    {
        Debug.Log("swim");
        animator.Play("Swim");
    }
    public override void UpdateState(HeroStateManager hero, Animator animator)
    {
        left = 0.0f;
        right = 0.0f;
        forward = 0.0f;
        back = 0.0f;
        if (Input.GetKey(hero.leftBtn)) {
            left = 1.0f;
        }
        if (Input.GetKey(hero.rightBtn))
        {
            right = -1.0f;
        }
        if (Input.GetKey(hero.backBtn))
        {
            back = 1.0f;
        }
        if (Input.GetKey(hero.forwardBtn))
        {
            forward = -1.0f;
        }
        hero.MovePlayer(left, right, forward, back);
        if (!Input.GetKey(hero.leftBtn) && !Input.GetKey(hero.rightBtn) && !Input.GetKey(hero.forwardBtn) && !Input.GetKey(hero.backBtn))
        {
            hero.SwitchState(hero.idleState);
        }
    }
    public override void OnCollisionEnter(HeroStateManager hero, Animator animator)
    {

    }
}
