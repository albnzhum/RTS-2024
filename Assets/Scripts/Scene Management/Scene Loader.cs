using System;
using RTS.Events;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO onGameplaySceneLoad = default;

    private void OnEnable()
    {
        DontDestroyOnLoad(this);

        onGameplaySceneLoad.OnEventRaised += LoadGameplayScene;
    }

    private void OnDisable()
    {
        onGameplaySceneLoad.OnEventRaised -= LoadGameplayScene;
    }

    private void LoadGameplayScene()
    {
        SceneManager.LoadScene("Game");
    }
}