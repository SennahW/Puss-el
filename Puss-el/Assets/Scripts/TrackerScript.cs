using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerScript : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject P1Cam;
    public GameObject P2Cam;
    public GameObject BothCam;
    public Vector2 midPos;
    // Start is called before the first frame update
    void Awake()
    {
        BothCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        midPos.x = (playerOne.transform.position.x + playerTwo.transform.position.x) / 2;
        midPos.y = (playerOne.transform.position.y + playerTwo.transform.position.y) / 2;
        transform.position = midPos;

        if (Vector2.Distance(playerOne.transform.position, playerTwo.transform.position) < 5)
        {
            BothCam.SetActive(true);
            P1Cam.SetActive(false);
            P2Cam.SetActive(false);
        }
        if (Vector2.Distance(playerOne.transform.position, playerTwo.transform.position) > 5)
        {
            BothCam.SetActive(false);
            P1Cam.SetActive(true);
            P2Cam.SetActive(true);
        }
    }
}
