using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerViewController 
: SingletonMonoBehaviour<PlayerViewController> {

	public FirstPersonController firstPersonController;

	public void FreezePlayer () {
		firstPersonController.enabled = false;
	}

	public void MovePlayer () {
		firstPersonController.enabled = true;
	}
}
