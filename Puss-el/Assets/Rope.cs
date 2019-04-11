using UnityEngine;

public class Rope : MonoBehaviour
{
    public HingeJoint2D hook;

    public GameObject CableLinkPrefab;

    public float links;

    void Start()
    {
        GenerateRope();
    }

    void GenerateRope()
    {
        for (int i = 0; i < links; i++)
        {

        }
    }
}
