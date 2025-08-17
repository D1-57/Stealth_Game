using UnityEngine;

public class levelManager : MonoBehaviour
{
    public static levelManager instance;
    public bool world2Isclear;
    public bool world1Isclear;
    public bool worldchange;
    public bool IsSeen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instance = this;
        world2Isclear = true;
        world1Isclear = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
