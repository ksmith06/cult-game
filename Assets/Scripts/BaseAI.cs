using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BaseAI : Controller
{

    protected GameObject target;

    void Awake()
    {
        target = GameObject.FindWithTag("Player");
    }
    
    protected Vector2 getDirectionToTarget()
    {
        Vector2 temp = new Vector2(target.transform.position.x - transform.position.x,
                                   target.transform.position.y - transform.position.y);

        temp /= (float) Math.Sqrt(temp.x * temp.x + temp.y * temp.y);

        return temp;
    }
    

    protected override void Move()
    {
        rb.AddForce(getDirectionToTarget() * speed * Time.deltaTime * rb.mass * 1000);
    }

    protected override void Attack()
    {}
}
