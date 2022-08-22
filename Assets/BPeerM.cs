using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPeerM : MonoBehaviour
{
    public static BPeerM _BPeerM;
    public float[] _bpm;
    private float _beatInterval, _beatTimer;
    public static bool _beatFull;
    public static int _beatCountFull;
    public int currentTrack;

    public static BPeerM _BPeerMInstance;

    private void Awake()
    {
        currentTrack = 0;
        if (_BPeerMInstance != null && _BPeerMInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _BPeerMInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Update()
    {
        BeatDetection();
    }

    private void BeatDetection()
    {
        _beatFull = false;
        _beatInterval = 60f / _bpm[currentTrack];
        _beatTimer += Time.deltaTime;
        if (_beatTimer >= _beatInterval)
        {
            _beatTimer -= _beatInterval;
            _beatFull = true;
            _beatCountFull++;
            Debug.Log("full");
        }
    }
}
