using UnityEngine;
using System.Collections;
using System.IO; //System.IO.FileInfo, System.IO.StreamReader, System.IO.StreamWriter
using System; //Exception
using System.Text; //Encoding

public class ReadRank : MonoBehaviour {
	public string[] score = new string[10];
	public int[] rank = new int[10];
	void Start(){
		ReadFile ();
		ToInt ();
	}
	public void ReadFile(){
		// FileReadTest.txtファイルを読み込む
		FileInfo fi = new FileInfo("Assets/Resources/test.txt");
		try {
			// 一行毎読み込み
			using (StreamReader sr = new StreamReader(fi.OpenRead(), Encoding.UTF8)){
				for(int i=0;i < 10;i++){
					score[i] = sr.ReadLine();

				}
			}
		} catch (Exception e){

			// 改行コード
			e.GetType ();
		}
	}

	public void ToInt(){
		for(int i=0;i<10;i++){
			rank [i] = int.Parse (score[i]);
		}
	}
	public int[] getInt(){

		return rank;
	}
}

