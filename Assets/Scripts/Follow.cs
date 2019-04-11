using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{
    public GameObject objectToFollow;

    void Update()
    {
        Vector3 position = this.transform.position;

        position.y = objectToFollow.transform.position.y;
        position.x = objectToFollow.transform.position.x;

        this.transform.position = position;
    }
}