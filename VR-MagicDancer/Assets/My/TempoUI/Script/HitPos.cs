using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitPos : MonoBehaviour
{
    public List<GameObject> listObj = new List<GameObject>();

    float notesLeftPos;
    float notesRightPos;

    GameObject obj;
    GameObject obj1;

    public static string HitRankText;

    // Start is called before the first frame update
    void Start()
    {
        HitObj.isPanel = false;
    }

    // Update is called once per frame
    void Update()
    {
        //listObj = BeatUi.notesLefts;
        notesLeftPos = BeatUi.notesLefts[0].GetComponent<RectTransform>().localPosition.x;
        notesRightPos = BeatUi.notesRights[0].GetComponent<RectTransform>().localPosition.x;

        //左のノーツの処理
        if (notesLeftPos >= -150f && notesLeftPos < 100f)
        {
            obj = BeatUi.notesLefts[0];

            if (Input.GetKeyDown(KeyCode.Space) || HitObj.isPanel||GroundPanel.isGround)
            {
                if (notesLeftPos <= 50f && notesLeftPos >= -30f)
                {
                    Debug.Log("Excellent!!");

                    HitRankText = "Excellent!!";

                }
                if (notesLeftPos < -30f && notesLeftPos >= -60f)
                {
                    Debug.Log("Good!!");

                    HitRankText = "Good!!";

                }
                if (notesLeftPos < -60f && notesLeftPos >= -150f)
                {
                    Debug.Log("Bad!!");

                    HitRankText = "Bad!!";

                }
                BeatUi.notesLefts.RemoveAt(0);
                Destroy(obj);

                //HitObj.isPanel = false;
            }
        }
        if (!Input.GetKeyDown(KeyCode.Space))
        {
            if(notesLeftPos > 1f)
            {
                obj.GetComponent<Image>().color = Color.clear;
            }
            if (notesLeftPos > 100f)
            {
                BeatUi.notesLefts.RemoveAt(0);
                Destroy(obj);

                HitRankText = "!!";

            }
        }

        //右のノーツの処理
        if (notesRightPos <= 150f && notesRightPos > -100f)
        {
            obj1 = BeatUi.notesRights[0];

            if (Input.GetKeyDown(KeyCode.Space) || HitObj.isPanel || GroundPanel.isGround)
            {
                BeatUi.notesRights.RemoveAt(0);
                Destroy(obj1);

                HitObj.isPanel = false;
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
