using UnityEngine;

public class XRStartPosition : MonoBehaviour
{
    public Transform xrRig;
    public Transform startPoint;

    void Start()
    {
        Vector3 heightOffset = xrRig.position - xrRig.GetChild(0).position; // maintain headset height
        xrRig.position = startPoint.position + heightOffset;
        xrRig.rotation = startPoint.rotation;
    }
}