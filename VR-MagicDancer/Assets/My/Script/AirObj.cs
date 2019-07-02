using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirObj : MonoBehaviour
{
    public static bool isAirObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") isAirObj = true;
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") isAirObj = false;
    }
}
