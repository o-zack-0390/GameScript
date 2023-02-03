using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

/* アイテムを破壊するクラス */
public class IsDestroy : MonoBehaviour {
	
//　 メインカメラのスクリプト「ItemManager.cs」を参照
	public GameObject MainCamera;
	
//　 アイテムプレハブ
	public GameObject Prefab;

//	アイテムを拾う判定
	public int flag = 0;
	
//	破壊対象のアイテム名
	private string i_name;
	
	
	void Update()
	{
		ItemDestroy();
	}
	
	
//	アイテムを拾ったか判定
	public void ItemDestroy()
	{
//		「a」が押された場合
		if(Input.GetKeyDown ("a"))
		{
//			OnTriggerEnter が起動している場合
			if(flag == 1)
			{
				MainCamera.GetComponent<ItemManager>().ItemPick(i_name);
				Destroy(Prefab);
				flag = 0;
			}
		}
	}
	
	
//	破壊対象のアイテムを設定
	public void SetItem(Collider col)
	{
		Prefab = col;
		i_name = col.name;
		i_name = i_name.Substring(0, i_name.IndexOf('('));
	}
	
	
//	アクション「アイテムを拾う」が有効か判定
	public void ChangeFlag(int _flag)
	{
//		OnTriggerEnter なら 1, OnTriggerExit なら 0 を設定
		flag = _flag;
	}
	
}
