using UnityEngine;
using UnityEngine.UI;

public class MainMenuWindow : MonoBehaviour
{
    private enum Sub
    {
        Main,
        HowToPlay,
    }

    private void Awake()
    {
        transform.Find("howToPlaySub").GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        transform.Find("mainSub").GetComponent<RectTransform>().anchoredPosition = Vector2.zero;


        Button playBtn = transform.Find("mainSub").Find("playBtn").GetComponent<Button>();
        playBtn.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.GameScene);
            if (Time.timeScale != 1f) { Time.timeScale = 1f; }
        });


        Button quitBtn = transform.Find("mainSub").Find("quitBtn").GetComponent<Button>();
        quitBtn.onClick.AddListener(() =>
        {
            Application.Quit();
        });

        Button howToPlayBtn = transform.Find("mainSub").Find("howToPlayBtn").GetComponent<Button>();
        howToPlayBtn.onClick.AddListener(() =>
        {
            ShowSub(Sub.HowToPlay);
        });

        Button backBtn = transform.Find("howToPlaySub").Find("backBtn").GetComponent<Button>();
        backBtn.onClick.AddListener(() =>
        {
            ShowSub(Sub.Main);
        });

        ShowSub(Sub.Main);
    }

    private void ShowSub(Sub sub)
    {
        transform.Find("mainSub").gameObject.SetActive(false);
        transform.Find("howToPlaySub").gameObject.SetActive(false);

        switch (sub)
        {
            case Sub.Main:
                transform.Find("mainSub").gameObject.SetActive(true);
                break;
            case Sub.HowToPlay:
                transform.Find("howToPlaySub").gameObject.SetActive(true);
                break;

        }
    }
}
