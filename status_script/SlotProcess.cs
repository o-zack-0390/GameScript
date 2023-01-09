using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

/* スロットを管理するクラス */
public class SlotProcess : MonoBehaviour {

//		アイテムデータベース
		public GameObject MainCamera;
	
//		テキスト文
		public TextMeshProUGUI TMP;
	
//		アイテムポーチに表示するアイコン
		private Sprite icon;
		public  Image  image;
	
//		アイテムデータ
		private string item_name;
		private int    item_num;
		private string item_inf;


//		アイテムデータをセット
		public void SetItem(string i_name)
		{
			item_name    = i_name;
			item_num     = GetItem(item_name).GetItemNum();
			item_inf     = GetItem(item_name).GetInformation();
			icon         = GetItem(item_name).GetIcon();
			image        = this.GetComponent<Image>();
					image.sprite = icon;
		}
	
	
//		アイテムデータの初期化
		public void RemoveSlot()
		{
			item_name    = null;
			icon         = null;
			image        = this.GetComponent<Image>();
			item_inf     = null;
			image.sprite = null;
			TMP.text     = "Memo\n";
			item_num     = 0;
		}
	
	
//  	マウスがスロットに重なった場合
 		public void MouseOver() 
		{
//			テキストボックス取得
			TMP = TMP.GetComponent<TextMeshProUGUI>();
		
//			テキスト反映
			TMP.text = item_name + ':' + item_num.ToString() + "\n" + item_inf;
		}
	
	
// 		アイテムを使おうとした場合
		public void MouseClick()
		{
//			アイテムが存在するなら使用
			if(0 < item_num)
			{
					/*ここに使用したときの処理を記述*/
				GetItem(item_name).SetItemNum(--item_num);
			
//				アイテムが無くなったらスロットを空にする
				if(item_num < 1)
					RemoveSlot();
			}
		}


//		マウスがスロットから離れた場合
		public void MouseExit() 
		{
//			テキスト反映
			TMP.text = "Memo\n";
    }
	
	
//		アイテムデータベースに同名のアイテムがあるか
		public Item GetItem(string searchName) 
		{
//			アイテムデータベースから、指定されたアイテムデータを取得 ( パス : MainCamera(ゲームオブジェクト) → ItemManager(スクリプト) → ItemDataBase(アイテムデータベース) )
			return MainCamera.GetComponent<ItemManager>().itemDataBase.GetItemLists().Find(itemName => itemName.GetItemName() == searchName);
		}
}
