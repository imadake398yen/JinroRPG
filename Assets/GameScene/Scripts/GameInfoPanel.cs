using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameInfoPanel : MonoBehaviour {

	public Text infoLabel;

	private void Update ()
	{
		infoLabel.text = "今" + StageManager.instance.day + "日目";
	}

}
