using Unity.Mathematics;
using UnityEngine;

public class enemyvision : MonoBehaviour
{
    public float detectangle = 45;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // if (Physics.Raycast(transform.position, (player.transform.position - transform.position), out hit, Mathf.Infinity))
        // {
        //     if (hit.transform == player.transform)
        //     {
        //         Debug.Log("found");
        //     }
        // }
        Vector3 side1 = player.transform.position - transform.position;
        Vector3 side2 = transform.forward;
        float angle = Vector3.SignedAngle(side1, side2, Vector3.up);
        if (angle < detectangle && angle < -1 * detectangle)
        {
            if (Physics.Raycast(transform.position, (player.transform.position - transform.position), out hit, Mathf.Infinity))
            {
                if (hit.transform == player.transform)
                {
                    levelManager.instance.IsSeen = true;
                    Debug.Log("found");
                }

            }

            // Debug.Log("playerhit");
        }
        else 
                {
                    Debug.Log("notseen");
                    levelManager.instance.IsSeen = false;
                    
                }
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + transform.forward*3);
    }
}
