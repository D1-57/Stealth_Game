using UnityEngine;

public class ChildWorld1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Get the parent's ChildTriggerDetector script
        ParentWorld1 parentDetector = GetComponentInParent<ParentWorld1>();

        if (parentDetector != null)
        {
            // Notify the parent that this child was triggered
            parentDetector.OnChildTriggerEnter(other);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Get the parent's ChildTriggerDetector script
        ParentWorld1 parentDetector = GetComponentInParent<ParentWorld1>();

        if (parentDetector != null)
        {
            // Notify the parent that this child was triggered
            parentDetector.OnChildTriggerExit(other);
        }
    }
}