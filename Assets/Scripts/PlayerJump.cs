using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidBody;
    private float jumpForce = 4f;
    // Update is called once per frame
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();  
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }
    private void Jump()
    {
        rigidBody.AddForce(UnityEngine.Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
