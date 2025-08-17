using UnityEngine;

public class ChildWorld2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Get the parent's ChildTriggerDetector script
        ParentWorld2 parentDetector = GetComponentInParent<ParentWorld2>();

        if (parentDetector != null)
        {
            // Notify the parent that this child was triggered
            parentDetector.OnChildTriggerEnter(other);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Get the parent's ChildTriggerDetector script
        ParentWorld2 parentDetector = GetComponentInParent<ParentWorld2>();

        if (parentDetector != null)
        {
            // Notify the parent that this child was triggered
            parentDetector.OnChildTriggerExit(other);
        }
    }
}