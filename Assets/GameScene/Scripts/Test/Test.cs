using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Test : MonoBehaviour {

	public int column = 0;
	public string[] characterRawData;


	public string[,] arrayTest = new string[2,3]{
		{"佐藤","田中","鈴木"},
		{"高橋","竹田","安川"}
	};


	void Start () {
			GetRaw(column);
			characterRawData = GetRaw(column);
	}
	// Use this for initialization
	private string[] GetRaw (int rowNumber) {
		string[] data = new string[arrayTest.GetLength(1)];
		for (int i=0; i<arrayTest.GetLength(1); i++){
			data[i] = arrayTest[rowNumber,i];
		}
		return data;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
