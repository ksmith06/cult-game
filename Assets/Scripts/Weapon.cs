using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    public float range;
    public float damage;
    protected float cooldown;
    public bool friendlyFire;
    public float knockback;
    protected Sprite sprite;

}
