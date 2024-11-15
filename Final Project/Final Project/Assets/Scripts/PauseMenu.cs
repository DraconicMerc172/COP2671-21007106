using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    [SerializeField] GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause() {

        pauseMenu.SetActive(true);

    }

    public void Home() {

        SceneManager.LoadScene("Main Menu");

    }

    public void Resume() {

        pauseMenu.SetActive(false);

    }

    public void Restart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
