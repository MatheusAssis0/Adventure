using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundsEffectPref = "SoundsEffectPref";
    private int firstPlayInt;
    [SerializeField] private Slider backgroundSlider, soundEffectsSlider;
    [SerializeField] private AudioSource[] soundEffect;
    [SerializeField] private GameObject musica;
    private float backgroundFloat, soundEffectsFloat;
    void Start()
    {
        musica = GameObject.FindGameObjectWithTag("Musica1");
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if(firstPlayInt == 0)
        {
            backgroundFloat = 0.25f;
            soundEffectsFloat = 0.25f;
            backgroundSlider.value = backgroundFloat;
            soundEffectsSlider.value = soundEffectsFloat;
            PlayerPrefs.SetFloat(BackgroundPref, backgroundFloat);
            PlayerPrefs.SetFloat(SoundsEffectPref, soundEffectsFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
            backgroundSlider.value = backgroundFloat;
            soundEffectsFloat = PlayerPrefs.GetFloat(SoundsEffectPref);
            soundEffectsSlider.value = soundEffectsFloat;
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackgroundPref, backgroundSlider.value);
        PlayerPrefs.SetFloat(SoundsEffectPref, soundEffectsSlider.value);
    }

    private void OnApplicationFocus(bool focus)
    {
        if(!focus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        AudioSource Musica = musica.GetComponent<AudioSource>();

        Musica.volume = backgroundSlider.value;

        for (int i = 0; i < soundEffect.Length; i++)
        {
            soundEffect[i].volume = soundEffectsSlider.value;
        }
    }

}
