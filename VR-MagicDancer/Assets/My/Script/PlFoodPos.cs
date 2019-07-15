using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlFoodPos : MonoBehaviour
{
    public GameObject leftFood;
    public GameObject leftkController;
    //public GameObject rightFood;

    public int cutNum = 8;

    float ang;
    float leftStartPos;

    public static int count;


    // Start is called before the first frame update
    void Start()
    {
        ang = 360 / cutNum;
        leftStartPos = leftkController.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        count = 0;

        Quaternion leftFoodQuaternion = leftFood.transform.rotation;
        float leftFoodAng = leftFoodQuaternion.eulerAngles.y;

        //足の位置を出すやつ
        float minAng = ang / 2;
        if (leftFoodAng <= minAng || leftFoodAng > minAng + ang * (cutNum - 1))
        {

        }
        else
        {
            for (int i = 1; i < cutNum; i++)
            {
                if (leftFoodAng > minAng && leftFoodAng <= minAng + ang)
                {
                    count = i;
                }
                minAng += ang;
            }
        }
    }
}
