using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StageManager : MonoBehaviour {
	int date;
	[SerializeField]
	private CharacterViewController[] characters;
	string[,] characterDataBase;

	void Awake () {
		characterDataBase = GameManager.instance.GetCharacterDataBase();
		characterDataBase = new string[14,7];
	}

	// Use this for initialization
	void Start () {
		characterDataBase = GameManager.instance.GetCharacterDataBase();
		for (int i=0; i<characters.Length; i++ ) {
			characters[i].data.SetCharaData(GetRaw(i));
		}
	}
	
	public string[] GetRaw (int rowNum) {
		string[] data = new string[ characterDataBase.GetLength(1) ];
		for (int i=0; i<characterDataBase.GetLength(1); i++){
			data[i] = characterDataBase[rowNum, i];
			print(data[i]);
		}
		return data;
	}
}
