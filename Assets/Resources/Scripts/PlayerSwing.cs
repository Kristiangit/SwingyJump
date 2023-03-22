using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwing : MonoBehaviour
{

    public DistanceJoint2D SwingJoint;
    public int sqCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        SwingJoint = GetComponent<DistanceJoint2D>();
        SwingJoint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")){
            SwingJoint.enabled = true;
        }
        if (Input.GetKeyDown("f")){
            
            GameObject newObject = Instantiate(Resources.Load("/Prefabs/Square.prefab") as GameObject, new Vector2(gameObject.transform.position.x + 12f, 4f), Quaternion.identity);

            gameObject.AddComponent<DistanceJoint2D>(); 
            SwingJoint = GetComponent<DistanceJoint2D>();
            SwingJoint.breakForce = 400;
            SwingJoint.connectedBody = newObject.GetComponent<Rigidbody2D>();
        }
        if (Input.GetKeyDown("2")){
            if (Time.timeScale == 0){
                Time.timeScale = 1;
            } else {
            Time.timeScale = 0;
            }
        }
    }
}
