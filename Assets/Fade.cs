using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

	public float speed = 0.01f;
	public float speedin = 0.1f;
	public float count = 1f;
	public CanvasGroup canvasGroup;
	public bool isFeedin;
	
	// Update is called once per frame
	void Update () {
		if (isFeedin == true) {
			canvasGroup.alpha += speedin;
		}
		else {
			canvasGroup.alpha -= speed;
		}
	}
}
