using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GroundPanel : MonoBehaviour
{

    AudioSource audioSource;
    Vector3 baseScale;

    public static bool isGround;

    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        baseScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Music.IsPlaying && Music.IsJustChangedBeat())
        {
            transform.DOScale(new Vector3( baseScale.x * 1.2f,transform.localScale.y, baseScale.z * 1.2f), 0.0f);
            transform.DOScale(baseScale, 0.2f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(se);
        isGround = true;
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
