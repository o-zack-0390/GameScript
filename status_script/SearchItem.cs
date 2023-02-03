using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

/* 周囲にアイテムがあるか判定するクラス */
public class SearchItem : MonoBehaviour {
	
//	メインカメラのスクリプト「IsDestroy.cs」を参照
	public GameObject MainCamera;
	
	
//	アイテムを拾える位置まで近づいたときに起動
	void OnTriggerEnter(Collider col)
	{
//		離れたオブジェクトのタグが"Item"のとき
		if(col.tag == "Item")
		{
			MainCamera.GetComponent<IsDestroy>().SetItem(col);
			MainCamera.GetComponent<IsDestroy>().ChangeFlag(1);
		}
	}
	
	
//	アイテムを拾えない位置まで離れたときに起動
	void OnTriggerExit(Collider col)
	{
//		離れたオブジェクトのタグが"Item"のとき
        if(col.tag == "Item")
            MainCamera.GetComponent<IsDestroy>().ChangeFlag(0);
	}
 
}
