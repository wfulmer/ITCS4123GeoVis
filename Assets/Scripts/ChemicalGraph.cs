using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

[System.Serializable]
public class StateChemInfo
{
    public float value1;
    public string name1;
    public float value2;
    public string name2;
    public float value3;
    public string name3;
    public float value4;
    public string name4;
    public float value5;
    public string name5;
    public float value6;
    public string name6;
    public float value7;
    public string name7;
    public float value8;
    public string name8;
    public float value9;
    public string name9;
    public float value10;
    public string name10;
}

[System.Serializable]
public class AllStateChemInfo
{
    public StateChemInfo WA;
    public StateChemInfo DE;
    public StateChemInfo DC;
    public StateChemInfo WI;
    public StateChemInfo WV;
    public StateChemInfo FL;
    public StateChemInfo WY;
    public StateChemInfo NH;
    public StateChemInfo NJ;
    public StateChemInfo NM;
    public StateChemInfo TX;
    public StateChemInfo LA;
    public StateChemInfo NC;
    public StateChemInfo ND;
    public StateChemInfo NE;
    public StateChemInfo TN;
    public StateChemInfo NY;
    public StateChemInfo PA;
    public StateChemInfo CT;
    public StateChemInfo RI;
    public StateChemInfo NV;
    public StateChemInfo VA;
    public StateChemInfo GU;  //Guam
    public StateChemInfo CO;
    public StateChemInfo VI;  //Virgin Islands
    public StateChemInfo CA;
    public StateChemInfo AL;
    public StateChemInfo AS;
    public StateChemInfo AR;
    public StateChemInfo VT;
    public StateChemInfo IL;
    public StateChemInfo GA;
    public StateChemInfo IN;
    public StateChemInfo IA;
    public StateChemInfo MA;
    public StateChemInfo AZ;
    public StateChemInfo ID;
    public StateChemInfo PR;  //Puerto Rico
    public StateChemInfo ME;
    public StateChemInfo MD;
    public StateChemInfo OK;
    public StateChemInfo OH;
    public StateChemInfo UT;
    public StateChemInfo MO;
    public StateChemInfo MN;
    public StateChemInfo MI;
    public StateChemInfo KS;
    public StateChemInfo MT;
    public StateChemInfo MP;  //Unknown
    public StateChemInfo MS;
    public StateChemInfo SC;
    public StateChemInfo KY;
    public StateChemInfo OR;
    public StateChemInfo SD;
}

public class ChemicalGraph : MonoBehaviour {

    private AllStateChemInfo states;
    private Dictionary<string, StateChemInfo> statesDict = new Dictionary<string, StateChemInfo>();

    // Pie graph values and colors
    private float[] values = new float[10];
    private Color[] wedgeColors = new Color[10];
    public Image wedgePrefab;
    public Vector3 upperTarget;
    public Vector3 midTarget;
    public Vector3 lowerTarget;
    private Vector3 target;
    public float expandSpeed;

    public bool generated = false;
    public Text stateTitle;

    void Awake () {
        string dataAsJson = File.ReadAllText("Assets/Data/StateChemicals.json");
        states = JsonUtility.FromJson<AllStateChemInfo>(dataAsJson);

        statesDict.Add("AL", states.AL);
        statesDict.Add("AZ", states.AZ);
        statesDict.Add("AR", states.AR);
        statesDict.Add("CA", states.CA);
        statesDict.Add("CO", states.CO);
        statesDict.Add("CT", states.CT);
        statesDict.Add("DE", states.DE);
        statesDict.Add("FL", states.FL);
        statesDict.Add("GA", states.GA);
        statesDict.Add("ID", states.ID);
        statesDict.Add("IL", states.IL);
        statesDict.Add("IN", states.IN);
        statesDict.Add("IA", states.IA);
        statesDict.Add("KS", states.KS);
        statesDict.Add("KY", states.KY);
        statesDict.Add("LA", states.LA);
        statesDict.Add("ME", states.ME);
        statesDict.Add("MD", states.MD);
        statesDict.Add("MA", states.MA);
        statesDict.Add("MI", states.MI);
        statesDict.Add("MN", states.MN);
        statesDict.Add("MS", states.MS);
        statesDict.Add("MO", states.MO);
        statesDict.Add("MT", states.MT);
        statesDict.Add("NE", states.NE);
        statesDict.Add("NV", states.NV);
        statesDict.Add("NH", states.NH);
        statesDict.Add("NJ", states.NJ);
        statesDict.Add("NM", states.NM);
        statesDict.Add("NY", states.NY);
        statesDict.Add("NC", states.NC);
        statesDict.Add("ND", states.ND);
        statesDict.Add("OH", states.OH);
        statesDict.Add("OK", states.OK);
        statesDict.Add("OR", states.OR);
        statesDict.Add("PA", states.PA);
        statesDict.Add("RI", states.RI);
        statesDict.Add("SC", states.SC);
        statesDict.Add("SD", states.SD);
        statesDict.Add("TN", states.TN);
        statesDict.Add("TX", states.TX);
        statesDict.Add("UT", states.UT);
        statesDict.Add("VT", states.VT);
        statesDict.Add("VA", states.VA);
        statesDict.Add("WA", states.WA);
        statesDict.Add("WV", states.WV);
        statesDict.Add("WI", states.WI);
        statesDict.Add("WY", states.WY);
    }

    public void genGraph(string stateTag) {
        StateChemInfo state = statesDict[stateTag];

        values[0] = state.value1;
        values[1] = state.value2;
        values[2] = state.value3;
        values[3] = state.value4;
        values[4] = state.value5;
        values[5] = state.value6;
        values[6] = state.value7;
        values[7] = state.value8;
        values[8] = state.value9;
        values[9] = state.value10;

        wedgeColors[0] = new Color(1, 0, 0, 1);
        wedgeColors[1] = new Color(0, 1, 0, 1);
        wedgeColors[2] = new Color(0, 0, 1, 1);
        wedgeColors[3] = new Color(1, 0, 1, 1);
        wedgeColors[4] = new Color(1, 1, 0, 1);
        wedgeColors[5] = new Color(0, 1, 1, 1);
        wedgeColors[6] = new Color(0.5f, 0.5f, 0, 1);
        wedgeColors[7] = new Color(0, 0.5f, 0.5f, 1);
        wedgeColors[8] = new Color(0.5f, 0, 0.5f, 1);
        wedgeColors[9] = new Color(1, 1, 1, 1);
        stateTitle.text = stateTag;
        MakeGraph();
    }

    void MakeGraph()
    {
        float total = 0f;
        float zRotation = 0f;
        for (int i = 0; i < values.Length; i++)
        {
            total += values[i];
        }

        for (int i = 0; i < values.Length; i++)
        {
            Image newWedge = Instantiate(wedgePrefab) as Image;
            newWedge.transform.SetParent(transform, false);
            newWedge.color = wedgeColors[i];
            newWedge.fillAmount = values[i] / total;
            newWedge.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, zRotation));
            zRotation -= newWedge.fillAmount * 360f;
        }

        target = midTarget;
        generated = true;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, expandSpeed * Time.deltaTime);
    }
}
