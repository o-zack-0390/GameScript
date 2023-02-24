using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

/* 周囲にアイテムがあるか判定するクラス */
public class SearchItem : MonoBehaviour {
	
//　 UnityChan!のスクリプト「IsDestroy.cs」を参照
	public GameObject UnityChan;
	
	
//	アイテムを拾える位置まで近づいたときに起動
	void OnTriggerEnter(Collider col)
	{
//		離れたオブジェクトのタグが"Item"のとき
		if(col.tag == "Item")
		{
			UnityChan.GetComponent<IsDestroy>().SetItem(col.gameObject.transform.parent.gameObject);
			UnityChan.GetComponent<IsDestroy>().ChangeFlag(1);
		}
	}
	
//	アイテムを拾えない位置まで離れたときに起動
	void OnTriggerExit(Collider col)
    {
//		離れたオブジェクトのタグが"Item"のとき
        if(col.tag == "Item")
            UnityChan.GetComponent<IsDestroy>().ChangeFlag(0);
    }
 
}
