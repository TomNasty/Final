using UnityEngine;

public abstract class HeroBaseState
{
    public abstract void EnterState(HeroStateManager hero, Animator animator);
    public abstract void UpdateState(HeroStateManager hero, Animator animator);
    public abstract void OnCollisionEnter(HeroStateManager hero, Animator animator);
}
