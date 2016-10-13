using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InteractionScript : MonoBehaviour
{

    GameObject InteractionUI;
    private bool interaction;
    private Text txtRef;
    

	// Use this for initialization
	void Start ()
	{
	    interaction = false;
        InteractionUI = GameObject.Find("InteractionUI");
	    txtRef = GameObject.Find("UI_Popup").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (interaction == true)
        {
            InteractionUI.SetActive(true);
            if(Input.GetKeyDown("r"))
            {
                Debug.Log(this.gameObject.name);
            }
        }

        if (interaction == false)
        {
            InteractionUI.SetActive(false);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sun")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT THE SUN";
        }

        if (other.gameObject.name == "Mercury")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT MERCURY";
        }

        if (other.gameObject.name == "Venus")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT VENUS";
        }

        if (other.gameObject.name == "Earth")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT EARTH";
        }

        if (other.gameObject.name == "Mars")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT MARS";

        }

        if (other.gameObject.name == "Jupiter")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT JUPITER";
        }

        if (other.gameObject.name == "Saturn")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT SATURN";
        }

        if (other.gameObject.name == "Uranus")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT URANUS";
        }

        if (other.gameObject.name == "Neptune")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT NEPTUNE";
        }

        if (other.gameObject.name == "Pluto")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT PLUTO";
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Sun" || other.gameObject.name == "Mercury" || other.gameObject.name == "Venus" || other.gameObject.name == "Earth" || other.gameObject.name == "Mars" || other.gameObject.name == "Jupiter" || other.gameObject.name == "Saturn" || other.gameObject.name == "Uranus" || other.gameObject.name == "Neptune" || other.gameObject.name == "Pluto")
        {
            interaction = false;
        }
    }
}
