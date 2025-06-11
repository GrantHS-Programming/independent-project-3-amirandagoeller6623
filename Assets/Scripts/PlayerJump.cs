using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidBody;
    private float jumpForce = 4f;
    private GroundController _groundController;
    // Update is called once per frame
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();  
        _groundController = GetComponent<GroundController>();
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
