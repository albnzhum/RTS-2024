using RTS.Events;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO onGameplaySceneLoad = default;
    [SerializeField] private VoidEventChannelSO onMainMenuSceneLoad = default;

    [SerializeField] private InputReader inputReader;

    private void OnEnable()
    {
        DontDestroyOnLoad(this);

        onGameplaySceneLoad.OnEventRaised += LoadGameplayScene;
        onMainMenuSceneLoad.OnEventRaised += LoadMainMenu;
    }

    private void OnDisable()
    {
        onGameplaySceneLoad.OnEventRaised -= LoadGameplayScene;
        onMainMenuSceneLoad.OnEventRaised -= LoadMainMenu;
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        
        inputReader.EnableUIInput();
    }

    private void LoadGameplayScene()
    {
        SceneManager.LoadScene("Game");
        
        inputReader.EnableGameplayInput();
    }
}