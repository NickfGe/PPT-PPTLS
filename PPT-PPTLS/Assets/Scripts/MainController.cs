using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    public Canvas main;
    public Canvas info;

    private void Start()
    {
        Main();
    }

    public void Information()
    {
        main.gameObject.SetActive(false);
        info.gameObject.SetActive(true);
    }

    public void Main()
    {
        info.gameObject.SetActive(false);
        main.gameObject.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
