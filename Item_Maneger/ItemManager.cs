using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

/* アイテムを管理するクラス */
public class ItemManager : MonoBehaviour {
	
//	アイテムデータベース
	[SerializeField]
	public ItemDataBase itemDataBase;
	
//	アイテムスロット
	public GameObject Slot1;
	public GameObject Slot2;
	public GameObject Slot3;
	public GameObject Slot4;
	
//	各アイテムの所持数
	private List<string> i_name;
	private List<int>    i_num;
	
//	その他、関数内で使用する変数
	private int l_size;
	private int item_kind;
	private int full_slot;
	private int slot_num = 4;


	void Start()
	{
		
	}


//	アイテムを拾ったときの処理
	public int ItemPick(string pick_name)
	{
		i_name    = new List<string>();
		i_num     = new List<int>();
		l_size    = itemDataBase.GetItemLists().Count;
		item_kind = 0;
		full_slot = 0;
		
		for(int i = 0; i < l_size; i++)
		{
			i_name.Add(itemDataBase.GetItemLists()[i].GetItemName());
			i_num.Add(itemDataBase.GetItemLists()[i].GetItemNum());
			
//			所持しているアイテムの種類に1加算する
			if(0 < i_num[i])
				item_kind ++;
		}
		
//		スロットが全て埋まっていて、同じアイテムを所持していない場合は何もしない
		if( (item_kind == slot_num) && (ItemSearch(pick_name, i_name, i_num, l_size) == 0) )
			return 0;
		
//		拾ったアイテムのアイテム数に1加算する		
		ItemPlus(pick_name, i_num);	
		i_num[GetItemID(pick_name)] += 1;
		
//		拾ったアイテムをアイテムポーチに反映する処理
		for(int i = 0; i < l_size; i++)
		{
			if(slot_num == full_slot)
				break;
			
//			アイテムを所持している場合はアイテムを格納する
			if(0 < i_num[i])
				PushSlot(full_slot++, i_name[i]);
		}
		
//		アイテムが格納されてないスロットを空スロットにする処理
		while(full_slot < slot_num)
			NullSlot(full_slot++);
		
		return 1;
	}
	
	
//	同じアイテムを所持しているか判断する処理
	public int ItemSearch(string pick_name, List<string> i_name, List<int> i_num, int l_size)
	{
		for(int i = 0; i < l_size; i++)
		{
			if(pick_name == i_name[i])
			{
//				同じアイテムを所持していない場合
				if(i_num[i] == 0)
					return 0;
				
//				同じアイテムを既に所持している場合
				else
					return 1;
			}
		}
		return 0;
	}
	
	
//	アイテムを格納するスロットを選択
	public void PushSlot(int full_slot, string i_name)
	{
		switch(full_slot)
		{
			case 0:
				Slot1.GetComponent<SlotProcess>().SetItem(i_name);
				break;
				
			case 1:
				Slot2.GetComponent<SlotProcess2>().SetItem(i_name);
				break;
			
			case 2:
				Slot3.GetComponent<SlotProcess3>().SetItem(i_name);
				break;
				
			case 3:
				Slot4.GetComponent<SlotProcess4>().SetItem(i_name);
				break;
			
			default:
				Slot1.GetComponent<SlotProcess>().SetItem(i_name);
				break;
		}
	}
	
	
//	アイテムを格納しないスロットは空スロットにする
	public void NullSlot(int balance_slot)
	{
		switch(balance_slot)
		{
			case 0:
				Slot1.GetComponent<SlotProcess>().RemoveSlot();
				break;
				
			case 1:
				Slot2.GetComponent<SlotProcess2>().RemoveSlot();
				break;
				
			case 2:
				Slot3.GetComponent<SlotProcess3>().RemoveSlot();
				break;
				
			case 3:
				Slot4.GetComponent<SlotProcess4>().RemoveSlot();
				break;
			
			default:
				Slot1.GetComponent<SlotProcess>().RemoveSlot();
				break;
		}
	}


//	拾ったアイテムのアイテム数を加算する処理
	public void ItemPlus(string i_name, List<int> i_num)
	{
		int index = GetItemID(i_name);
		itemDataBase.GetItemLists()[index].SetItemNum(i_num[index]+1);
	}
	
	
//	アイテム名からアイテムIDを検索
	public int GetItemID(string i_name)
	{
		switch(i_name)
		{
			case "Apple":
				return 0;
				
			case "Coconut":
				return 1;
			
			case "Cherry":
				return 2;
				
			case "Kiwi":
				return 3;
				
			case "Lemon":
				return 4;
				
			case "Pear":
				return 5;
				
			case "Strawberry":
				return 6;
			
			default:
				return 0;
		}
	}

}
