using UnityEngine;

public class IcingCylinder : MonoBehaviour
{
    public float smoothTime = 0.1f;
    private Vector3 targetScale;
    private Vector3 scaleVelocity;

    void Start()
    {
        targetScale = transform.localScale;
        transform.localScale = Vector3.zero;
    }

    void Update()
    {
        transform.localScale = Vector3.SmoothDamp(
            transform.localScale, 
            targetScale, 
            ref scaleVelocity, 
            smoothTime
        );
    }
}
