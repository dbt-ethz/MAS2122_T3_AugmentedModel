using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Physics;
using Microsoft.MixedReality.Toolkit.Utilities;

public class RealScaleTransform : MonoBehaviour
{
    private float scalemodel = 1.0f;
    private float scalefactor = 20.0f;
    public GameObject modeltobescaled;
    private GameObject clone;
    private bool isScaled = false;

    public void RealScaleOnClick()
    {
        //GameObject clone;
        if (!this.isScaled)
        {
            //clone = Instantiate(modeltobescaled);
            transform.localScale = new Vector3(scalemodel * scalefactor, scalemodel * scalefactor, scalemodel * scalefactor);
            clone.GetComponent<Microsoft.MixedReality.Toolkit.UI.ObjectManipulator>().enabled = false;
            //clone.GetComponent<Microsoft.MixedReality.Toolkit.UI.BoundsControl.BoundsControl>().enabled = false;
            clone.GetComponent<Microsoft.MixedReality.Toolkit.UI.Interactable>().enabled = false;
            clone.GetComponent<NearInteractionGrabbable>().enabled = false;
        }
        else
        {
            Destroy(clone);
            GameObject.Find("RealScaleButtonOnOff").SetActive(false);
        }

        this.isScaled = !this.isScaled;


    }

}
