using UnityEngine;

public class playertrigger : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    //Debug.Log("c");
    //    if (other.gameObject.tag == "changeable")
    //    {
    //        Debug.Log("c");
    //        change2Objects.instance.change();
    //    }
    //}
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "changeable")
        {
            change2Objects script = other.GetComponentInParent<change2Objects>();
            Debug.Log("c");
            script.change();
        }
    }
}
