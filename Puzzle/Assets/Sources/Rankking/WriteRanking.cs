using UnityEngine;
using System.Collections;
using System.IO;

public class WriteRanking : MonoBehaviour {

	private int[] p;
	void Start(){
		write ();
	}

	public void write(){
		ReadRank fi = GetComponent<ReadRank>();
		SortRank s = GetComponent<SortRank>();
		s.sort ();
		p = fi.getInt ();
		FileStream f = new FileStream ("Assets/Resources/test.txt", FileMode.Create, FileAccess.Write);
		StreamWriter writer = new StreamWriter (f);
		for (int k = 0; k < 10; k++) {
			writer.Write (p [k] + "\n");
		}
		writer.Close ();
	}
}
