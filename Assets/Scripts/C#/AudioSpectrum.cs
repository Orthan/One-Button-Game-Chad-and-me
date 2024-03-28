using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrum : MonoBehaviour
{
   public static float spectrumValue { get; private set;}
    private float[] m_audioSpectrum;
    private int _frameCount = 0;
    
    private void Update()
    {
        // toutes les x frames , on compute spectrum et on recupère une float value au milieu du tableau des frequences
        if (_frameCount %  60 == 0) {
            AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Rectangular);

            if (m_audioSpectrum != null && m_audioSpectrum.Length > 0) {

                // 
                float currentFrequency = m_audioSpectrum[30] * 10000;
                if (currentFrequency > 8.0f) {
                    Debug.Log("Beat !");
                }
            };
        }
        _frameCount++;
    }

    private void Start()
    {
        m_audioSpectrum = new float[256];

    }
}
