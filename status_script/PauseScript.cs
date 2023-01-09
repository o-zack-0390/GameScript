using UnityEngine;
using System.Collections;

/* アイテムポーチを開いたときに一時停止させるクラス */
public class PauseScript : MonoBehaviour {
 
//	ポーズした時に表示するUI
		[SerializeField]
		private GameObject ItemScreen;
	
		void Update () 
		{
			if(Input.GetKeyDown ("q")) 
			{
	//		ポーズUIのアクティブ、非アクティブを切り替え
				ItemScreen.SetActive (!ItemScreen.activeSelf);
 
	//		ポーズUIが表示されてる時は停止
				if(ItemScreen.activeSelf) 
				{
					Time.timeScale = 0f;
				}
			
//			ポーズUIが表示されてなければ通常通り進行
				else 
				{
					Time.timeScale = 1f;
				}
			}
		}
}
