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
		print(data.isLive);
		if (data.isLive) {
			data.isLive = false;
			var chara = StageManager.instance.characters.Find(c => c.data.id == data.id);
			print(chara.data.name);
			chara.gameObject.SetActive(false);
			GameManager.instance.voteCharacterView.SetActive(false);
		} 
		else {
		}
	}
}
