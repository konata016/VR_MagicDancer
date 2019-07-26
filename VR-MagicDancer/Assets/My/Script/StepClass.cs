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
        public List<bool> isStep=new List<bool>();
    }
    public List<StepType> stepType = new List<StepType>();

    public int stepTypeCount;
    public int stepListCount;

    // Start is called before the first frame update
    void Start()
    {
        //フラグの配列を確保
        for(int i=0; i < stepType.Count; i++)
        {
            for(int j = 0; j < stepType[i].stepList.Count; j++)
            {
                stepType[i].isStep.Add(false);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        //初期化
        for (int i = 0; i < stepType.Count; i++)
        {
            //デバッグ用
            TestDebug.debugText = stepListCount.ToString() + stepType[i].stepList.Count.ToString();

            //現在のステップがステップリストの最後だった場合
            if (stepType[i].stepList.Count == stepListCount)
            {
                //ループの最後の場合ステップリストカウントを0にする
                if (stepType[i].isStep[stepType[i].isStep.Count-1]) stepListCount = 0;

                //フラグのリセット
                for (int j = 0; j < stepType[i].stepList.Count; j++)
                {
                    stepType[i].isStep[j] = false;
                }

                //break;

            }


            
        }
        
    }
}
