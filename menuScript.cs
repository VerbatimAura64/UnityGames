using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuScript : MonoBehaviour
{

    //public Canvas creditMenu;
    public Button startText;
    //public Button creditText;

    // Use this for initialization
    void Start()
    {

        //quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        //creditText = creditText.GetComponent<Button>();


    }

    /*public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }*/

    public void StartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {
        SceneManager.LoadScene(2);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
