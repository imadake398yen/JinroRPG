using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VoteManager : SingletonMonoBehaviour<VoteManager> {

	public int selector = 0;
	public GameObject voteControllerPrefab;
	public List<VoteController> voteControllers = new List<VoteController>();
	public GameObject log;
	public Fade repetitionVotePanel;

	private void Left () {
		if (voteControllers.Count > 0) {
			if (selector == 0) {
				selector = voteControllers.Count - 1;
			} else selector -= 1;
			UpdateSelector();
		}
	}
	private void Right () {
		if (voteControllers.Count > 0) {
			if (selector == voteControllers.Count - 1) {
				selector = 0;
			} else selector += 1;
			UpdateSelector();
		}
	}

	private void Vote () {
		if(voteControllers[selector].data.isLive == true){
			print(voteControllers[selector].name);
			voteControllers[selector].PushSelf();
			PlayerViewController.instance.MovePlayer();
		}else {
			log.SetActive(true);
			repetitionVotePanel.isFeedin = true;
			Invoke("fadeOut",2f);
		}
	}
	private void fadeOut () {
		repetitionVotePanel.isFeedin = false;
	}

	private void Update () {
		if (Input.GetKeyDown("right")) Right();
		if (Input.GetKeyDown("left")) Left();
		if(Input.GetKeyUp(KeyCode.Return)) Vote();
	}


	private void UpdateSelector () {
		for (int i = 0; i < voteControllers.Count; i++) {
			if (i == selector) {
				voteControllers[i].selectImage.gameObject.SetActive(true);
			}else {
				voteControllers[i].selectImage.gameObject.SetActive(false);
			}
		}
	}

	public void UpdateVoteControllers () {

		//もし既にVoteControllersがあったら削除する
		foreach (var v in voteControllers) {
			Destroy(v.gameObject, 0.01f);
		} voteControllers = new List<VoteController>();


		//人数分VoteControllerを生成する
		for (int i = 0; i < StageManager.instance.characters.Count; i++) {
			GameObject obj = Instantiate(voteControllerPrefab);
			obj.transform.SetParent(this.transform);
			obj.transform.localPosition = Vector3.zero;
			obj.transform.localScale = Vector3.one;
			var voteController = obj.GetComponent<VoteController>();
			voteControllers.Add(voteController);
			voteControllers[i].UpdateValue(StageManager.instance.characters[i].data);
		}
		StageManager.instance.NextDay();
	}
	
}
