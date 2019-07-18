using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftObserve : MonoBehaviour
{
    public GameObject target;
    public GameObject chase;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = chase.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(chase.transform.position.x, transform.position.y, chase.transform.position.z);
        transform.rotation = Quaternion.LookRotation(Vector3.up, target.transform.position - transform.position);
    }
}
