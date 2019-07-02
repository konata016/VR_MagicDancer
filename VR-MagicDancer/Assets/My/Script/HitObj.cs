using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObj : MonoBehaviour
{

    public GameObject infoMeter;
    public Material infoColor;

    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        infoMeter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //↓これを実装する
        //Instantiate(infoMeter,new Vector3(0,0,0))


        //infoMeter.SetActive(true);
        infoMeter.GetComponent<Renderer>().material = infoColor;
    }
    private void OnTriggerExit(Collider other)
    {
        //infoMeter.SetActive(false);
    }
}
