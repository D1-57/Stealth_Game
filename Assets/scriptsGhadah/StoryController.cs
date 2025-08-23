using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StoryController : MonoBehaviour
{
    public GameObject storyPanel;
    public VideoPlayer videoPlayer;

    public void OpenStory()
    {
        storyPanel.SetActive(true);
        videoPlayer.Play();
    }

    public void CloseStory()
    {
        videoPlayer.Stop();
        storyPanel.SetActive(false);
    }
}
