////////////////////////////////////////////////////////
//Name: Breanna Henriquez
//Date: 02/06/2022
//Purpose: Script to define basic enemy AI behavior
///////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : MonoBehaviour
{
    //gameobjects
    [SerializeField]
    GameObject target;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //For debug purposes draw the forward and right vectors
        Debug.DrawLine(transform.position, transform.position + transform.forward * 5.0f, Color.red); //foward 
        Debug.DrawLine(transform.position, transform.position + transform.right * 5.0f, Color.blue);  //right

        //rotate to face player
        Debug.DrawLine(transform.position, target.transform.position, Color.magenta); //distance to player
        transform.LookAt(new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z));
    }
}
