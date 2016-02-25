using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	private TextAsset 	charactersCSV,
						avatarCSV,jobCSV,
						modeCSV,
						personalityCSV,
						stageCSV,
						teamCSV,
						weakModeCSV,
						workModeCSV;

	private string[,] 	characterDataBase,
						avatarDataBase,
						jobDataBase,
						modeDataBase,
						personalityDataBase,
						stageDataBase,
						teamDataBase,
						weakModeDataBase,
						workModeDataBase;

	void Awake(){
		if(instance == null){
			instance = this;
			//シーンをまたいでも消えないオブジェクト
			GameObject.DontDestroyOnLoad(this.gameObject);
		}else{
			GameObject.Destroy(this.gameObject);
		}
	}
	
	public List<CharacterData> character = new List<CharacterData>();
	Dictionary<int, CharacterData> characterDictionary = new Dictionary<int, CharacterData>();

	public void SetAllCharacterData (string csvData) {
		charactersCSV = Resources.Load("characters") as TextAsset;
		avatarCSV = Resources.Load("avatar") as TextAsset;
		jobCSV = Resources.Load("job") as TextAsset;
		modeCSV = Resources.Load("mode") as TextAsset;
		personalityCSV = Resources.Load("personality") as TextAsset;
		stageCSV = Resources.Load("stage") as TextAsset;
		teamCSV = Resources.Load("team") as TextAsset;
		weakModeCSV = Resources.Load("weakMode") as TextAsset;
		workModeCSV = Resources.Load("workMode") as TextAsset;

		characterDataBase = CSVReader.SplitCsvGrid(charactersCSV.text);
		avatarDataBase = CSVReader.SplitCsvGrid(avatarCSV.text);
		jobDataBase = CSVReader.SplitCsvGrid(jobCSV.text);
		modeDataBase = CSVReader.SplitCsvGrid(modeCSV.text);
		personalityDataBase = CSVReader.SplitCsvGrid(personalityCSV.text);
		stageDataBase = CSVReader.SplitCsvGrid(stageCSV.text);
		teamDataBase = CSVReader.SplitCsvGrid(teamCSV.text);
		weakModeDataBase = CSVReader.SplitCsvGrid(weakModeCSV.text);
		workModeDataBase = CSVReader.SplitCsvGrid(workModeCSV.text);

	}

	public string[,] GetCharacterDataBase () {
		return this.characterDataBase;
	}

	public string[,] GetAvatarDataBase () {
		return this.avatarDataBase;
	}

	public string[,] GetJobDataBase () {
		return this.jobDataBase;
	}

	public string[,] GetModeDataBase () {
		return this.modeDataBase;
	}

	public string[,] GetPersonalityDataBase () {
		return this.personalityDataBase;
	}

	public string[,] GetStageDataBase () {
		return this.stageDataBase;
	}

	public string[,] GetTeamDataBase () {
		return this.teamDataBase;
	}

	public string[,] GetWeakModeDataBase () {
		return this.weakModeDataBase;
	}

	public string[,] GetWorkModeDataBase () {
		return this.workModeDataBase;
	}

	//改行
	string SplitNewLine(string talk){
		string[] divideTalk = talk.Split(':');
		string newLine = "";
		for(int i=0; i<divideTalk.Length; i++){
			newLine += divideTalk[i] + "\n";
		}
		return newLine;
	}


	public void ChangeScene (string sceneName) {
		UnityEngine.SceneManagement.SceneManager.LoadScene (sceneName);
	}

}
