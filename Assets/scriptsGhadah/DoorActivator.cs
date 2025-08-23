using UnityEngine;

public class DoorActivator : MonoBehaviour
{
    public GameObject[] doors;
    public DoorSystem doorSystem; // Reference to parent DoorSystem prefab

    private bool activated = false;

    private void Awake()
    {
        foreach (var d in doors)
            if (d != null) d.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (activated) return;
        if (!other.CompareTag("Player")) return;

        activated = true;

        foreach (var d in doors)
            if (d != null) d.SetActive(true);

        if (doorSystem != null)
            doorSystem.OnDoorsActivated();

            //gameObject.SetActive(false);
    }
}
