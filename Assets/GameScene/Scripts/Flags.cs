using UnityEngine;
using System.Collections;

public class Flags : MonoBehaviour {

	private PlayerViewController player {
		get { return PlayerViewController.instance; }
	}
	private StageManager stage { 
		get { return StageManager.instance; }
	}
	private int currentDay {
		get { return StageManager.instance.day; }
	}

	public static bool FullfillTalkCount (int targetCharacterId) {
		return true;
	}

}
