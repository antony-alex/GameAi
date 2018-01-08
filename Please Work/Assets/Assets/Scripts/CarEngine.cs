using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarEngine : MonoBehaviour
{

    public Transform path1;
    private List<Transform> node;
    private int onNode = 0;
    public float MaxAngleSteer = 0f;
    public WheelCollider frontLeftwheel;
    public WheelCollider frontRightwheel;
    public float fullMotor = 60f;
    public float speed;
    public float topspeed = 100f;

    public Vector3 masscentre;

    void Start()
    {
        Transform[] pathtransform = path1.GetComponentsInChildren<Transform>();
        node = new List<Transform>(); //empty list in at the start

        //this loops for each of transform in path transform
        for (int a = 0; a < pathtransform.Length; a++)
        {
            //checks if its not our own transform
            //if its not our own transform, it'll add it to the array
            if (pathtransform[a] != path1.transform)
            {
                node.Add(pathtransform[a]);
            }
        }
        GetComponent<Rigidbody>().centerOfMass = masscentre;
    }

    void FixedUpdate()
    {
        ApplySteer(); //calls apply steer and turns the wheels to the waypoint
        power();
        PointCheck();
    }

    void ApplySteer()
    {
        Vector3 brovector = transform.InverseTransformPoint(node[onNode].position);
        brovector = brovector / brovector.magnitude; //equals length 
        float newSteer = (brovector.x / brovector.magnitude) * MaxAngleSteer;
        frontLeftwheel.steerAngle = newSteer;
        frontRightwheel.steerAngle = newSteer;
    }

    void power()
    {
        speed = 2 * Mathf.PI * frontLeftwheel.radius * frontLeftwheel.rpm / 1000;

        if (speed < topspeed)
        {
            frontRightwheel.motorTorque = fullMotor;
            frontLeftwheel.motorTorque = fullMotor;
        }
        else
        {
            frontRightwheel.motorTorque = 0;
            frontLeftwheel.motorTorque = 0;
        }
    }

    void PointCheck()
    {

          
        if (Vector3.Distance(transform.position, node[onNode].position) < 1f)
        {
            //checks if its on the last node and if so, it will start from the beggining again 
            if (onNode == node.Count - 1)
            {
                onNode = 0;
            }
            else
            {
                //checks if the cars have passed the node and if it has it will increment by one
                onNode++;
            }

        }
    }
}
