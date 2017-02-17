[System.SerializableAttribute]
public class TalkInfo {

	private int 
		day,
		companionId;

	public TalkInfo (CharacterData data) {
		day = StageManager.instance.day;
		companionId = data.id;
	}

}
