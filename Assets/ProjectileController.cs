using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //to do
    //playermove kanan kiri
    //shoot projectile
    //instantiate enemy
    //enemy move
    //score ui
    //main menu
    //timer ui
    //hungerbar ui

    private Vector3 moveDir;
    private Transform _model;
    private Rigidbody _rb;
    public float speed;

    private void Awake()
    {
        _model = GetComponent<Transform>();
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        moveDir = new Vector3(0f, 0f, horizontal);

        Vector3 velocity = moveDir * speed;
        _rb.velocity = velocity;
    }
}
