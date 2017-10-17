using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wedge : MonoBehaviour {
    
    public string label = "";

	// Use this for initialization
	void Awake () {
        //Cursor.lockState = CursorLockMode.Locked;
	}

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            Debug.Log("Pointer hover");
        }
    }

    private void OnMouseOver()
    {
        setText();
    }

    private void OnMouseExit()
    {
        clearText();
    }

    public void setText()
    {
        Debug.Log("SET TEXT: " + label);
        Debug.Log(transform.parent.gameObject);
        Text hoverText = transform.parent.gameObject.transform.Find("HoverText").GetComponent<Text>();
        hoverText.text = label;
    }

    public void clearText()
    {
        Debug.Log("CLEAR TEXT: " + label);
        Debug.Log(transform.parent.gameObject);
        Text hoverText = transform.parent.gameObject.transform.Find("HoverText").GetComponent<Text>();
        hoverText.text = "";
    }
}
