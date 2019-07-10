using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugManager : MonoBehaviour
{
    TextMeshProUGUI hitPanelTxt;

    // Start is called before the first frame update
    void Start()
    {
        hitPanelTxt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HitObj.isPanel)
        {
            HitObj.isPanel = false;
        }

        hitPanelTxt.text = "HitPanel:" + HitObj.isPanel.ToString();
    }
}
