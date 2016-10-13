using UnityEngine;
using System.Collections;

public class uranusOrbit : MonoBehaviour
{

    public float orbitSpeed = 10;

    public Transform planetNamePos;
    public string planetName;

    Camera cam;
    Vector2 screenPos;
    GUIText planetGUI;


    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        planetNamePos = GameObject.Find("Uranus").transform;
        planetGUI = GetComponent<GUIText>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        screenPos = cam.WorldToScreenPoint(planetNamePos.position);
        //Debug.Log("The position of the Planet is: " + screenPos);
    }

    void OnGUI()
    {
        var centeredStyle = GUI.skin.GetStyle("Label");
        centeredStyle.alignment = TextAnchor.UpperCenter;
        planetGUI.color = Color.cyan;
        GUI.Label(new Rect(screenPos.x, Screen.height - screenPos.y, 60, 50), planetName);
    }
}
