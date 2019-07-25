using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepUi : MonoBehaviour
{
    public Image[] image;
    public StepClass hitStep;

    bool isGroundPulse;
    int stepHitCount;
    float timer;

    [System.SerializableAttribute]
    public class StepImgType 
    {
        public List<bool> hitStepList;
    }
    public List<StepImgType> stepImgType = new List<StepImgType>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < hitStep.stepType.Count; i++)
        {
            image[i].sprite = hitStep.stepType[i].stepList[0].GetComponent<SpriteRenderer>().sprite;

            //Listの準備
            stepImgType.Add(new StepImgType() { hitStepList = new List<bool>() });
        }

        for (int i = 0; i < hitStep.stepType.Count; i++)
        {
            for (int j = 0; j < hitStep.stepType[i].stepList.Count; j++)
            {
                stepImgType[i].hitStepList.Add(false);
            }

        }
       


    }

    // Update is called once per frame
    void Update()
    {
        //if(timer < 0.25f)  timer += 0.1f * Time.deltaTime;
        if (GroundPanel.isGround) isGroundPulse = true;
        if (isGroundPulse)
        {
            for (int i = 0; i < hitStep.stepType.Count; i++)
            {
                if(hitStep.stepType[i].stepList[hitStep.stepListCount].GetComponent<StepStatus>().number == PlFoodPos.hitPosNum)
                {
                    if (stepImgType[i] != null|| hitStep.stepListCount + 1<hitStep.stepType[i].stepList.Count)
                    {
                        Debug.Log(hitStep.stepListCount);
                        image[i].sprite = hitStep.stepType[i].stepList[hitStep.stepListCount + 1].GetComponent<SpriteRenderer>().sprite;
                    }
                }
                else
                {
                    //image[i].sprite = null;
                }

                if (hitStep.stepListCount == 0)
                {
                    image[i].sprite = hitStep.stepType[i].stepList[0].GetComponent<SpriteRenderer>().sprite;
                }
            }
            isGroundPulse = false;
        }

        //if (GroundPanel.isGround) isGroundPulse = true;

        //if (isGroundPulse)
        //{
        //    for (int i = 0; i < hitStep.stepType.Count; i++)
        //    {

        //        if (hitStep.stepType[i].stepList[hitStep.stepListCount].GetComponent<StepStatus>().number == PlFoodPos.hitPosNum)
        //        {
        //            //stepImgType[i].hitStepList[hitStep.stepListCount] = true;
        //            if (image[i].sprite != null || hitStep.stepListCount + 1 < hitStep.stepType[i].stepList.Count)
        //            {


        //                for (int j = 0; j < hitStep.stepType[i].stepList.Count; j++)
        //                {
        //                    if (stepImgType[i].hitStepList[j]) stepHitCount++;
        //                }
        //                Debug.Log(stepHitCount);
        //                Debug.Log(hitStep.stepListCount);


        //                if (stepHitCount == hitStep.stepListCount)
        //                {
        //                    image[i].sprite = hitStep.stepType[i].stepList[hitStep.stepListCount+1].GetComponent<SpriteRenderer>().sprite;
        //                    stepImgType[i].hitStepList[hitStep.stepListCount] = true;
        //                }
        //                stepHitCount = 0;
        //            }
        //            else
        //            {
        //                image[i].sprite = hitStep.stepType[i].stepList[0].GetComponent<SpriteRenderer>().sprite;
        //            }
        //        }
        //        else
        //        {
        //            image[i].sprite = null;
        //        }

        //    }

        //    isGroundPulse = false;
        //}
        //for (int i = 0; i < hitStep.stepType.Count; i++)
        //{
        //    //ステップの中から踏まれたステップがあるかを探す
        //    if (hitStep.stepType[i].stepList[hitStep.stepListCount].GetComponent<StepStatus>().number == PlFoodPos.hitPosNum)
        //    {
        //        //探し出したものにチェックを付ける
        //        stepImgType[i].hitStepList[hitStep.stepListCount] = true;
        //        int count = 0;
        //        for (int j = 0; j < hitStep.stepType[i].stepList.Count; j++)
        //        {
        //            //チェックがある場合
        //            if (stepImgType[i].hitStepList[j] == true)
        //            {

        //                count++;

        //                //チェックががステップ進行度と同じだった場合画像を変える
        //                if (count == hitStep.stepListCount)
        //                {
        //                    image[i].sprite = hitStep.stepType[i].stepList[hitStep.stepListCount].GetComponent<SpriteRenderer>().sprite;
        //                }
        //            }
        //            else break;
        //        }
        //    }
        //}

        ////初期まだできていない
        //for (int i = 0; i < hitStep.stepType.Count; i++)
        //{
        //    if (stepImgType[i].hitStepList.Contains(true)|| hitStep.stepListCount==0)
        //    {
        //        stepImgType[i].hitStepList.IndexOf(false);
        //    }
        //}



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
