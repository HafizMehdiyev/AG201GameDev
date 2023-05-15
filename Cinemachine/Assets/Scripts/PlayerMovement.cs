using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck;
using Dreamteck.Splines;

public class PlayerMovement : MonoBehaviour
{
    public SplineFollower follower;

    private void Start()
    {
        follower = GetComponent<SplineFollower>();
    }

    private void Update()
    {
        if (transform.position.z > 45f)
        {
            follower.followSpeed = 0;
            follower.follow = false;
        }
    }

}
