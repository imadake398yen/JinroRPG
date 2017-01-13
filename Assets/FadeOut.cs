using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {
	public float speed = 0.01f;
	public float count = 1f;
	public CanvasGroup logGroup;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		StartFadeOut(logGroup);
	}

	void StartFadeOut (CanvasGroup canvasGroup) {
		canvasGroup.alpha -= speed;
	}
}
