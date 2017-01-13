using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

[System.SerializableAttribute]

public class CharacterData {

	public string 
		name;
	public int  
		id,
		role,
		actRole,
		team,
		personality,
		avatarId,
		eatenTurn,
		eatenTurn2,
		fortuneTurn,
		guardTurn,
		fakeFortuneTurn,
		fortuneResult,
		fakeFortuneResult;
	public bool isLive = true;
	public string[,] talks;

	CharacterViewController characterController;

	//キャラクターデータをCSVの何行目に値するかを設定
	public void SetCharaData (string[] data) {
		string da = "";
		foreach (string d in data) {
			da += ( d + ", " );
		}
		// UnityEngine.Debug.Log(da);
		id = int.Parse(data[1]);
		name = data[2];
		role = int.Parse(data[3]);
		actRole = int.Parse(data[4]);
		team = int.Parse(data[5]);
		personality = int.Parse(data[6]);
		avatarId = int.Parse(data[7]);
		eatenTurn = int.Parse(data[8]);
		eatenTurn2 = int.Parse(data[9]);
		fortuneTurn = int.Parse(data[10]);
		fakeFortuneTurn = int.Parse(data[11]);
		guardTurn = int.Parse(data[12]);
		fortuneResult = int.Parse(data[13]);
		fakeFortuneResult = int.Parse(data[14]);

		TextAsset textAsset = Resources.Load("WordCSV/" + id.ToString()) as TextAsset;
		talks = CSVReader.SplitCsvGrid(textAsset.text);
	}

	//キャラクターが死んだ(投票された)時のメソッド
	public void Dead () {
			isLive = false; 
			if(isLive == false) {
				
			}
	}
}
