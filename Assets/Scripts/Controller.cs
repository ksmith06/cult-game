using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{

    [SerializeField] protected float speed;
    [SerializeField] protected float strength;
    protected Weapon currentWeapon;
    protected abstract void Move();
    protected abstract void Attack();
    protected Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
