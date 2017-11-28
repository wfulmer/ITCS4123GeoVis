using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ParallelCoord : MonoBehaviour {

	// Use this for initialization
	void Start () {//apparently need several gameobjects with a line renderer on each to draw several lines.
        LineRenderer lines = (LineRenderer)gameObject.GetComponent(typeof(LineRenderer));
        //lines.SetVertexCount(10);
        //lines.SetPositions();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
