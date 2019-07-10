using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObj : MonoBehaviour
{
    public GameObject infoMeter;
    public static bool isPanel;

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
        infoMeter.SetActive(true);
        isPanel = true;
    }
    private void OnTriggerExit(Collider other)
    {
        infoMeter.SetActive(false);
    }
}
