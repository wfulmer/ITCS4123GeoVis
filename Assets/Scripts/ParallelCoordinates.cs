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
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.endColor = new Color(0, 255, 255, 1);
        line.startColor = new Color(0, 255, 255, 1);
        Vector3[] positions = new Vector3[5];
        positions[0] = new Vector3(200, 175, -50);
        positions[1] = new Vector3(200, (percents.AL.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.AL.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.AL.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.AL.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);

        lineObject = new GameObject("AK Line");
        line = lineObject.AddComponent<LineRenderer>();
        line.positionCount = 5;
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.endColor = new Color(0, 255, 255, 1);
        line.startColor = new Color(0, 255, 255, 1);
        positions = new Vector3[5];
        positions[0] = new Vector3(200, 170, -50);
        positions[1] = new Vector3(200, (percents.AK.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.AK.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.AK.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.AK.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);
        
        lineObject = new GameObject("AZ Line");
        line = lineObject.AddComponent<LineRenderer>();
        line.positionCount = 5;
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.endColor = new Color(0, 255, 255, 1);
        line.startColor = new Color(0, 255, 255, 1);
        positions = new Vector3[5];
        positions[0] = new Vector3(200, 165, -50);
        positions[1] = new Vector3(200, (percents.AZ.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.AZ.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.AZ.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.AZ.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);

        lineObject = new GameObject("AR Line");
        line = lineObject.AddComponent<LineRenderer>();
        line.positionCount = 5;
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.endColor = new Color(0, 255, 255, 1);
        line.startColor = new Color(0, 255, 255, 1);
        positions = new Vector3[5];
        positions[0] = new Vector3(200, 160, -50);
        positions[1] = new Vector3(200, (percents.AR.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.AR.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.AR.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.AR.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);

        lineObject = new GameObject("CA Line");
        line = lineObject.AddComponent<LineRenderer>();
        line.positionCount = 5;
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.endColor = new Color(0, 255, 255, 1);
        line.startColor = new Color(0, 255, 255, 1);
        positions = new Vector3[5];
        positions[0] = new Vector3(200, 155, -50);//x, 155, x; change the middle number by 5 each time
        positions[1] = new Vector3(200, (percents.CA.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.CA.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.CA.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.CA.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);

        lineObject = new GameObject("CO Line");
        line = lineObject.AddComponent<LineRenderer>();
        line.positionCount = 5;
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.endColor = new Color(0, 255, 255, 1);
        line.startColor = new Color(0, 255, 255, 1);
        positions = new Vector3[5];
        positions[0] = new Vector3(200, 150, -50);
        positions[1] = new Vector3(200, (percents.CO.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.CO.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.CO.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.CO.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);

        lineObject = new GameObject("CT Line");
        line = lineObject.AddComponent<LineRenderer>();
        line.positionCount = 5;
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.endColor = new Color(0, 255, 255, 1);
        line.startColor = new Color(0, 255, 255, 1);
        positions = new Vector3[5];
        positions[0] = new Vector3(200, 145, -50);
        positions[1] = new Vector3(200, (percents.CT.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.CT.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.CT.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.CT.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);

        lineObject = new GameObject("DE Line");
        line = lineObject.AddComponent<LineRenderer>();
        line.positionCount = 5;
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.endColor = new Color(0, 255, 255, 1);
        line.startColor = new Color(0, 255, 255, 1);
        positions = new Vector3[5];
        positions[0] = new Vector3(200, 140, -50);
        positions[1] = new Vector3(200, (percents.DE.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.DE.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.DE.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.DE.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);

        lineObject = new GameObject("FL Line");
        line = lineObject.AddComponent<LineRenderer>();
        line.positionCount = 5;
        line.material = new Material(Shader.Find("Particles/Additive"));
        line.endColor = new Color(0, 255, 255, 1);
        line.startColor = new Color(0, 255, 255, 1);
        positions = new Vector3[5];
        positions[0] = new Vector3(200, 135, -50);
        positions[1] = new Vector3(200, (percents.FL.CARCINOGEN) + 50, -150);
        positions[2] = new Vector3(200, (percents.FL.CLEAR_AIR_ACT_CHEMICAL) + 50, -300);
        positions[3] = new Vector3(200, (percents.FL.METAL) + 50, -450);
        positions[4] = new Vector3(200, (percents.FL.FEDERAL_FACILITY) + 50, -600);
        line.SetPositions(positions);
    }
}
