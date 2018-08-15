using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour
{
	public float Power = 200f;
	public float Range = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	Debug.DrawRay(transform.position, this.transform.forward * Range, Color.red);
		
	if(Input.GetKeyDown(KeyCode.Space)){
		
		RaycastHit hit;
		if(Physics.Raycast(transform.position, transform.forward, out hit, Range))
		{
			if(hit.collider.gameObject.tag == "Box"){
				Debug.Log(hit.collider.name);
				hit.rigidbody.AddForceAtPosition(transform.forward * Power, hit.point);
				}
			}	
		}
	}
}