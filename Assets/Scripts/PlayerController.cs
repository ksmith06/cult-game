using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : Controller
{

    [SerializeField] private InputActionAsset controls;
    private InputActionMap map;
    private InputAction movement;
    private Transform transform;
    private Rigidbody2D rb;

    void Awake()
    {
        //controls = GetComponent<InputActionAsset>();
        map = controls.FindActionMap("Gameplay");
        movement = map.FindAction("Movement");
        rb = GetComponent<Rigidbody2D>();
        transform = gameObject.transform;
        map.Enable();
    }
    protected override void Move()
    {
        rb.AddForce(movement.ReadValue<Vector2>() * speed * Time.deltaTime);
        //transform.position += (new Vector3(movement.ReadValue<Vector2>().x, movement.ReadValue<Vector2>().y, 0) * speed * Time.deltaTime);
    }

    protected override void Attack()
    {
        
    }
}
