using UnityEngine;
using System.Collections;

public class VoteManager : MonoBehaviour {

	public VoteController[] voteControllers;

	public void UpdateVoteControllers () {
		for (int i=0; i<StageManager.instance.characters.Count; i++) {
			voteControllers[i].UpdateValue(StageManager.instance.characters[i].data);
		}
	}
	
}
