using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    private Toggle pptls;

    private void Awake()
    {
        pptls = GameObject.Find("Toggle").GetComponent<Toggle>();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
