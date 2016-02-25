using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterTalkView : MonoBehaviour {

	private Text nameLabel, contentLabel;

	public void UpdateTextView (string name, string talk) {
		if (contentLabel == null) GetReference();
		nameLabel.text = name;
		StartCoroutine(SetText(contentLabel, talk));
	}

	private IEnumerator SetText (Text label, string text) {
		for(int i=0;i<text.Length;i++){
			label.text = text.Substring(0,i);
			yield return new WaitForSeconds(0.04f);
		}
	}

	private void GetReference () {
		nameLabel = transform.FindChild("NameLabel").GetComponent<Text>();
		contentLabel = transform.FindChild("ContentLabel").GetComponent<Text>();
	}
	
	
}
