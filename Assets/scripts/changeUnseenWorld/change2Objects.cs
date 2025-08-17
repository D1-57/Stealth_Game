using UnityEngine;

public class change2Objects : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void change()
    {
        if (object1.activeSelf && !object2.activeSelf)
        {
            object2.SetActive(true);
            object1.SetActive(false);
        }
        else if (!object1.activeSelf && object2.activeSelf)
        {
            object2.SetActive(false);
            object1.SetActive(true);
        }
    }
}
