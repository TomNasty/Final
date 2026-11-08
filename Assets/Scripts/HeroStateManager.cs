using UnityEngine;
// this manages all the states.

public class HeroStateManager : MonoBehaviour
{
    Animator animator;

    public int hp = 1000;
    //controls
    public string forwardBtn = "w";
    public string leftBtn = "a";
    public string backBtn = "s";
    public string rightBtn = "d";
    public string attackBtn = "i";
    public string dodgeBtn = "o";
    public string parryBtn = "p";
    //hitboxes

    //states
    HeroBaseState currentState;//reference to active state
    public HeroIdleState idleState = new HeroIdleState();
    public HeroSwimState swimState = new HeroSwimState();
    public HeroDodgeState dodgeState = new HeroDodgeState();
    public HeroAttackState attackState = new HeroAttackState();
    public HeroDamagedState damagedState = new HeroDamagedState();
    public HeroParryState parryState = new HeroParryState();
    public HeroGetUpState getUpState = new HeroGetUpState();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        //default state
        //currentState = idleState;
        currentState.EnterState(this, animator);
    }
    /*public void IveBeenHit(Collid collid)
    {
        Debug.Log(collid);
        currentState.OnCollisionEnter(this, collid, animator);
    }*/
    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this, animator);
    }

    public void SwitchState(HeroBaseState state)
    {
        currentState = state;
        state.EnterState(this, animator);
    }
    public void CollisionFunc(int launchPow, int damage)
    {
        /*hp -= damage;
        if (launchPow == 1)
        {
            dir = new Vector3(-0.005f * playerFace, 0.01f, 0.0f);
        }
        else if (launchPow == 2)
        {
            dir = new Vector3(-0.01f * playerFace, 0.005f, 0.0f);
        }
        else if (launchPow == 3)
        {
            dir = new Vector3(-0.02f * playerFace, 0.02f, 0.0f);
        }
        else if (launchPow == 4)
        {
            dir = new Vector3(-0.05f * playerFace, 0.02f, 0.0f);
        }*/
    }
}
