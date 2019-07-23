using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ステップを登録しておくやつ

public class StepClass : MonoBehaviour
{
    //public Image image;

    [System.SerializableAttribute]
    public class StepType
    {
        public List<GameObject> stepList;
    }
    public List<StepType> stepType = new List<StepType>();

    public int stepTypeCount;
    public int stepListCount;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    
        //初期化
        for (int i = 0; i < stepType.Count; i++)
        {
            if (stepListCount > stepType[i].stepList.Count - 1) stepListCount = 0;
            if (stepListCount == 0) break;
        }
    }
}
