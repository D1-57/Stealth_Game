using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public int doorIndex;
    public DoorSystem doorSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (doorSystem != null)
            doorSystem.OnDoorEntered(doorIndex);

        var col = GetComponent<Collider>();
        if (col != null) col.enabled = false;
    }
}
