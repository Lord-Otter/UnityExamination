using UnityEngine;
using UnityEngine.Audio;

public class VolumeController : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    // Called by slider (value 0–1)
    public void SetMasterVolume(float sliderValue)
    {
        // Clamp to avoid invalid values
        sliderValue = Mathf.Clamp(sliderValue, 0.0001f, 1f);

        // Map to dB: 0.0001 → -80 dB, 1 → 0 dB
        float dB = Mathf.Log10(sliderValue) * 20f;

        // Apply to exposed parameter
        audioMixer.SetFloat("MasterVolume", dB);
    }
}