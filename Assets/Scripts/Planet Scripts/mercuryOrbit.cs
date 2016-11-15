using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mercuryOrbit : MonoBehaviour
{
    public float orbitSpeed = 10;

    public GameObject planet;
    public GameObject planetText;
    public GameObject InfoImage;
    public GameObject Canvas;
    public GameObject messageIn;
    public GameObject messageOut;
    Camera cam;

    private bool interaction;
    public bool isInteracting;
    public bool infoScreen;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;

        interaction = false;

        InfoImage.SetActive(false);
        messageOut.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(interaction);
        Debug.Log(Time.timeScale);

        if (interaction == true)
        {
            Canvas.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                if(infoScreen == false)
                {
                    Time.timeScale = 0;
                    infoScreen = true;
                    messageIn.SetActive(false);
                    messageOut.SetActive(true);
                    InfoImage.SetActive(true);

                }
                else
                {
                    Time.timeScale = 1;
                    infoScreen = false;
                    InfoImage.SetActive(false);
                    messageIn.SetActive(true);
                    messageOut.SetActive(false);
                }
            }  
            isInteracting = true;
        }

        if (interaction == false)
        {
            Canvas.SetActive(false);
            isInteracting = false;
        }

        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        Vector3 vectorToPlanet = (planet.transform.position - cam.transform.position);
        //Debug.Log(Vector3.Angle(cam.transform.forward, vectorToMercury));
        float angle = Vector3.Angle(cam.transform.forward, vectorToPlanet);

        if (angle <= 90)
        {
            planetText.SetActive(true);
            Vector3 newpos = cam.WorldToScreenPoint(planet.transform.position);
            newpos.y = newpos.y + 40;
            planetText.transform.position = newpos;
        }
        else
        {
            planetText.SetActive(false);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = true;   
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = false;
        }
    }
}
