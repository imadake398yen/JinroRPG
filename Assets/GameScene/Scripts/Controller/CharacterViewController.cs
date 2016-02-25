using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterViewController : MonoBehaviour {
	
	public Camera characterCamera;
	public CharacterData data;
	public CharacterTalkView talkView;

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			int num = int.Parse(other.gameObject.name.Substring(0,1));
			characterCamera.enabled = true;
		}
	}

	void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player") {
			int num = int.Parse(other.gameObject.name.Substring(0,1));
			characterCamera.enabled = false;
		}
		
		
	}

}
