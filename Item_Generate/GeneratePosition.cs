using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Position", menuName = "CreatePosition")]

/* アイテム生成データを作成するクラス */
public class GeneratePosition : ScriptableObject {
	
//　	アイテム名
	[SerializeField]
	private string itemName;
	
//	 x座標
	[SerializeField]
	private int x;
	
//	　y座標
	[SerializeField]
	private int y;
	
//	z座標
	[SerializeField]
	public int z;
	
// 	判定値
	[SerializeField]
	private int flag;
	
/*-------------------関数----------------------------*/

//	アイテム名
	public string GetItemName(){
		return itemName;
	}
	
//	x座標
	public int GetX(){
		return x;
	}
	
//	y座標
	public int GetY(){
		return y;
	}
	
//	z座標
	public int GetZ(){
		return z;
	}
	
//	判定値
	public int GetFlag(){
		return flag;
	}
	
	public void SetFlag(){
		flag = 1;
	}
	
}
