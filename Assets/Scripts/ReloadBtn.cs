using UnityEngine;
using UnityEngine.UI;

public class ReloadBtn : MonoBehaviour
{
    public Button reloadBtn;

    private void Start()
    {
        reloadBtn.onClick.AddListener(ReloadScene);
    }

    private void ReloadScene()
    {
        Loader.Load(Loader.Scene.GameScene);
    }
}
