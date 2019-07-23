using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlFoodPos : MonoBehaviour
{
    Quaternion leftFoodQuaternion;

    public GameObject leftFood;
    public PlFood leftScript;
    public PlFood rightScript;
    //public GameObject rightFood;

    public int cutNum = 8;

    float ang;
    float leftStartPos;

    public static int hitPosNum;


    // Start is called before the first frame update
    void Start()
    {
        ang = 360 / cutNum;

    }

    // Update is called once per frame
    void Update()
    {


        leftFoodQuaternion = leftFood.transform.rotation;
        float leftFoodAng = leftFoodQuaternion.eulerAngles.y;

        //左足の位置を出すやつ
        float minAng = ang / 2;
        if (leftScript.isTriggerEnter || rightScript.isTriggerEnter)
        {
            //if (leftFoodAng <= 22.5 || leftFoodAng > 337.5)
            //{
            //    count = 0;
            //}
            //else 
            //if (leftFoodAng > 22.5 && leftFoodAng <= 67.5)
            //{
            //    count = 1;
            //}
            //else if (leftFoodAng > 67.5 && leftFoodAng <= 112.5)
            //{
            //    count = 2;
            //}
            //else if (leftFoodAng > 112.5 && leftFoodAng <= 157.5)
            //{
            //    count = 3;
            //}
            //else if (leftFoodAng > 157.5 && leftFoodAng <= 202.5)
            //{
            //    count = 4;
            //}
            //else if (leftFoodAng > 202.5 && leftFoodAng <= 247.5)
            //{
            //    count = 5;
            //}
            //else if (leftFoodAng > 247.5 && leftFoodAng <= 292.5)
            //{
            //    count = 6;
            //}
            //else if (leftFoodAng > 292.5 && leftFoodAng <= 337.5)
            //{
            //    count = 7;
            //}



            if (leftFoodAng <= minAng || leftFoodAng > minAng + ang * (cutNum - 1))
            {
                hitPosNum = 0;
            }
            else
            {
                for (int i = 1; i < cutNum; i++)
                {
                    if (leftFoodAng > minAng && leftFoodAng <= minAng + ang)
                    {
                        hitPosNum = i;
                        break;
                    }
                    minAng += ang;
                }

            }
            leftScript.isTriggerEnter = false;
            rightScript.isTriggerEnter = false;
        }
       
    }
}
