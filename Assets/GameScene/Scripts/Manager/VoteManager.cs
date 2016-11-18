using UnityEngine;
using System.Collections;

public class VoteManager : MonoBehaviour {

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
