using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float startHitPoints;
    public float maxHitPoints;

    public abstract void ResetCharacter();
    public abstract IEnumerator DamageCharacter(int damage, float interval);

    public virtual void KillCharacter()
    {
        Destroy(gameObject);
    }

    private void OnEnable()
    {
        ResetCharacter();
    }
}
