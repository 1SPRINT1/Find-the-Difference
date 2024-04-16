using AppodealAds.Unity.Api;
using UnityEngine;

public class LoadScreenAdd : MonoBehaviour
{
    public void LoadAdds()
    {
        if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
        {
            Appodeal.show(Appodeal.INTERSTITIAL);
        }
        else
        {
            Debug.Log("Межстраничная реклама ещё не загружена.");
        }
    }
}
