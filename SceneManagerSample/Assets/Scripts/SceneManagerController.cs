using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class SceneManagerController : MonoBehaviour
{
    public static SceneManagerController instance;
    private int _sceneIndex = 0;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void OnEnable()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.activeSceneChanged += SceneChanged;
    }
    public void NextLevel(GameObject player)
    {
        _sceneIndex++;
        SceneManager.LoadSceneAsync(_sceneIndex, LoadSceneMode.Additive);
        Scene loadedScene2 = SceneManager.GetSceneByBuildIndex(_sceneIndex);
        SceneManager.MoveGameObjectToScene(player, loadedScene2);
        Invoke("HideLevel", 1f);
        SceneManager.GetActiveScene();
    }

    public void HideLevel()
    {
        SceneManager.UnloadSceneAsync(_sceneIndex - 1);
    }

    public void SceneChanged(Scene currentScene, Scene newScene)
    {
        currentScene = SceneManager.GetActiveScene();
        newScene = SceneManager.GetSceneByBuildIndex(_sceneIndex);
        Debug.Log(SceneManager.GetActiveScene().name);
            
    }
}
