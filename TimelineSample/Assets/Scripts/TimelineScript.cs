using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineScript : MonoBehaviour
{
    PlayableDirector timeline;
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
        timeline.Play();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            timeline.Stop();
        }
    }
}
