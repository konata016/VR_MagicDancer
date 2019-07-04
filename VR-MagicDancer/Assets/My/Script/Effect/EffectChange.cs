using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectChange : MonoBehaviour
{
    Renderer color;
    AudioSource audioSource;

    public GameObject touchOn;
    public GameObject touchOff;

    public Material on;
    public Material off;

    public AudioClip se;

    GameObject onEffect;
    GameObject offEffect;

    bool hitPl;

    // Start is called before the first frame update
    void Start()
    {
        color = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>();

        onEffect = Instantiate(touchOn, transform) as GameObject;
        offEffect = Instantiate(touchOff, transform) as GameObject;

        onEffect.SetActive(true);
        onEffect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(se);
        color.material = on;
        onEffect.SetActive(false);
        onEffect.SetActive(true);

        hitPl = true;
    }
    private void OnTriggerExit(Collider other)
    {
        color.material = off;
        onEffect.SetActive(true);
        onEffect.SetActive(false);

        hitPl = false;
    }
}
