[System.SerializableAttribute]
public class CharacterData {

	public string name;
	public int  id,
				role,
				actRole,
				team,
				personality,
				avatar,
				eatenTurn,
				fortuneTurn,
				guardTurn,
				fakeFortuneTurn,
				fortuneResult,
				fakeFortuneResult;

	CharacterViewController characterController;

	public void SetCharaData (string[] data) {
		string da = "";
		foreach (string d in data) {
			da += ( d + ", " );
		}
		UnityEngine.Debug.Log (da);
		id = int.Parse(data[1]);
		name = data[2];
		UnityEngine.Debug.Log (name);
		UnityEngine.Debug.Log (data.Length);
		personality = int.Parse(data[3]);
		role = int.Parse(data[4]);
		actRole = int.Parse(data[5]);
		team = int.Parse(data[6]);
		avatar = int.Parse(data[7]);
		eatenTurn = int.Parse(data[8]);
		fortuneTurn = int.Parse(data[9]);
		fakeFortuneTurn = int.Parse(data[10]);
		guardTurn = int.Parse(data[11]);
		fortuneResult = int.Parse(data[12]);
		fakeFortuneResult = int.Parse(data[13]);
	}
}
