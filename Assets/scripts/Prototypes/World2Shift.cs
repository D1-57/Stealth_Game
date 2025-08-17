using UnityEngine;

public class World2Shift : MonoBehaviour
{
    public GameObject player;
    public bool playersafe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        levelManager.instance.world2Isclear = false;

    }
    private void OnTriggerExit(Collider other)
    {
        levelManager.instance.world2Isclear = true;

    }
}
