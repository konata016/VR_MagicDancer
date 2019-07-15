using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelEffectObj : MonoBehaviour
{
    public GameObject Obj;
    GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Music.IsPlaying && Music.IsJustChangedBeat())
        {
            prefab = Instantiate(Obj) as GameObject;         
        }
    }
}
