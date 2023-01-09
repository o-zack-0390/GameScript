using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
[CreateAssetMenu(fileName = "GenerateDataBase", menuName="CreateGenerateDataBase")]

/* アイテム生成データベース */
public class GenerateDataBase : ScriptableObject {
 
	[SerializeField]
	private List<GeneratePosition> posLists = new List<GeneratePosition>();
 
//	座標リストを返す
	public List<GeneratePosition> GetPosLists() {
		return posLists;
	}
}
