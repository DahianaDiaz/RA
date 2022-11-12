using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCamscript : MonoBehaviour
{
    public GameObject webCameraPlane;
    

    public void fireButton()
    {

        GameObject bullet = Instantiate(Resources.Load("bullet", typeof(GameObject))) as GameObject;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        bullet.transform.rotation = Camera.main.transform.rotation;
        bullet.transform.position = Camera.main.transform.position;
        rb.AddForce(Camera.main.transform.forward * 500f);
        Destroy(bullet, 1);

        GetComponent<AudioSource>().Play();


    }
    // Update is called once per frame
    
}
