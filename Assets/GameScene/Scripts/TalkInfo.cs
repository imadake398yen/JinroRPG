[System.SerializableAttribute]
public class TalkInfo {

	public int 
		day,
		companionId;

	public TalkInfo (CharacterData data) {
		day = StageManager.instance.day;
		companionId = data.id;
	}

}
