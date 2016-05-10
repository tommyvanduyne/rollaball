using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//what up homie?
public class playercontroller : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    private int count;
    public Text countText;
    public Text winText;
    
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";
    }
    //Update called before rendering a frame
    void FixedUpdate () //Called before performing and physics calculations
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
