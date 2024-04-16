using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine;

public class LoadSystem : MonoBehaviour
{
    public AssetReference levelPrefabReference; 

    private void Start()
    {
        LoadLevel();
    }

    private void LoadLevel()
    {
        levelPrefabReference.InstantiateAsync().Completed += OnLevelLoaded;
    }

    private void OnLevelLoaded(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            GameObject levelInstance = obj.Result;
        }
        else
        {
            Debug.LogError("Не удалось загрузить префаб уровня");
        }
    }
}
