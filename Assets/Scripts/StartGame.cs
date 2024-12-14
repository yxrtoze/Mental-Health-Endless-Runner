using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Index of the game scene (set to 1 as per your logic)
    public int gameSceneIndex = 1;
    public int negativeSceneIndex = 2;  // Scene index for the negative scene
    public int startPageSceneIndex = 0; // Scene index for the start page scene

    // This method will be called when the Play button is clicked (from Start Scene)
    public void OnPlayButtonClicked()
    {
        if (gameSceneIndex >= 0 && gameSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            Debug.Log("Loading scene with index: " + gameSceneIndex);
            SceneManager.LoadScene(gameSceneIndex);
        }
        else
        {
            Debug.LogError("Invalid scene index! Check the Build Settings.");
        }
    }

    // This method will be called when the Exit button is clicked (from Start Scene)
    public void OnExitButtonClicked()
    {
        Debug.Log("Exiting the application...");
        Application.Quit();

        // Note: Application.Quit() only works in a built application, not in the Unity Editor.
        // For testing in the editor, you can use this line (optional):
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    // This method will be called when the Play Again button is clicked (from Negative Scene)
    public void OnPlayAgainButtonClicked()
    {
        if (gameSceneIndex >= 0 && gameSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            Debug.Log("Loading game scene again...");
            SceneManager.LoadScene(gameSceneIndex);  // Reload the game scene
        }
        else
        {
            Debug.LogError("Invalid scene index! Check the Build Settings.");
        }
    }

    // This method will be called when the Main Menu button is clicked (from Negative Scene)
    public void OnMainMenuButtonClicked()
    {
        if (startPageSceneIndex >= 0 && startPageSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            Debug.Log("Loading Start Page scene...");
            SceneManager.LoadScene(startPageSceneIndex);  // Go back to the start page
        }
        else
        {
            Debug.LogError("Invalid scene index! Check the Build Settings.");
        }
    }
}
