using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StageManager : MonoBehaviour {

	public static StageManager instance;

	int day;
	[SerializeField]
	public List<CharacterViewController> characters = new List<CharacterViewController>();
	string[,] characterDataBase;
	public Transform[] charaPos;

	void Awake () {
		instance = this;
		//キャラクターデータベースをGameManagerから取ってきて、配列の大きさを決める
		characterDataBase = GameManager.instance.GetCharacterDataBase();
		//characterDataBase = new string[16,7];
	}

	// Use this for initialization
	void Start () {
		//キャラクタデータベースをキャラクターの数まで付け加えていく
		characterDataBase = GameManager.instance.GetCharacterDataBase();
		//インスタンスの作成
		//GetLength(0)が縦,(1)が横
		//横列(人数)分だけ処理をする
		//print(characterDataBase.GetLength(1)-1);
		for (int i=0; i<characterDataBase.GetLength(1)-1; i++ ) {
			//クラス		  インスタンス
			CharacterData d = new CharacterData();
			d.SetCharaData(GetRaw(i));
			print(d.avatarId);
			GameObject obj = Instantiate(Resources.Load("Character/" 
				+ d.avatarId.ToString())) as GameObject;
			//位置を指定
			print(i);
			obj.transform.position = charaPos[i].position;
			characters.Add(obj.GetComponent<CharacterViewController>());
			//オブジェクトのCharacterViewControllerに今作ったdを入れる
			characters[i].data = d;
		}
	}
	
	//キャラクターの数の分だけ、データをセットする
	public string[] GetRaw (int rowNum) {
		string[] data = new string[ characterDataBase.GetLength(0) ];
		for (int i=0; i<characterDataBase.GetLength(0); i++){
			data[i] = characterDataBase[i, rowNum];
		}
		return data;
	}

	//次の日になるメソッド
	public void NextDay () {
		day += 1;
	}
}
