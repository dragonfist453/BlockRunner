using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset.x = 0;
        offset.y = 1;
        offset.z = -6;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
