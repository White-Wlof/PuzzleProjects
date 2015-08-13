using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
public class SortRank : MonoBehaviour {

	public int[] p;
	void Start(){
	}

	public void sort(){
		ReadRank fi = GetComponent<ReadRank>();
		p = fi.getInt ();
		int metor = GameObject.FindGameObjectWithTag("scoreObject").GetComponent<Score>().MainScore;

			for (int i = 0; i < p.Length; i++) { 
				if (metor > p [i]) {
					for (int j = 9; j > i; j--) {
						p [j] = p [j - 1];

					}
					p [i] = metor;
					metor = 0;
				}
			}
	}
}
