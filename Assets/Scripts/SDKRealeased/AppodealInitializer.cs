using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;
using UnityEngine;

public class AppodealInitializer : MonoBehaviour
{
    private const string APP_KEY = "b89c640e5f920f47bac2ca2ab8bcdac33cfcfbfffb64b43e";

    void Start()
    {
        Appodeal.initialize(APP_KEY, Appodeal.INTERSTITIAL);
    }
}
