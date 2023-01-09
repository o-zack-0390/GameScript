using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

/* フィールドにアイテムを生成するクラス */
public class ItemGenerater : MonoBehaviour {
	
//	生成座標
	public GenerateDataBase GenerateDataBase;
	
//	インスタンス化
	private GameObject Instance;
	
//	アイテム名
	private string item_name;
	
//	生成間隔
    private float interval;
	
//	経過時間
    private float time = 0f;
	
//	生成リスト
	private List<GeneratePosition> posLists = new List<GeneratePosition>();
	private int l_size;
	
//	生成座標
	private int x;
	private int y;
	private int z;

//	アイテムプレハブ
    public GameObject Prefab1;
	public GameObject Prefab2;
	public GameObject Prefab3;
	public GameObject Prefab4;
	public GameObject Prefab5;
	public GameObject Prefab6;
	public GameObject Prefab7;


    void Start()
    {
        interval = 0f;
		posLists = GenerateDataBase.GetPosLists();
		l_size   = posLists.Count;
		Debug.Log(posLists[0].GetItemName());
    }
 

    void Update()
    {
//		時間計測
        time += Time.deltaTime;
 
//		経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if(time > interval)
        {
			for(int i=0; i<l_size; i++)
			{
//				アイテム生成
				GenerateItem(posLists[i], posLists[i].GetFlag(), i);
			}
			
//			経過時間を初期化
            time     = 0f;
			interval = 3600f;
        }
    }
	
	
	public void GenerateItem(GeneratePosition posData, int flag, int index)
	{
//		アイテムが残ってる場合は何もしない
		if(flag == 1)
			return;
		
//		アイテム名を取得
		item_name = posData.GetItemName();

//		生成座標を取得
		x = posData.GetX();
		y = posData.GetY();
		z = posData.GetZ();
		
//		インスタンス化する
		switch(item_name)
		{
			case "Apple":
				Instance = Instantiate(Prefab1);
				break;
			
			case "Cherry":
				return;
				
			case "Coconut":
				Instance = Instantiate(Prefab5);
				break;
				
			case "Kiwi":
				return;
				
			case "Lemon":
				return;
				
			case "Pear":
				return;
				
			case "Strawberry":
				return;
			
			default:
				return;
		}
		
//		指定した座標にアイテムを生成
		Instance.transform.position = new Vector3(x,y,z);
		
//		アイテムを生成したので flag を 1 にする
		GenerateDataBase.GetPosLists()[index].SetFlag();
	}
}
