using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<GameObject> targets;

    private float spawnRate = 1.0f;

    public bool isGameActive;

    private int score;

    public TextMeshProUGUI scoreText;

    public GameObject titleScreen;

    public Button restartButton;

    public TextMeshProUGUI gameOverText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int scoreToAdd) {

        score += scoreToAdd;

        scoreText.text = "Score: " + score;

    }

    public void StartGame(int difficulty) {

        StartCoroutine(SpawnTarget());

        score = 0;

        UpdateScore(0);

        isGameActive = true;

        titleScreen.gameObject.SetActive(false);

        spawnRate /= difficulty;

    }

    public void RestartGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    IEnumerator SpawnTarget() {

        while (isGameActive) {

            yield return new WaitForSeconds(spawnRate);

            int index = Random.Range(0, targets.Count);

            Instantiate(targets[index]);

        }

    }
}
