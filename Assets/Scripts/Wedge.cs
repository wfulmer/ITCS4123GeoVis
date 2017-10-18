using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wedge : MonoBehaviour {
    
    public string label = "";
    public bool expanded = false;
    public Color defaultColor;

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
        if (expanded == false)
        {
            transform.localScale = new Vector3(0.8f, 0.8f, 1);
            expanded = true;
        }
    }

    public void Contract()
    {
        GetComponent<Image>().color = defaultColor;
        transform.localScale = new Vector3(1, 1, 1);
        expanded = false;
    }
}
