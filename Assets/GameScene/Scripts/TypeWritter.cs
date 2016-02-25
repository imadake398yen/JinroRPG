using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeWritter : MonoBehaviour {

	IEnumerator SetText(Text label,string text){
		for(int i=0;i<text.Length;i++){
			label.text = text.Substring(0,i);
			yield return new WaitForSeconds(0.04f);
		}
	}
}
