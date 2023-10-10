using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAI : Controller
{

    protected GameObject target;

    void Awake()
    {
        target = GameObject.FindWithTag("Player");
    }

    protected override void Move()
    {
        
    }
}
