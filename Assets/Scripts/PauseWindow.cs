using UnityEngine;
using UnityEngine.UI;

public class PauseWindow : MonoBehaviour
{
    private static PauseWindow instance;

    private void Awake()
    {
        instance = this;
        transform.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        transform.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
        
        Button resumeBtn = transform.Find("resumeBtn").GetComponent<Button>();
        resumeBtn.onClick.AddListener(() =>
        {
            GameHandler.ResumeGame();
        });
        transform.Find("resumeBtn").GetComponent<Button>().AddButtonSounds();

        Button mainMenuBtn = transform.Find("mainMenuBtn").GetComponent<Button>();
        mainMenuBtn.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.MainMenu);
        });
        transform.Find("mainMenuBtn").GetComponent<Button>().AddButtonSounds();


        Hide();
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public static void ShowStatic()
    {
        instance.Show();
    }

    public static void HideStatic()
    {
        instance.Hide();
    }
}
