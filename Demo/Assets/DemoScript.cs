using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {

	public void OnBtnClicked () {
		Adsetus.ShowAd ();
	}

	void Start () {
		if (Adsetus.IsAdLoaded()) {
			Adsetus.Init ("YOUR_APP_ID");
		}
	}
}
