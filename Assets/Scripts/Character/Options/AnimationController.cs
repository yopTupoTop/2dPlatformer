using System;
using System.Collections;
using System.Collections.Generic;
using Animation;
using Unity.IO.LowLevel.Unsafe;
using UnityEditor.Animations;
using UnityEngine;

public class AnimationController : MonoBehaviour, IAnimationStateReader
{
    private static readonly int Die = Animator.StringToHash("Die");
    private static readonly int Attack = Animator.StringToHash("Attack");
    private static readonly int IsMoving = Animator.StringToHash("IsMoving");
    private static readonly int Speed = Animator.StringToHash("Speed");

    private readonly int _idleStateHash = Animator.StringToHash("idle");
    private readonly int _attackStateHash = Animator.StringToHash("attack");
    private readonly int _walkingStateHash = Animator.StringToHash("move");
    private readonly int _deathStateHash = Animator.StringToHash("die");

    private Animator _animator;

    public event Action<AnimatorState> StateEntered;
    public event Action<AnimatorState> StateExited;
    
    public AnimatorState State { get; private set; }

    private void Awake() => _animator = GetComponent<Animator>();
    
    public void PlayDeath() => _animator.SetTrigger(Die);

    public void Move(float speed)
    {
        _animator.SetBool(IsMoving, true);
        _animator.SetFloat(Speed, speed);
    }

    public void StopMoving() => _animator.SetBool(IsMoving, false);

    public void PlayAttack() => _animator.SetTrigger(Attack);

    public void EnteredState(int stateHash)
    {
        State = StateFor(stateHash);
        StateEntered?.Invoke(State);
    }

    public void ExitedState(int stateHash) => StateExited?.Invoke(State);

    private AnimatorState StateFor(object stateHash)
    {
        AnimatorState state;
        if (stateHash == (object) _idleStateHash)
            state = AnimatorState.Idle;
        else if (stateHash == (object) _attackStateHash)
            state = AnimatorState.Attack;
        else if (stateHash == (object) _walkingStateHash)
            state = AnimatorState.Walking;
        else if (stateHash == (object) _deathStateHash)
            state = AnimatorState.Died;
        else
            state = AnimatorState.Unknown;

        return state;
    }
}
