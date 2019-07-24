using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepUi : MonoBehaviour
{
    public Image[] image;
    public StepClass hitStep;

    [System.SerializableAttribute]
    public class StepType
    {
        public List<bool> hitStepList;
    }
    public List<StepType> stepType = new List<StepType>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < hitStep.stepType.Count; i++)
        {
            image[i].sprite = hitStep.stepType[i].stepList[0].GetComponent<SpriteRenderer>().sprite;

            //Listの準備
            stepType.Add(null);
            for (int j = 0; j < hitStep.stepType[i].stepList.Count; j++)
            {
                stepType[i].hitStepList.Add(false);
            }
        }
        Debug.Log(hitStep.stepType.Count);


    }

    // Update is called once per frame
    void Update()
    {
        

        for (int i = 0; i < hitStep.stepType.Count; i++)
        {
            //ステップの中から踏まれたステップがあるかを探す
            if (hitStep.stepType[i].stepList[hitStep.stepListCount].GetComponent<StepStatus>().number == PlFoodPos.hitPosNum)
            {
                //探し出したものにチェックを付ける
                stepType[i].hitStepList[hitStep.stepListCount] = true;

                for (int j = 0; j < hitStep.stepType[i].stepList.Count; j++)
                {
                    //チェックがある場合
                    if (stepType[i].hitStepList[j] == true)
                    {
                        int count = 0;
                        count++;

                        //チェックががステップ進行度と同じだった場合画像を変える
                        if (count == hitStep.stepListCount)
                        {
                            image[i].sprite = hitStep.stepType[i].stepList[hitStep.stepListCount].GetComponent<SpriteRenderer>().sprite;
                        }
                    }
                    else break;
                }
            }
        }

        //初期まだできていない
        for (int i = 0; i < hitStep.stepType.Count; i++)
        {
            if (stepType[i].hitStepList != null)
            {
                if(stepType[i].hitStepList.Contains(true))
                {
                    //stepType[i].hitStepList.co
                }
            }
        }



        //for (int i = hitStep.stepTypeCount; i < hitStep.stepType.Count; i++)
        //{
        //    if (hitStep.stepListCount + 1 < hitStep.stepType[i].stepList.Count)
        //    {
        //        image[i].sprite = null;

        //    }
        //    else
        //    {
        //        if (hitStep.stepType[hitStep.stepTypeCount].stepList[hitStep.stepListCount].GetComponent<StepStatus>().number == PlFoodPos.hitPosNum)
        //        {
        //            image[i].sprite = hitStep.stepType[i].stepList[hitStep.stepListCount + 1].GetComponent<SpriteRenderer>().sprite;
        //        }
        //        else
        //        {
        //            image[i].sprite = null;
        //        }
        //    }


    }
}
