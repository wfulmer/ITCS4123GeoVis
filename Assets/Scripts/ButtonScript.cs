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
            if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetButton("Gamepad_A"))
            {
                Debug.Log("PRESSED");
                VRInteractiveItem intItem = GetComponent<VRInteractiveItem>();
                intItem.A();
            }
        }
    }
}
