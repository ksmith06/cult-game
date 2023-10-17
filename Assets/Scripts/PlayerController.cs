using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : Controller
{

    [SerializeField] private InputActionAsset controls;
    [SerializeField] private Weapon[] weapons = new Weapon[2];
    private InputActionMap map;
    private InputAction movement;

    void Awake()
    {
        //controls = GetComponent<InputActionAsset>();
        map = controls.FindActionMap("Gameplay");
        movement = map.FindAction("Movement");
        map.Enable();
    }
    protected override void Move()
    {
        rb.AddForce(movement.ReadValue<Vector2>() * speed * Time.deltaTime * rb.mass * 1000);
    }

    protected override void Attack()
    {
        
    }
}
