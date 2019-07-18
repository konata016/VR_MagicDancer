using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPanel : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(se);
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
