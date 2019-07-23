using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TestDebug : MonoBehaviour
{

    public TextMeshProUGUI txt;
    public Image image;
    Quaternion quaternion;

    ///StepClass.Step step;

    public GameObject obj;

    public PlFood leftScript;

    public Sprite[] leftFoodImg;

    // Start is called before the first frame update
    void Start()
    {
        //txt = GetComponent<TextMeshProUGUI>();
        //renderer= gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        quaternion = obj.transform.rotation;

        txt.text = "" + quaternion.eulerAngles + PlFoodPos.hitPosNum + HitPos.HitRankText;


        image.sprite = leftFoodImg[PlFoodPos.hitPosNum];

    }
}
