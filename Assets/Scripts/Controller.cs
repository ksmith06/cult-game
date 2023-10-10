using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{

    [SerializeField] protected float speed;
    [SerializeField] protected float strength;
    protected abstract void Move();
    protected abstract void Attack();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
