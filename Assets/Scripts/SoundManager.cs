using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public static class SoundManager
{
    public enum Sound
    {
        SnakeMove,
        SnakeDie,
        SnakeEat,
        ButtonClick,
        ButtonOver,
    }
    public static void PlaySound(Sound sound)
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetAudioClip(sound));

    }

    private static AudioClip GetAudioClip(Sound sound)
    {
        foreach(GameAssets.SoundAudioClip soundAudioClip in GameAssets.instance.soundAudioClipArray)
        {
            if(soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioClip;
            }
        }
        Debug.LogError("Sound " + sound + " not found!");
        return null;
    }

    public static void AddButtonSounds(this Button button)
    {
        if(button.gameObject.GetComponent<ButtonSoundHandler>() == null)
        {
            button.gameObject.AddComponent<ButtonSoundHandler>();
        }
    }

    private class ButtonSoundHandler : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
        {
            SoundManager.PlaySound(SoundManager.Sound.ButtonOver);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            SoundManager.PlaySound(SoundManager.Sound.ButtonClick);
        }
    }
}
