using UnityEngine;
using System.Collections;

public class playercontroller : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    //Update called before rendering a frame
    void FixedUpdate () //Called before performing and physics calculations
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }
}
