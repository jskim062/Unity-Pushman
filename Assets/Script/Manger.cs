using UnityEngine;
using System.Collections;

public class Manger : MonoBehaviour {

	public int Count;
	public float _time;
	bool End;
	public GUIText Text_time;
	
	public GameObject ClearGUI;
	public GameObject FailGUI;
	void OnTriggerEnter(Collider Get){
		// Debug.Log("box trigger in");
		Debug.Log("box trigger in = " + Get.collider.tag );
		
	if (Get.collider.tag == "Box"){
			Debug.Log("box if in");
			Count = Count + 1;
			Debug.Log("Count num = " + Count);
		}
		
	if(Get.collider.tag == "Player" && End == false){
			End = true;
			FailGUI.SetActive(true);
			//Replay_Button_Obj.SetActive(true);
		}
		
	if(Count>=16 && End == false){
		End=true;
		ClearGUI.SetActive(true);
		//Replay_Button_Obj.SetActive(true);
	}
}

	
	// Update is called once per frame
	void Update () {
		if(End==false){
			_time+=Time.deltaTime;
	
		}
	Text_time.text = _time.ToString();
	}
}
