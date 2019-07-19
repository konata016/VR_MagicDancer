using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftObserve : MonoBehaviour
{
    public GameObject target;
    public GameObject chase;

    //public GameObject camera;
    Quaternion footQ;
    Quaternion cameraQ;
    Quaternion q;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = chase.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //cameraQ = camera.transform.rotation;
        //float roll = cameraQ.eulerAngles.y;



        transform.position = new Vector3(chase.transform.position.x, transform.position.y, chase.transform.position.z);
        transform.rotation = Quaternion.LookRotation(Vector3.up, target.transform.position - transform.position);

        //transform.rotation = Quaternion.Euler(0, footQ.eulerAngles.y - roll, 0);
    }
}
