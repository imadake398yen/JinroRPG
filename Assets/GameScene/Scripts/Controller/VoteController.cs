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
		print(data.name);
		data = d;
		nameText.text = data.name;
		actorText.text = ((Const.ActRole)data.actRole).ToJapanese();
		faceImage.sprite = Resources.Load<Sprite>("CharacterImages/" + data.id.ToString());
	}

	public void PushSelf () {
		data.isLive = false;
		foreach (var chara in StageManager.instance.characters) {
			if (chara.data.id == data.id) {
				Destroy(chara.gameObject);
				break;
			}
		}
		GameManager.instance.voteCharacterView.SetActive(false);

		
	}
}
