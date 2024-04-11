using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    public const string MIXER_MUSIC = "MusicVolume";
    public const string MIXER_SFX = "SFXVolume";

    void Awake()
    {
        if (mixer == null)
        {
            Debug.LogError("AudioMixer not set !");
            return;
        }

        if (musicSlider == null)
        {
            Debug.LogError("Music Slider not set ! ");
            return;
        }

        if (sfxSlider == null)
        {
            Debug.LogError("Sfx Slider not set !");
            return;
        }

        musicSlider.onValueChanged.AddListener(setMusicVolume);
        sfxSlider.onValueChanged.AddListener(setSFXVolume);
    }

    void Start()
    {
        if (mixer == null)
        {
            Debug.LogError("AudioMixer not set !");
            return;
        }

        if (musicSlider == null)
        {
            Debug.LogError("Music Slider not set ! ");
            return;
        }

        if (sfxSlider == null)
        {
            Debug.LogError("Sfx Slider not set !");
            return;
        }

        musicSlider.value = PlayerPrefs.GetFloat(AudioManager.MUSIC_KEY, 1f);
        sfxSlider.value = PlayerPrefs.GetFloat(AudioManager.SFX_KEY, 1f);
    }

    void OnDisable()
    {
        if (mixer == null)
        {
            Debug.LogError("AudioMixer not set !");
            return;
        }

        if (musicSlider == null)
        {
            Debug.LogError("Music Slider not set ! ");
            return;
        }

        if (sfxSlider == null)
        {
            Debug.LogError("Sfx Slider not set !");
            return;
        }

        PlayerPrefs.SetFloat(AudioManager.MUSIC_KEY, musicSlider.value);
        PlayerPrefs.SetFloat(AudioManager.SFX_KEY, sfxSlider.value);
    }

    void setMusicVolume(float value)
    {
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value)*20);
    }

    void setSFXVolume(float value)
    {
        mixer.SetFloat(MIXER_SFX, Mathf.Log10(value) * 20);
    }
}
