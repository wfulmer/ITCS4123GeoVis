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

    public Transform ChemBar1;
    public Transform ChemBar2;
    public Transform ChemBar3;
    public Transform ChemBar4;
    public Transform ChemBar5;
    public Transform ChemBar6;
    public Transform ChemBar7;
    public Transform ChemBar8;
    public Transform ChemBar9;
    public Transform ChemBar10;
    public Text ChemBar1Text;
    public Text ChemBar2Text;
    public Text ChemBar3Text;
    public Text ChemBar4Text;
    public Text ChemBar5Text;
    public Text ChemBar6Text;
    public Text ChemBar7Text;
    public Text ChemBar8Text;
    public Text ChemBar9Text;
    public Text ChemBar10Text;

    private AllStateChemInfo states;
    private Dictionary<string, StateChemInfo> statesDict = new Dictionary<string, StateChemInfo>();

    void Awake () {
        string dataAsJson = File.ReadAllText("Assets/Data/StateChemicals.json");
        states = JsonUtility.FromJson<AllStateChemInfo>(dataAsJson);

        

        Debug.Log(states.NC.name1);
        Debug.Log(states.NC.value1);

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

        ChemBar1Text.text = state.name1;
        Debug.Log(state.name1);
        ChemBar2Text.text = state.name2;
        ChemBar3Text.text = state.name3;
        ChemBar4Text.text = state.name4;
        ChemBar5Text.text = state.name5;
        ChemBar6Text.text = state.name6;
        ChemBar7Text.text = state.name7;
        ChemBar8Text.text = state.name8;
        ChemBar9Text.text = state.name9;
        ChemBar10Text.text = state.name10;

        ChemBar1.position = new Vector3(-220, 60, -230) + new Vector3(0, ((state.value1 - 20f) / 2.0f), 0);
        ChemBar1.localScale = new Vector3(20, state.value1, 20);
        ChemBar2.position = new Vector3(-220, 60, -210) + new Vector3(0, ((state.value2 - 20f) / 2.0f), 0);
        ChemBar2.localScale = new Vector3(20, state.value2, 20);
        ChemBar3.position = new Vector3(-220, 60, -190) + new Vector3(0, ((state.value3 - 20f) / 2.0f), 0);
        ChemBar3.localScale = new Vector3(20, state.value3, 20);
        ChemBar4.position = new Vector3(-220, 60, -170) + new Vector3(0, ((state.value4 - 20f) / 2.0f), 0);
        ChemBar4.localScale = new Vector3(20, state.value4, 20);
        ChemBar5.position = new Vector3(-220, 60, -150) + new Vector3(0, ((state.value5 - 20f) / 2.0f), 0);
        ChemBar5.localScale = new Vector3(20, state.value5, 20);
        ChemBar6.position = new Vector3(-220, 60, -130) + new Vector3(0, ((state.value6 - 20f) / 2.0f), 0);
        ChemBar6.localScale = new Vector3(20, state.value6, 20);
        ChemBar7.position = new Vector3(-220, 60, -110) + new Vector3(0, ((state.value7 - 20f) / 2.0f), 0);
        ChemBar7.localScale = new Vector3(20, state.value7, 20);
        ChemBar8.position = new Vector3(-220, 60, -90) + new Vector3(0, ((state.value8 - 20f) / 2.0f), 0);
        ChemBar8.localScale = new Vector3(20, state.value8, 20);
        ChemBar9.position = new Vector3(-220, 60, -70) + new Vector3(0, ((state.value9 - 20f) / 2.0f), 0);
        ChemBar9.localScale = new Vector3(20, state.value9, 20);
        ChemBar10.position = new Vector3(-220, 60, -50) + new Vector3(0, ((state.value10 - 20f) / 2.0f), 0);
        ChemBar10.localScale = new Vector3(20, state.value10, 20);
    }
}
