using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public Transform Aim;
    private float AttackRadius;

    public void OnAttack()
    {
        if (Vector3.Distance(Aim.transform.position, transform.position) <= AttackRadius)
        {
            Animator.SetBool(Attack, true);
            Animator.SetBool(Walking, false);
        }

        else
        {
            Animator.SetBool(Attack, false);
            Animator.SetBool(Walking, true);
        }
    }
}
