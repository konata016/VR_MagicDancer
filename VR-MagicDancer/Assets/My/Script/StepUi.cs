using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepUi : MonoBehaviour
{
    public Image[] image;
    public StepClass hitStep;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //画像が最初に戻らない
        for (int i = 0; i < hitStep.stepType.Count; i++)
        {
            if (hitStep.stepListCount != 0)
            {
                if (hitStep.stepType[i].isStep[hitStep.stepListCount - 1])
                {
                    image[i].sprite = hitStep.stepType[i].stepList[hitStep.stepListCount].GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    image[i].sprite = hitStep.stepType[i].stepList[0].GetComponent<SpriteRenderer>().sprite;
                }
            }
        }
    }
}
