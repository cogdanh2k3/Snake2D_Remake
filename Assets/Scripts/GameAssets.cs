using System;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    #region
    public static GameAssets instance;
    #endregion

    private void Awake()
    {
        instance = this;
    }
    public Sprite snakeHeadSprite;
    public Sprite snakeBodySprite;
    public Sprite foodSprite;

    public SoundAudioClip[] soundAudioClipArray;

    [Serializable]
    public class SoundAudioClip
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }

}
