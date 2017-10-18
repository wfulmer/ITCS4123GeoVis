using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wedge : MonoBehaviour {
    
    public string label = "";
    public float angle = 0f;
    public bool expanded = false;
    public Color defaultColor;

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
        Expand();
        transform.parent.GetComponent<ChemicalGraph>().ExpandMatchingWedges(label);
    }

    private void OnMouseExit()
    {
        clearText();
        Contract();
        transform.parent.GetComponent<ChemicalGraph>().ContractMatchingWedges(label);
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

    public void Expand()
    {
        GetComponent<Image>().color = new Color(0, 0, 1, 1);
        /*if (expanded == false)
        {
            float halfAngle = angle / 2.0f;
            float angleInRadians = ((halfAngle * Mathf.PI) / 180);
            float angleCos = Mathf.Cos(angleInRadians);
            float angleSin = Mathf.Sin(angleInRadians);

            transform.position = transform.position + new Vector3(10f * angleCos, 10f * angleSin, 0);

            expanded = true;
        }*/
    }

    public void Contract()
    {
        GetComponent<Image>().color = defaultColor;
        /*transform.position = transform.parent.position;
        expanded = false;*/
    }
}
