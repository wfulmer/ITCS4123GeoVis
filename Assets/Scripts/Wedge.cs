using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wedge : MonoBehaviour {
    
    public string label = "";
    public bool expanded = false;
    public Color defaultColor;

    public void lookedAt()
    {
        Contract();
        transform.parent.GetComponent<ChemicalGraph>().ContractMatchingWedges(label);
    }

    public void lookedAway()
    {
        Expand();
        transform.parent.GetComponent<ChemicalGraph>().ExpandMatchingWedges(label);
    }

    public void clicked()
    {
        transform.parent.GetComponent<ChemicalGraph>().selectedLabel = label;
        transform.parent.GetComponent<ChemicalGraph>().sibling1.selectedLabel = label;
        transform.parent.GetComponent<ChemicalGraph>().sibling2.selectedLabel = label;
        transform.parent.GetComponent<ChemicalGraph>().UpdateHoverText();
    }

    public void Contract()
    {
        if(transform.parent.GetComponent<ChemicalGraph>().selectedLabel != label)
        {
            GetComponent<Image>().color = new Color(0, 0, 1, 1);
            if (expanded == false)
            {
                transform.localScale = new Vector3(0.8f, 0.8f, 1);
                expanded = true;
            }
        }
    }

    public void Expand()
    {
        if (transform.parent.GetComponent<ChemicalGraph>().selectedLabel != label)
        {
            GetComponent<Image>().color = defaultColor;
            transform.localScale = new Vector3(1, 1, 1);
            expanded = false;
        }
    }
}
