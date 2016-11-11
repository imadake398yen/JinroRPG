public static partial class Const {
	public enum ActRole {
		Villager = 0,
		Augur = 1,
		Medium = 2,
		Guard = 3,
		Werewolf = 4,
		Madman = 5
	}

	public static string ToJapanese (this ActRole val) {
		string s = "";
		switch (val) {
			case Const.ActRole.Villager:
				s = "村人";
				break;
			case Const.ActRole.Augur:
				s = "占い師";
				break;
			case Const.ActRole.Medium:
				s = "霊媒師";
				break;
			case Const.ActRole.Guard:
				s = "狩人";
				break;
			case Const.ActRole.Werewolf:
				s = "人狼";
				break;
			case Const.ActRole.Madman:
				s = "狂人";
				break;
		} 
		return s;
	}
}