using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeat : MonoBehaviour
{
    public SoundManager _soundManager;
    public AudioClip[] _introTrack;
    public AudioClip[] _MainTrack;
    public AudioClip[] _MainOfEverything;
    int _section;
    // Start is called before the first frame update
    void Start()
    {
        _section = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (BPeerM._beatFull)
        {
            if (_section == 0)
            {
                _soundManager.PlaySound(_introTrack[_section], 1);
                _section++;
                if (BPeerM._beatCountFull == 34)
                {
                    _soundManager.PlaySound(_introTrack[_section], 1);
                    _section++;
                    if (BPeerM._beatCountFull == 66)

                    {
                        _soundManager.PlaySound(_introTrack[_section], 1);
                        _section -= 3;
                    }
                }
            }
        }
    }
}
