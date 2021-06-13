using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ExitUI : MonoBehaviour
{
    public Sprite buttonPressSprite;
    private Animator m_animator;
    public Button Button;
    Sprite a;
    void Start()
    {
        Button.onClick.AddListener(TaskOnClick);
        m_animator = GetComponent<Animator>();
        a = Resources.Load<Sprite>("StartButton2");
    }

    void TaskOnClick()
    {
        StartCoroutine(SwapSprite());
    }

    IEnumerator SwapSprite()
    {
        m_animator.SetBool("Swap", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName: "Tutorial");
    }
}

