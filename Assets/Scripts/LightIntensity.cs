using UnityEngine;
using System.Collections;

public class LightIntensity : MonoBehaviour
{
    public MeshRenderer lightGOR;
    public float duration = 1.0F;
    public Light lt;
    void Start()
    {
        lt = GetComponent<Light>();
    }
    void Update()
    {
        float phi = Time.time / duration * 2 * Mathf.PI;
        float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
        lt.intensity = amplitude;

        //lightGOR.material.color
        if (lt.intensity < 0.1)
        {
            lightGOR.gameObject.SetActive(false);
        } else
        {
            lightGOR.gameObject.SetActive(true);
        }
    }
}