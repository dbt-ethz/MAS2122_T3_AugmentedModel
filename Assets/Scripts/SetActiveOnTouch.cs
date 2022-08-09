using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;

public class SetActiveOnTouch : MonoBehaviour
{
    [SerializeField]
    [FormerlySerializedAs("TargetObjectTransform")]
    private Transform targetObjectTransform = null;

    [SerializeField]
    private float rotateSpeed = 300.0f;

    void IMixedRealityTouchHandler.OnTouchUpdated(HandTrackingInputEventData eventData)
    {
        if (targetObjectTransform != null)
        {
            targetObjectTransform.Rotate(Vector3.up * (rotateSpeed * Time.deltaTime));
        }
    }
}
