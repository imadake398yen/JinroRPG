using UnityEngine;
using System.Collections;

public class VoteManager : SingletonMonoBehaviour<VoteManager> {

	public int selector = 0;

	private void Left () {
		if (selector == 0) {
			selector = voteControllers.Length - 1;
		} else selector -= 1;
	}
	private void Right () {
		if (selector == voteControllers.Length - 1) {
			selector = 0;
		} else selector += 1;
	}
	private void Update () {
		if (Input.GetKeyDown("right")) Right();
		if (Input.GetKeyDown("left")) Left();
	}



	public VoteController[] voteControllers;

	public void UpdateVoteControllers () {
		for (int i=0; i<voteControllers.Length; i++) {
			if (i < StageManager.instance.characters.Count) {
				voteControllers[i].UpdateValue(StageManager.instance.characters[i].data);
			} else {
				voteControllers[i].gameObject.SetActive(false);
			}
		}
		StageManager.instance.NextDay();
	}
	
}
