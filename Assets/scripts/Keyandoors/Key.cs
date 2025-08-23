using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject doors;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            doors.SetActive(true);
            Debug.Log("p");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doors.SetActive(true);
            Debug.Log("p");
        }
    }
}
