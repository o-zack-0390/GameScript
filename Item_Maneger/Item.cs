using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "CreateItem")]

/* アイテムデータを作成するクラス */
public class Item : ScriptableObject {
	
	public enum KindOfItem {
		Weapon,
		UseItem
	}
 
//	アイテムの種類
	[SerializeField]
	private KindOfItem kindOfItem;
	
//	アイテムのアイコン
	[SerializeField]
	private Sprite icon;
	
//	アイテムの名前
	[SerializeField]
	private string itemName;
	
//	スタミナ回復量
	[SerializeField]
	private int staminaEffect;
	
//	水の回復量
	[SerializeField]
	private int waterEffect;
	
//	アイテムの説明
	[SerializeField]
	private string information;
	
//	アイテムの所持数
	[SerializeField]
	public int itemNum;
	
	
/*-------------------関数----------------------------*/
	
//	武器 or アイテム
	public KindOfItem GetKindOfItem(){
		return kindOfItem;
	}
	
//	アイテムのアイコン
	public Sprite GetIcon(){
		return icon;
	}
	
//	アイテム名
	public string GetItemName(){
		return itemName;
	}
	
//	回復量(食)
	public int GetStaminaEffect(){
		return staminaEffect;
	}
	
//	回復量(水)
	public int GetWaterEffect(){
		return waterEffect;
	}
	
//	アイテムの説明文
	public string GetInformation(){
		return information;
	}
	
//	アイテムの所持数
	public int GetItemNum(){
		return itemNum;
	}
	
//	所持しているアイテム数の変更
	public void SetItemNum(int num){
		itemNum = num;
	}
}
