using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    public float jump;
    public bool isJumping;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(speed, rb.velocity.y);

        if ((Input.GetButtonDown("Jump") || Input.GetKeyDown("up") || Input.GetKeyDown("w")) && isJumping == false){
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
        if (Input.GetKeyDown("a")){
            gameObject.transform.position = new Vector2(0f, 0f);
        }


    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground")){
            isJumping = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground")){
            // isJumping = true;
        }
    }
}
