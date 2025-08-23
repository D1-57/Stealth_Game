using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;



public class playermove : MonoBehaviour
{
    public CharacterController Controller;
    public GameObject World1;
    public GameObject World2;
    public GameObject worldchange;
    public GameObject Worldshift;
    public float detectangle = 45;
    public float speed;
    float gravity = 14;
    public float jump;
    public float sleep;
    public Animator anim;
    public GameObject healthBar75;
    public GameObject healthBar50;
    public GameObject healthBar25;
    public GameObject healthBar100;

    float verticalvelocity;

    public float rotateSpeed = 100;
    //player health bar

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        jump = 100;

    }
    private void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float speedrun = 1f;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (Mathf.Abs(horizontal) + Mathf.Abs(vertical) > 0)
        {
            anim.SetInteger("speed", 1);

        }
        else
        {
            anim.SetInteger("speed", 0);
        }
        if (jump <= 75)
        {
            Destroy(healthBar100);
        }
        else if (jump <= 50)
        {
            Destroy(healthBar75);
        }
        else if (jump <= 25)
        {
            Destroy(healthBar50);
        }
        else if (jump <= 25)
        {
            Destroy(healthBar25);
        }



        if (Controller.isGrounded)
        {
            verticalvelocity = -gravity * Time.deltaTime;
            // if (Input.GetAxis("Jump") > 0)
            //     verticalvelocity = sleep;
        }
        else
        {
            verticalvelocity -= gravity * Time.deltaTime;
        }


        Vector3 movedirection = new Vector3(horizontal, 0, vertical).normalized;



        if (movedirection.magnitude > 0.1f)
        {
            float angleView = Mathf.Atan2(movedirection.x, movedirection.y) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0, angleView, 0);
            //Quaternion toRotate = Quaternion.LookRotation(movedirection, Vector3.up);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, rotateSpeed * Time.deltaTime);
        }
        movedirection = Camera.main.transform.TransformDirection(new Vector3(movedirection.x, 0, movedirection.z));

        //Vector3 movedirection = new Vector3(horizontal*speed*speedrun, verticalvelocity, vertical*speed*speedrun);
        Controller.Move(new Vector3(movedirection.x * speed * speedrun, verticalvelocity,
            movedirection.z * speed * speedrun) * Time.deltaTime);



        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedrun = 2f;
        }
        else
        {
            speedrun = 1f;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (levelManager.instance.world1Isclear && !World1.activeSelf)
            {
                StartCoroutine(ShiftDelay1());
                // World1.SetActive(true);
                // World2.SetActive(false);
            }
            else if (levelManager.instance.world2Isclear && !World2.activeSelf)
            {
                StartCoroutine(ShiftDelay2());
                // World1.SetActive(false);
                // World2.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (levelManager.instance.world2Isclear && !World2.activeSelf)
            {
                World2.SetActive(true);
            }
            else
            {
                World2.SetActive(false);
            }

        }
        

    }



    IEnumerator ShowCollider()
    {
        GetComponent<BoxCollider>().enabled = true;
        yield return new WaitForSeconds(0.25f);
        GetComponent<BoxCollider>().enabled = false;

    }
    IEnumerator ShiftDelay1()
    {
        yield return new WaitForSeconds(0.5f);
        World1.SetActive(true);
        World2.SetActive(false);
    }
    IEnumerator ShiftDelay2()
    {
        yield return new WaitForSeconds(0.5f);
        World1.SetActive(false);
        World2.SetActive(true);
    }
    void playerCaught()
    {
        sleep--;
    }
    

}
