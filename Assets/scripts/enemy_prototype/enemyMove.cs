using System.Collections;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;


public class enemyMove : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public float speed;
    public bool attack;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attack = true;
        transform.LookAt(A);
    }

    void OnTriggerEnter(Collider other)
    {
        // if (attack)
        // {
            if (other.gameObject.tag == "A")
            {
                Debug.Log("hitA");
                transform.LookAt(B);
                // attack = false;
                StartCoroutine(wait());
            }
            if (other.gameObject.tag == "B")
            {
                Debug.Log("hitB");
                transform.LookAt(A);
                // attack = false;
                StartCoroutine(wait());
            }
            if (other.gameObject.tag == "Player")
            {
                Debug.Log("hitPlayer");
                // Destroy(player);

            }
        // }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hitplayer");
            collision.gameObject.GetComponentInChildren<Text>().enabled = true;
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (attack)
        {
            transform.Translate(Vector3.forward * speed);
        }
    }
    IEnumerator wait()
    {
        attack = false;
        yield return new WaitForSeconds(1);
        attack = true;


    }
}
