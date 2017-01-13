using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VoteController : MonoBehaviour {
	VoteCharacterView[] voteCharacters;

	public Text
		nameText, 
		actorText;
	public Image 
		faceImage,
		selectImage,
		deadImage;

	public CharacterData data;

	//VoteCharacterViewに情報を貼り付ける
	public void UpdateValue (CharacterData d) {
		data = d;
		nameText.text = data.name;
		actorText.text = ((Const.ActRole)data.actRole).ToJapanese();
		faceImage.sprite = Resources.Load<Sprite>("CharacterImages/" + data.id.ToString());
		deadImage.gameObject.SetActive(!data.isLive);
	}

	public void PushSelf () {
		if (data.isLive) {
			data.isLive = false;
			// foreach (var chara in StageManager.instance.characters) {
			// 	if (chara.data.id == data.id) {
			// 		print(data.name);
			// 		print(chara.gameObject.name);
			// 		chara.gameObject.SetActive(false);
			// 		deadImage.enabled = true;
			// 		break;
			// 	}
			// }
			var chara = StageManager.instance.characters.Find(c => c.data.id == data.id);
			print(chara.data.name);
			chara.gameObject.SetActive(false);
			GameManager.instance.voteCharacterView.SetActive(false);
		} 
		else {

		}
	}
}
