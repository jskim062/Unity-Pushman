using UnityEngine;
using System.Collections;

public class SceneMove : MonoBehaviour {
	
	public string SceneName;
	
	public void OnMouseDown(){
		Application.LoadLevel(SceneName);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
