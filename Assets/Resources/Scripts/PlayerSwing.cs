using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwing : MonoBehaviour
{

    public DistanceJoint2D SwingJoint;
    // Start is called before the first frame update
    void Start()
    {
        SwingJoint = GetComponent<DistanceJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
