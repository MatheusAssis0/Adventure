using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundsEffectPref = "SoundsEffectPref";
    [SerializeField] private AudioSource[] soundEffect;
    [SerializeField] private AudioSource musica;
    private float backgroundFloat, soundEffectsFloat;

    private void Awake()
    {
        ContinuousSettings();
    }

    private void ContinuousSettings()
    {
        backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundsEffectPref);

        musica.volume = backgroundFloat;

        for (int i = 0; i < soundEffect.Length; i++)
        {
            soundEffect[i].volume = soundEffectsFloat;
        }
    }
}
