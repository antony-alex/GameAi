using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public Camera[] cam123;

    public void CarView1()
    {
        cam123[0].enabled = true;
        cam123[1].enabled = false;
        cam123[2].enabled = false;
    }
    public void TopView()
    {
        cam123[0].enabled = false;
        cam123[1].enabled = true;
        cam123[2].enabled = false;
    }
    public void MidView()
    {
        cam123[0].enabled = false;
        cam123[1].enabled = false;
        cam123[2].enabled = true;
    }
}
