using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class RankingDisp : MonoBehaviour
{
	public int[] p;
	public GameObject w ;

	// Use this for initialization
	void Start ()
	{

		ReadRank fi = GetComponent<ReadRank> ();
		fi.ReadFile ();
		fi.ToInt ();
		p = fi.getInt();
		setScoreText ();

	}




	public void setScoreText ()
	{	

		this.GetComponent<Text> ().text = 
			"1st\t\t " + p [0] + "\n"
			+ "2nd\t\t " + p [1] + "\n"
			+ "3rd\t\t " + p [2] + "\n"
			+ "4th\t\t " + p [3] + "\n"
			+ "5th\t\t " + p [4] + "\n"
			+ "6th\t\t " + p [5] + "\n"
			+ "7th\t\t " + p [6] + "\n"
			+ "8th\t\t " + p [7] + "\n"
			+ "9th\t\t " + p [8] + "\n"
			+ "10th\t\t " + p [9] + "\n";

	}
}
