using UnityEngine;
using UnityEngine.UI;

public class SoundButtonsController : MonoBehaviour
{
    public AudioSource musicSource;

    public GameObject buttonOn;  // кнопка "звук включён"
    public GameObject buttonOff; // кнопка "звук выключен"

    private void Start()
    {
        // Изначально проверим состояние звука и покажем нужную кнопку
        UpdateButtons();
    }

    public void TurnSoundOn()
    {
        musicSource.mute = false;
        UpdateButtons();
    }

    public void TurnSoundOff()
    {
        musicSource.mute = true;
        UpdateButtons();
    }

    private void UpdateButtons()
    {
        bool isMuted = musicSource.mute;
        buttonOn.SetActive(!isMuted);
        buttonOff.SetActive(isMuted);
    }
}
