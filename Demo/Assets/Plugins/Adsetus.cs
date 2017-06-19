using UnityEngine;
using System.Collections;

public static class Adsetus {

#if UNITY_EDITOR
#elif UNITY_ANDROID
	private static AndroidJavaClass adsetus = new AndroidJavaClass("us.adset.sdk.Adsetus");
#endif

	public static void Init(string appId) {
#if UNITY_EDITOR
		return;
#elif UNITY_ANDROID
		using (AndroidJavaObject javaString = CreateJavaString(appId)) {
			adsetus.CallStatic ("init", GetCurrentActivity(), javaString);
		}
#endif
	}

	public static void ShowAd() {
#if UNITY_EDITOR
		return;
#elif UNITY_ANDROID
		adsetus.CallStatic ("showAd", GetCurrentActivity());
#endif
	}

	public static bool IsAdLoaded() {
#if UNITY_EDITOR
		return false;
#elif UNITY_ANDROID
		return adsetus.CallStatic<bool> ("isAdLoaded");
#else
		return false;
#endif
	}

#if UNITY_EDITOR
#elif UNITY_ANDROID
	private static AndroidJavaObject CreateJavaString(string str) {
		return new AndroidJavaObject("java.lang.String", str); 
	}

	private static AndroidJavaObject GetCurrentActivity() {
		using (AndroidJavaClass unityPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer")) { 
			return unityPlayer.GetStatic<AndroidJavaObject> ("currentActivity");
		}
	}
#endif
}