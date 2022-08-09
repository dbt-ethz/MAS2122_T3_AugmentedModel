using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTransform : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickResetTransform()
    {
        this.transform.localPosition = new Vector3(0,0,0);
        this.transform.localRotation = Quaternion.identity;
        this.transform.localScale = new Vector3(1, 1, 1);
    }
}
