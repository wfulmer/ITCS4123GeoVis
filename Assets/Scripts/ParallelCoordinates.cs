using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ParallelCoordinates : MonoBehaviour {
    
    public int year = 2015;
    
	void Awake () {
        string dataAsJson = File.ReadAllText("Assets/Data/StatePercentages" + year + ".json");
        AllStateReleasePercentages percents = JsonUtility.FromJson<AllStateReleasePercentages>(dataAsJson);

        /*
         * Axes:
         * Start: 200, 50 -> 150, -50
         * Carcinogen: 200, 50 -> 150, -150
         * Clean Air: 200, 50 -> 150, -300
         * Metal: 200, 50 -> 150, -450
         * Federal: 200, 50 -> 150, -600
        */


        GameObject lineObject = new GameObject("AL Line");
        LineRenderer line = lineObject.AddComponent<LineRenderer>();
        line.positionCount = 5;
        Vector3[] positions = new Vector3[5];
        positions[0] = new Vector3(200, 175, -50);
        positions[1] = new Vector3(200, (percents.AL.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.AL.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.AL.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.AL.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);

        lineObject = new GameObject("AZ Line");
        line = lineObject.AddComponent<LineRenderer>();
        line.positionCount = 5;
        positions = new Vector3[5];
        positions[0] = new Vector3(200, 170, -50);
        positions[1] = new Vector3(200, (percents.AZ.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.AZ.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.AZ.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.AZ.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);
    }
}
