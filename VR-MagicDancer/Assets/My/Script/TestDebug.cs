using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestDebug : MonoBehaviour
{

    TextMeshProUGUI txt;

    public GameObject obj;
    Quaternion quaternion;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        quaternion = obj.transform.rotation;

        txt.text = "" + quaternion.eulerAngles + PlFoodPos.count;


    }
}
