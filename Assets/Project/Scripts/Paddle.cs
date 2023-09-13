using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int playerNumber;

    private Rigidbody paddleRigidbody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        paddleRigidbody = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal" + playerNumber) * speed;
        float verticalMovement = Input.GetAxis("Vertical" + playerNumber) * speed;

        paddleRigidbody.velocity = new Vector3 (horizontalMovement, 0, verticalMovement);
    }
}
