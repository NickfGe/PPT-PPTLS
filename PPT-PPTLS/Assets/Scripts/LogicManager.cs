using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    private Toggle toggle;
    [SerializeField] private TextMeshProUGUI result;
    public GameObject ppt;
    public GameObject pptls;


    private void Awake()
    {
        toggle = GameObject.Find("Toggle").GetComponent<Toggle>();
        result = GameObject.Find("ResultTxt").GetComponent<TextMeshProUGUI>();

        ChangeModes(true, false);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void EnablePPTLS()
    {
        if(toggle.isOn) ChangeModes(false, true);
        else ChangeModes(true, false);
    }

    private void ChangeModes(bool normal, bool tbbt)
    {
        ppt.SetActive(normal);
        pptls.SetActive(tbbt);
    }
}
