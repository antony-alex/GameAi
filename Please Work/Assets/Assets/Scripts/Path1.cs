using System.Collections;
using UnityEngine;
using System.Collections.Generic; //allows us to use lists

public class Path1 : MonoBehaviour
{

    public Color LineColour;

    private List<Transform> nodes = new List<Transform>(); //allows us to store the nodes 

    private void OnDrawGizmos()
    {
        Transform[] pathtransform = GetComponentsInChildren<Transform>();
        nodes = new List<Transform>(); //empty list in at the start
        Gizmos.color = LineColour;
        //this loops for each of transform in path transform
        for (int a = 0; a < pathtransform.Length; a++)
        {
            //checks if its not our own transform
            //if its not our own transform, it'll add it to the array
            if (pathtransform[a] != transform)
            {
                nodes.Add(pathtransform[a]);
            }
        }

        for (int b = 0; b < nodes.Count; b++)
        {
            Vector3 prevNode = Vector3.zero; // assign a variable for the previsous node
            //will take the position and store it in onNode
            Vector3 onNode = nodes[b].position;
            //make sure when onNode is 0 
            // it goes to the last node and not -1 which causes problems
            if (b > 0)
            {
                //draw a line between previsous node and the node the car is on
                prevNode = nodes[b - 1].position;
            }
            else if (b == 0 && nodes.Count > 1)
            {
                prevNode = nodes[nodes.Count - 1].position;
            }

            Gizmos.DrawLine(prevNode, onNode);
            Gizmos.DrawWireSphere(onNode, 0.2f);

        }
    }
}
