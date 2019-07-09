using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObj : MonoBehaviour
{
    //public GameObject outputPos;
    public GameObject infoMeter;
    //public Material material;

    Renderer rend;
    //public Material infoColor;

    // Start is called before the first frame update
    void Start()
    {
        //rend = GetComponent<Renderer>();
        //rend.material = material;
        infoMeter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        infoMeter.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        infoMeter.SetActive(false);
    }
}
