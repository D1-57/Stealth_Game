using UnityEngine;

public class worldShift : MonoBehaviour
{
    public GameObject player;
    public bool playersafe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelManager.instance.world1Isclear = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        levelManager.instance.world1Isclear = false;

    }
    private void OnTriggerExit(Collider other)
    {
        levelManager.instance.world1Isclear = true;

    }
}
