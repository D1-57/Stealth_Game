using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBootstrapper : MonoBehaviour
{
    public GameObject globalUIPrefab;
    private static bool uiCreated = false;

    public void StartGame()
    {
        if (!uiCreated)
        {
            GameObject g = Instantiate(globalUIPrefab);
            DontDestroyOnLoad(g);
            uiCreated = true;
        }
        SceneManager.LoadScene("Level1");
    }

    public static void ResetCreatedFlag()
    {
        uiCreated = false;
    }
}
