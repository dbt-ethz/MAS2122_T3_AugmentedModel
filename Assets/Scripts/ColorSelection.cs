using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using System;

namespace Microsoft.MixedReality.Toolkit.UI
{

    public class ColorSelection : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        #region Events Handlers
        [Header("Events")]
        public SliderEvent OnInteractionStarted = new SliderEvent();
        public SliderEvent OnInteractionFinished = new SliderEvent();
        public SliderEvent OnHoverEntered = new SliderEvent();
        public SliderEvent OnHoverExited = new SliderEvent();
        #endregion

    }
}