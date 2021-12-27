using System.Collections;
using System.Collections.Generic;
using Character.Options;
using UnityEngine;

public abstract class CharactersController : MonoBehaviour
{
    public DamageController Damage;
    public AttackController Attack;
    public HealthController Health;
    public AnimationController Animation;
    public IMove Movement;

}
