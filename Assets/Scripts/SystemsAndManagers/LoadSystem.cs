using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class LoadSystem : MonoBehaviour
{
    public AssetReference sceneToLoad; 

    void Start()
    {
        LoadScene();
    }

    public void LoadScene()
    {
        if (sceneToLoad.RuntimeKeyIsValid())
        {
            sceneToLoad.LoadSceneAsync(LoadSceneMode.Additive).Completed += OnSceneLoaded;
        }
        else
        {
            Debug.LogError("Runtime Key is not valid. Please check the addressable settings.");
        }
    }

    private void OnSceneLoaded(AsyncOperationHandle<SceneInstance> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log("Scene loaded successfully.");
        }
        else
        {
            Debug.LogError("Scene failed to load: " + obj.OperationException.ToString());
        }
    }
}
