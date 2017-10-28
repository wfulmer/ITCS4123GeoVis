using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class AllStateReleasePercentages
{
    public StatePercents WA;
    public StatePercents DE;
    public StatePercents DC;
    public StatePercents WI;
    public StatePercents WV;
    public StatePercents FL;
    public StatePercents WY;
    public StatePercents NH;
    public StatePercents NJ;
    public StatePercents NM;
    public StatePercents TX;
    public StatePercents LA;
    public StatePercents NC;
    public StatePercents ND;
    public StatePercents NE;
    public StatePercents TN;
    public StatePercents NY;
    public StatePercents PA;
    public StatePercents CT;
    public StatePercents RI;
    public StatePercents NV;
    public StatePercents VA;
    public StatePercents CO;
    public StatePercents CA;
    public StatePercents AL;
    public StatePercents AS;
    public StatePercents AR;
    public StatePercents VT;
    public StatePercents IL;
    public StatePercents GA;
    public StatePercents IN;
    public StatePercents IA;
    public StatePercents MA;
    public StatePercents AZ;
    public StatePercents ID;
    public StatePercents ME;
    public StatePercents MD;
    public StatePercents OK;
    public StatePercents OH;
    public StatePercents UT;
    public StatePercents MO;
    public StatePercents MN;
    public StatePercents MI;
    public StatePercents KS;
    public StatePercents MT;
    public StatePercents MS;
    public StatePercents SC;
    public StatePercents KY;
    public StatePercents OR;
    public StatePercents SD;
    public StatePercents HI;
    public StatePercents AK;
}

[System.Serializable]
public class StatePercents
{
    public float CLEAR_AIR_ACT_CHEMICAL;
    public float CARCINOGEN;
    public float METAL;
    public float FEDERAL_FACILITY;
}

public class StatePercentages : MonoBehaviour {

    public int year = 2015;

    private void Awake()
    {
        string dataAsJson = File.ReadAllText("Assets/Data/StatePercentages" + year + ".json");
        AllStateReleasePercentages percents = JsonUtility.FromJson<AllStateReleasePercentages>(dataAsJson);

        Debug.Log("AK METAL: " + percents.AK.METAL + "%");
    }
}
