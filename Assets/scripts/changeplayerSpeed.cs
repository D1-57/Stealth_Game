using UnityEngine;

public class changeplayerSpeed : MonoBehaviour
{
    public GameObject text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<playermove>().speed = 5;
            Destroy(text);
        }
    }
}
