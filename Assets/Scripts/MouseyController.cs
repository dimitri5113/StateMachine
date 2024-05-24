using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public enum IAState
{
    None,
    Idle,
    HappyWalk,
    SillyDAncing,
    Waving,
    JoyfulJump


}
public class MouseyController : MonoBehaviour
{
    private IAState state = IAState.None;
    [SerializeField] public Animator animator;
    [SerializeField] public NavMeshAgent agent;
    [SerializeField] public GameObject waypoint;
    public bool IsWaving;
    public bool IsJoyfulJump;
    void Start()
    {
        
    }

    void Update()
    {
        ChekTransition();
        Behaviour();
    }

    private void Behaviour()
    {
        switch (state)
        {
            case IAState.None:

                break;
            case IAState.Idle:

                break;
            case IAState.HappyWalk:
                agent.SetDestination(waypoint.transform.position);
                break;
            case IAState.SillyDAncing:

                break;
            case IAState.Waving:

                break;
            case IAState.JoyfulJump:

                break;
        }
    }

    private void ChekTransition()
    {
        switch (state)
        {
            case IAState.None:
                if (IsJoyfulJump)
                {
                    state = IAState.JoyfulJump;
                    animator.SetBool("IsContact", true);
                }

                break;
            case IAState.Idle:
                if (IsJoyfulJump)
                {
                    state = IAState.JoyfulJump;
                    animator.SetBool("IsContact", true);
                }

                break;
            case IAState.HappyWalk:
                if (IsJoyfulJump)
                {
                    state = IAState.JoyfulJump;
                    animator.SetBool("IsContact", true);
                }

                break;
            case IAState.SillyDAncing:
                if (IsJoyfulJump)
                {
                    state = IAState.JoyfulJump;
                    animator.SetBool("IsContact", true);
                }

                break;
            case IAState.Waving:
                if (IsJoyfulJump)
                {
                    state = IAState.JoyfulJump;
                    animator.SetBool("IsContact", true);
                }

                break;
            case IAState.JoyfulJump:
                if (!IsJoyfulJump)
                {
                    state = IAState.HappyWalk;
                    animator.SetBool("IsContact", false);
                }

                break;
        }
    }
}
