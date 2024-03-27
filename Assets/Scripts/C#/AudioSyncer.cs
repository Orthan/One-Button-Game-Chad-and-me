using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncer : MonoBehaviour
{
    public float bias;
    public float timeStop;
    public float timeToBeat;
    public float restSmoothTime;

    private float m_previousAudioValue;
    private float m_audioValue;
    private float m_timer;
    protected bool m_isBeat;
    
    public virtual void OnBeat()
    {
        Debug.Log("Beat");
        m_timer = 0;
        m_isBeat = true;
    }

    public virtual void OnUpdate()
    {
        m_previousAudioValue = m_audioValue;
        m_audioValue = AudioSpectrum.spectrumValue;

        if(m_previousAudioValue > bias && m_audioValue <= bias)
        {
            if (m_timer > timeStop)
                OnBeat();
        }

        if(m_previousAudioValue <= bias && m_audioValue > bias)
        {
            if (m_timer > timeStop)
                OnBeat();
        }
    }

    private void Update()
    {
        OnUpdate();
    }

}
