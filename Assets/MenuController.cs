using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour
{
    public CanvasGroup mainMenu;
    public CanvasGroup optionsMenu;

    public float transitionDuration = 0.25f;

    void Start()
    {
        ShowMainMenuInstant();
    }

    public void OpenOptionsMenu()
    {
        StartCoroutine(TransitionMenus(mainMenu, optionsMenu));
    }

    public void BackToMainMenu()
    {
        StartCoroutine(TransitionMenus(optionsMenu, mainMenu));
    }

    void ShowMainMenuInstant()
    {
        mainMenu.alpha = 1;
        mainMenu.interactable = true;
        mainMenu.blocksRaycasts = true;

        optionsMenu.alpha = 0;
        optionsMenu.interactable = false;
        optionsMenu.blocksRaycasts = false;
        optionsMenu.gameObject.SetActive(false);
    }

    IEnumerator TransitionMenus(CanvasGroup currentMenu, CanvasGroup nextMenu)
    {
        float timer = 0f;
        nextMenu.gameObject.SetActive(true);

        while (timer < transitionDuration)
        {
            timer += Time.deltaTime;
            float progress = timer / transitionDuration;

            currentMenu.alpha = 1 - progress;
            nextMenu.alpha = progress;

            yield return null;
        }

        currentMenu.alpha = 0;
        currentMenu.interactable = false;
        currentMenu.blocksRaycasts = false;
        currentMenu.gameObject.SetActive(false);

        nextMenu.alpha = 1;
        nextMenu.interactable = true;
        nextMenu.blocksRaycasts = true;
    }
}
