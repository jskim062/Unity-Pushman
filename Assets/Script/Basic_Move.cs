using UnityEngine;
using System.Collections;

public class Basic_Move : MonoBehaviour {
	public int speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown(KeyCode.LeftArrow)){
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
	if(Input.GetKeyDown(KeyCode.RightArrow)){
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}			
	if(Input.GetKeyDown(KeyCode.UpArrow)){
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
	if(Input.GetKeyDown(KeyCode.DownArrow)){
			transform.Translate(Vector3.back* speed * Time.deltaTime);
		}
	}
}
