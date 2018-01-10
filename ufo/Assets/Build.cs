using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Build {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void BuildiOSForReal () {
        string[] scenes = { "Assets/Main.unity" };
        BuildPipeline.BuildPlayer(scenes,"/.",BuildTarget.iOS,BuildOptions.None);
	}
}
