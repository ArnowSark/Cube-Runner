using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject obstackle;
    public Transform spawnPoint;
    int score;
    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpwanObstackle()
    {
        while (true)
        {
            float waitTime = Random.Range(0.5f, 2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obstackle, spawnPoint.position, Quaternion.identity);
        }
    }

    void scoreUp()
    {
        score++;
        scoreText.text = score.ToString(); 
    }
    public void GameStart()
    {
        player.SetActive(true);
        playButton.SetActive(false);

        StartCoroutine("SpwanObstackle");

        InvokeRepeating("scoreUp", 2f, 1f);
    }
}
