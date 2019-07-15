using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EffectObjBloc : MonoBehaviour
{
    public float speed;
    Vector3 baseScale;

    // Start is called before the first frame update
    void Start()
    {
        baseScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Music.IsPlaying && Music.IsJustChangedBeat())
        //{
        //    gameObject.transform.DOScale(baseScale * 3f, 0.0f);
        //    gameObject.transform.DOScale(baseScale, 0.2f);
        //}
        transform.position += Vector3.up * speed * Time.deltaTime;
        Destroy(gameObject, 4f);
    }
}
