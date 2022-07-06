using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QRTracking;

public class StartStopScan : MonoBehaviour
{
    public QRCodesManager qRCodesManager;

    public void StartScanning()
    {
        qRCodesManager.StartQRTracking();
    }

    public void StopScanning()
    {
        qRCodesManager.StopQRTracking();
    }
}
