using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VoteController : MonoBehaviour {
	VoteCharacterView[] voteCharacters;

	public Text
		nameText, actorText;
	public Image faceImage;

	[HideInInspector]
	public CharacterData data;

	public void UpdateValue (CharacterData d) {
		data = d;
		nameText.text = data.name;
		actorText.text = ((Const.ActRole)data.actRole).ToJapanese();
	}

	public void PushSelf () {
		data.isLive = false;
		//StageManager.instance.day += 1;
		foreach (var chara in StageManager.instance.characters) {
			if (chara.data.id == data.id) {
				Destroy(chara.gameObject);
				break;
			}
		}
		GameManager.instance.voteCharacterView.SetActive(false);

		
	}
}
