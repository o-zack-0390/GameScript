using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemDataBase", menuName="CreateItemDataBase")]

/* アイテムデータベース */
public class ItemDataBase : ScriptableObject {
 
	[SerializeField]
	private List<Item> itemLists = new List<Item>();
 
//	アイテムリストを返す
	public List<Item> GetItemLists() 
	{
		return itemLists;
	}
}

/*
不都合な件があったため以下を変更
変更前:以下のサイトを流用
変更後:関数の型を調整

参考サイト
https://gametukurikata.com/program/scriptableobjectitemdatabase
*/
