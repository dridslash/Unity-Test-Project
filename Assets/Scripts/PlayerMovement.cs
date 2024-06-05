using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody PlayerRidgidBody;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRidgidBody.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            PlayerRidgidBody.velocity = transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.S)){
            PlayerRidgidBody.velocity = -transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.D)){
            PlayerRidgidBody.velocity = Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.A)){
            PlayerRidgidBody.velocity = Vector3.left;
        }
    }
}
