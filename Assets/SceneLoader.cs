using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        ForceSingleton();
    }

    
    private void ForceSingleton()
    {
        int meCount = FindObjectsOfType<SceneLoader>().Length;
        if (meCount > 1)
        {
            GameObject o;
            (o = gameObject).SetActive(false);
            Destroy(o);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadSceneByName(string sceneName)
    {
        if (sceneName == SceneManager.GetActiveScene().name)
        {
            return;
        }
        
        else
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }

}
