using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Flags : MonoBehaviour {

	private PlayerViewController player {
		get { return PlayerViewController.instance; }
	}
	private StageManager stage { 
		get { return StageManager.instance; }
	}

	public bool FullfillTalkCount (int targetCharacterId, int count) {
		var todayTalks = TodaysTalks ();
		var charaTalk = (from t in todayTalks
			where t.companionId == targetCharacterId
			select t).ToList();
		return (charaTalk.Count >= count) ? true : false;
	}

	public List<TalkInfo> TodaysTalks () {
		var talks = (from t in player.Talks
			where t.day == stage.day
			select t).ToList();
		return talks;
	}

}
