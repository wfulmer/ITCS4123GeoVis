using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DataStarter
{
    public class ButtonScript : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (OVRInput.GetUp(OVRInput.Button.One))
            {
                VRInteractiveItem intItem = GetComponent<VRInteractiveItem>();
                intItem.A();
            }
        }
    }
}
