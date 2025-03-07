using UnityEngine;

public class HazardScale1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    float scaleSpeed = .005f;
    float scaleOutputt = 0f;
    // Update is called once per frame
    void Update()
    {
        scaleOutputt += scaleSpeed;
        transform.localScale = new Vector3(scaleOutputt, scaleOutputt, 1f);
        if (scaleOutputt >= 2)
        {
            scaleSpeed = -.0025f;
        }
        if (scaleOutputt <= 0) {
            scaleSpeed = 0;
            transform.position = new Vector3 (100,10,0);
    }
}
}
