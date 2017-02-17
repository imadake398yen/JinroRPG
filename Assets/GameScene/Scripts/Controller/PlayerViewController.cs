using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using System.Linq;

public class PlayerViewController 
: SingletonMonoBehaviour<PlayerViewController> {

	
	[SerializeField]
	private FirstPersonController firstPersonController;

	[SerializeField]
	private List<TalkInfo> talks = new List<TalkInfo>();
	public List<TalkInfo> Talks { get{ return talks; } }


	public void FreezePlayer () {
		firstPersonController.enabled = false;
	}

	public void MovePlayer () {
		firstPersonController.enabled = true;
	}

	public void NewTalk (CharacterData data) {
		var talk = new TalkInfo(data);
		talks.Add(talk);
	}

	private void Update () {
		if(Input.GetKeyDown(KeyCode.M)) {
			var characters = StageManager.instance.characters;
			var deads = ( from c in characters
				where c.data.isLive == false
				select c).ToList();
			foreach (var d in deads) {
				print(d.data.name);
			}
		}
	}

}
