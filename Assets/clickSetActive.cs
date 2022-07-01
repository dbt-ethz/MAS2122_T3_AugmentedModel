using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickSetActive : MonoBehaviour
{
    public void onClickSetActive()
    {
        gameObject.SetActive(!gameObject.activeSelf); // if it is true, we set it false. viceversa
        // !true == false
    }
}
