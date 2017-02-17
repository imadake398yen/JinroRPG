using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerViewController 
: SingletonMonoBehaviour<PlayerViewController> {

	[SerializeField]
	private List<TalkInfo> talks = new List<TalkInfo>();
	public List<TalkInfo> Talks { get{ return talks; } }

	private FirstPersonController firstPersonController;

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
}
