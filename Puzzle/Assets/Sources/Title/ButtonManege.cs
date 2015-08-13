using UnityEngine;
using System.Collections;

public class ButtonManege : MonoBehaviour
{
	/* SendMessagePlay()
	 * PLAYボタンが押された時に実行するメソッド
	 * Game画面へ遷移する．
	 */
	public void SendMessagePlay ()
	{
		Application.LoadLevel ("Game");
	}
	/* SendMessageTitle()
	 * TITLEボタンが押された時に実行するメソッド
	 * Title画面へ遷移する．
	 */
	public void SendMessageTitle ()
	{
		Application.LoadLevel ("Title");
	}
	/* SendMessageRankking()
	 * RANKKINGボタンが押された時に実行するメソッド
	 * Rankking画面へ遷移する．
	 */
	public void SendMessageRankking ()
	{
		Application.LoadLevel ("Ranking");
	}
}
