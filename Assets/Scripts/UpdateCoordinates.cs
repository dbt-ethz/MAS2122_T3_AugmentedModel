using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCoordinates : MonoBehaviour
{
    private GameObject ModelParent; //
    // Start is called before the first frame update
    void Start()
    {
        ModelParent = GameObject.Find("ModelParent");
    }

    // Update is called once per frame
    void Update()
    {
        //"Update" runs every frame in the app. We update ModelParent's location to the QR Code it detected
        //and keep updatig it everyframe as lon as the scannig is going on.
        //That is also why we want to use button to start and stop scan. Once it stops scan, the location will not be changed.
        ModelParent.transform.position = this.gameObject.transform.position;
        ModelParent.transform.rotation = this.gameObject.transform.rotation; 
    }
}
