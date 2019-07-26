using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ステップ、タイミングの処理

public class HitPos : MonoBehaviour
{
    float notesLeftPos;
    float notesRightPos;

    GameObject obj;
    GameObject obj1;

    int stepMissCount;
    bool isStepHit;

    //デバッグ用テキスト
    public static string HitRankText;

    //ステップのデータが格納されているクラス
    public StepClass hitStep;

    // Start is called before the first frame update
    void Start()
    {
        //昔の地面との当たり判定用のやつ
        HitObj.isPanel = false;
    }

    // Update is called once per frame
    void Update()
    {
        //UIの移動を監視するた、移動式を短くするために代入した
        notesLeftPos = BeatUi.notesLefts[0].GetComponent<RectTransform>().localPosition.x;
        notesRightPos = BeatUi.notesRights[0].GetComponent<RectTransform>().localPosition.x;

        //左のノーツの処理
        if (notesLeftPos >= -150f && notesLeftPos < 100f)
        {
            obj = BeatUi.notesLefts[0];
            
            //地面に接触したときに処理が発生
            if (Input.GetKeyDown(KeyCode.Space) || HitObj.isPanel || GroundPanel.isGround)
            {
                //ミスをした時の判定のリセット
                stepMissCount = 0;
                isStepHit = false;

                //登録したステップタイプ分だけ回す
                for (int i = hitStep.stepTypeCount; i < hitStep.stepType.Count; i++)
                {
                    //配列外を参照しそうになった場合ブレイクする
                    if (hitStep.stepType[i].stepList.Count == hitStep.stepListCount) break;

                    //存在しないステップタイプを無視するよう
                    if (!isStepHit) hitStep.stepTypeCount = i;

                    //ステップの中から踏まれたステップがあるかを探す
                    if (hitStep.stepType[hitStep.stepTypeCount].stepList[hitStep.stepListCount].GetComponent<StepStatus>().number == PlFoodPos.hitPosNum)
                    {
                        //前回入力したステップと今回入力したステップが正しい場合、フラグを立てる
                        if (hitStep.stepListCount == 0)
                        {
                            hitStep.stepType[hitStep.stepTypeCount].isStep[hitStep.stepListCount] = true;
                        }
                        else
                        {
                            if (hitStep.stepType[hitStep.stepTypeCount].isStep[hitStep.stepListCount - 1])
                                hitStep.stepType[hitStep.stepTypeCount].isStep[hitStep.stepListCount] = true;
                        }

                        //見つけ出せたらステップの次の動きをチェックするために配列を1つずらすための++
                        if (!isStepHit) hitStep.stepListCount++;

                        //エクセレント評価の処理
                        if (notesLeftPos <= 50f && notesLeftPos >= -30f)
                        {
                            Debug.Log("Excellent!!");
                            HitRankText = "Excellent!!";
                        }
                        //グッド評価の処理
                        if (notesLeftPos < -30f && notesLeftPos >= -60f)
                        {
                            Debug.Log("Good!!");
                            HitRankText = "Good!!";
                        }
                        //バッド評価の処理
                        if (notesLeftPos < -60f && notesLeftPos >= -150f)
                        {
                            Debug.Log("Bad!!");
                            HitRankText = "Bad!!";
                        }

                        //正解した場合ミスで発生する処理を実行しないためのフラグ
                        isStepHit = true;
                        //break;
                    }
                    else
                    {
                        //ステップリストに存在しないステップを踏んだ場合
                        if (!isStepHit)
                        {
                            HitRankText = "Miss!!";
                            stepMissCount++;      //ミスのカウントを一進める

                            //フラグのリセット
                            for (int j = 0; j < hitStep.stepType[i].stepList.Count; j++)
                            {
                                hitStep.stepType[i].isStep[j] = false;
                            }
                            //カウントリセット
                            hitStep.stepListCount = 0;
                            hitStep.stepTypeCount = 0;
                        }
                    }
                }

                //ヒットしたノーツの消す処理
                BeatUi.notesLefts.RemoveAt(0);
                Destroy(obj);

                //昔の地面との当たり判定で使っていたやつ
                //HitObj.isPanel = false;
            }
        }

        //通り過ぎたノーツの消す処理
        if (notesLeftPos > 1f)
        {
            obj.GetComponent<Image>().color = Color.clear;
        }
        if (notesLeftPos > 100f)
        {
            BeatUi.notesLefts.RemoveAt(0);
            Destroy(obj);

            //通り過ぎた場合のテキスト処理;
            HitRankText = "!!";

        }


        //右のノーツの処理
        if (notesRightPos <= 150f && notesRightPos > -100f)
        {
            obj1 = BeatUi.notesRights[0];

            if (Input.GetKeyDown(KeyCode.Space) || HitObj.isPanel || GroundPanel.isGround)
            {
                BeatUi.notesRights.RemoveAt(0);
                Destroy(obj1);

                //HitObj.isPanel = false;
                GroundPanel.isGround = false;
            }
        }
        if (!Input.GetKeyDown(KeyCode.Space))
        {
            if (notesRightPos < -1f)
            {
                obj1.GetComponent<Image>().enabled = false;
            }
            if (notesRightPos < -100f)
            {
                BeatUi.notesRights.RemoveAt(0);
                Destroy(obj1);
            }
        }
    }
}