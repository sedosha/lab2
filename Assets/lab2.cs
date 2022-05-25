using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class lab2 : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;
    private float Force = 5;
    private bool _isGrounded = true;
    private float _gravity = 5;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal") * Force * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * Force * Time.deltaTime;
        transform.Translate(h, 0, v);

        if (_isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(new Vector3(0, _gravity, 0), ForceMode.Impulse);
            _isGrounded = false;
        }

    }
}
