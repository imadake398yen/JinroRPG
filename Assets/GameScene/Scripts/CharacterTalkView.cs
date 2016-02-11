using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterTalkView : MonoBehaviour {

	private Text nameLabel, contentLabel;

	public void UpdateTextView (string name, string talk) {
		if (contentLabel == null) GetReference();
		nameLabel.text = name;
		contentLabel.text = talk;
	}

	private void GetReference () {
		nameLabel = transform.FindChild("NameLabel").GetComponent<Text>();
		contentLabel = transform.FindChild("ContentLabel").GetComponent<Text>();
	}
	
	
}
