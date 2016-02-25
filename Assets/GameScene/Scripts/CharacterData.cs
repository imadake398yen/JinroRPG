using UnityEngine;
using System.Collections;

public class CharacterData : MonoBehaviour {

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
		id = int.Parse(data[1]);

	}
}
