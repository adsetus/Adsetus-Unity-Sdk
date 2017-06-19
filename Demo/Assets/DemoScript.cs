using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {

	public void OnBtnClicked () {
		Adsetus.ShowAd ();
	}

	void Start () {
		Adsetus.Init ("YOUR_APP_ID");
	}
}
