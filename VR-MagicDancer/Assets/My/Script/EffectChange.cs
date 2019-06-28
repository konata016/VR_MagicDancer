using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectChange : MonoBehaviour
{
    Renderer color;

    public GameObject touchOn;
    public GameObject touchOff;

    public Material on;
    public Material off;

    GameObject onEffect;
    GameObject offEffect;

    // Start is called before the first frame update
    void Start()
    {
        color = GetComponent<Renderer>();

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
        color.material = on;
        onEffect.SetActive(false);
        onEffect.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        color.material = off;
        onEffect.SetActive(true);
        onEffect.SetActive(false);
    }
}
