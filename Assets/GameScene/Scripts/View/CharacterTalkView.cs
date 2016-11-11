using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterTalkView : MonoBehaviour {

	private Text nameLabel, contentLabel;

	public void UpdateTextView (string name, string talk) {
		if (contentLabel == null) Initialize();
		nameLabel.text = name;
		StartCoroutine(SetText(contentLabel, talk));
	}

	private IEnumerator SetText (Text label, string text) {
		for(int i=0;i<text.Length;i++){
			label.text = text.Substring(0,i);
			yield return new WaitForSeconds(0.04f);
		}
	}

	private void Initialize () {
		nameLabel = transform.FindChild("Canvas/Panel/name").GetComponent<Text>();
		contentLabel = transform.FindChild("Canvas/Panel/talk").GetComponent<Text>();
	}
	
	
}
