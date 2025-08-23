using UnityEngine;

public class MainMenuCleanup : MonoBehaviour
{
    void Awake()
    {
        GameObject g = GameObject.Find("GlobalUI");
        if (g != null)
        {
            Destroy(g);
            UIBootstrapper.ResetCreatedFlag();
        }
    }
}

