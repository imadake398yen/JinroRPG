using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	
	List<CharacterData> character = new List<CharacterData>();
	Dictionary<int, CharacterData> characterDictionary = new Dictionary<int, CharacterData>();

	public void SetAllCharacterData (string csvData) {

		string[,] charactersColumn;
		TextAsset charactersCSV;
		charactersCSV = Resources.Load("characters") as TextAsset;
	} 
}
