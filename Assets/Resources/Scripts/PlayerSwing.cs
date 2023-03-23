using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwing : MonoBehaviour
{

    public DistanceJoint2D SwingJoint;
    public int sqCount = 0;
    public int sqSwung = 0;
    public GameObject sqPrefab;
    private int maxDistance = 12;
    // Start is called before the first frame update
    void Start()
    {
        sqPrefab = Resources.Load("Prefabs/Square") as GameObject;
        SwingJoint = GetComponent<DistanceJoint2D>();
        SwingJoint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")){
            SwingJoint.enabled = true;
            Debug.Log(SwingJoint.distance);
            if (SwingJoint.distance <= maxDistance){
                Debug.Log("enabled");
                SwingJoint.breakForce = 200;

            } else {
                SwingJoint.enabled = false;
            }
        
        }


        // }
        if (Input.GetKeyDown("2")){
            if (Time.timeScale == 0){
                Time.timeScale = 1;
            } else {
            Time.timeScale = 0;
            }
        }
    }
    private void OnJointBreak(float breakForce) {
        gameObject.AddComponent<DistanceJoint2D>(); 
        SwingJoint = GetComponent<DistanceJoint2D>();
        SwingJoint.enabled = false;
        // SwingJoint.connectedBody = newObject.GetComponent<Rigidbody2D>();
        
    }
}
