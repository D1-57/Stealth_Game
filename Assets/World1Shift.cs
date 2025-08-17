using UnityEngine;

public class World1Shift : MonoBehaviour
{
    public GameObject player;
    public bool playersafe;
    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{


    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("enter");

    //        foreach (Transform child in transform)
    //        {
    //            Collider childCollider = child.GetComponent<Collider>();
    //            if (childCollider != null && other == childCollider)
    //            {
    //                levelManager.instance.world1Isclear = false;
    //            }
    //        }

    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("exit");

    //    foreach (Transform child in transform)
    //    {
    //        Collider childCollider = child.GetComponent<Collider>();
    //        if (childCollider != null && other == childCollider)
    //        {
    //            levelManager.instance.world1Isclear = true;
    //        }
    //    }
    //}
    private Collider[] childColliders; // Stores all child colliders

    private void Start()
    {
        // Cache all colliders in children (including inactive ones)
        childColliders = GetComponentsInChildren<Collider>(true);
    }

    // Called when ANY collider enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the triggering collider belongs to a child
        foreach (Collider childCollider in childColliders)
        {
            if (childCollider == other)
            {
                Debug.Log($"Player triggered child: {other.name}");

                // Optional: Check if it's the player
                if (other.CompareTag("Player"))
                {
                    Debug.Log("Player entered a child collider!");
                    // Your logic here (e.g., damage, sound, etc.)
                }
                break;
            }
        }
    }
}
