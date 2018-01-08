using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wmotion : MonoBehaviour {

    public WheelCollider wheel;
    
    void Start()
    {
    }
    private Vector3 wposition = new Vector3(); //
    private Quaternion wrotation = new Quaternion(); //this allows the wheel to turn around like an actual car
    // Update is called once per frame
    void Update()
    {
        //stores the function in the variable 
        wheel.GetWorldPose(out wposition, out wrotation);
        //assinging the position of the wheels with the variables 
        //thus allowing the wheels to have a spinning motion
        transform.position = wposition;
        transform.rotation = wrotation;
    }
}
