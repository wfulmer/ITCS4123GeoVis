using DataStarter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WedgeInteractiveItem : MonoBehaviour {
    
    [SerializeField] private VRInteractiveItem m_InteractiveItem;

    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        m_InteractiveItem.OnClick += HandleClick;
        m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
        m_InteractiveItem.OnClick -= HandleClick;
        m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
    }


    //Handle the Over event
    private void HandleOver()
    {
        Debug.Log("Show over wedge");//this changes the color of material on the next line.
        GetComponent<Wedge>().setText();
    }


    //Handle the Out event
    private void HandleOut()
    {
        Debug.Log("Show out wedge");
        GetComponent<Wedge>().clearText();
    }


    //Handle the Click event
    private void HandleClick()
    {
        Debug.Log("Show click wedge");
    }


    //Handle the DoubleClick event
    private void HandleDoubleClick()
    {
        Debug.Log("Show double click");
    }
}
