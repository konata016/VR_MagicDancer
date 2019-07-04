using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantObj : MonoBehaviour
{

    public GameObject damageObj;
    public Vector2 instantRange = new Vector2(1, 1);
    public float instantTime = 4f;

    Vector3 randPos;

    // Start is called before the first frame update
    void Start()
    {
        instantRange += new Vector2(transform.position.x, transform.position.y);
        //instantRange = instantRange / 2;

        InvokeRepeating("Instant", 1f, instantTime);
    }

    // Update is called once per frame
    void Update()
    {
        //InvokeRepeating("Instant", 1f, InstantTime);
    }

    void Instant()
    {
        randPos = new Vector3(Random.Range(-instantRange.x, instantRange.x), Random.Range(transform.position.y, instantRange.y), transform.position.z);
        Instantiate(damageObj, randPos, new Quaternion(0, 0, 0, 0));
    }
}
