using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * This whole script was downloaded from the https://github.com/Brackeys/2D-Character-Controller
 * I edited the crouch function to the lighting
 * else remaiend the same*/

public class GameStates : MonoBehaviour
{
    int _score = 35;

    bool _GameWin = false;

    [SerializeField] GameObject _scoreText;

    [SerializeField] GameObject _winText;

    [SerializeField] GameObject _ending1Text;

    [SerializeField] GameObject _restartText;

    [SerializeField] GameObject _introText;

    public static GameStates Instance;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (_score <= 0)
        {
            _GameWin = true;
            _winText.SetActive(true);
            _ending1Text.SetActive(true);
            _restartText.SetActive(true);
        }

        if (Input.GetButtonDown("Submit") && _GameWin == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetButtonDown("Close"))
        {
            _introText.SetActive(false);
        }

    }

    public void IncreaseScore(int amount)
    {
        _score = _score - amount;
        _scoreText.GetComponent<Text>().text = "Lamp Remained: " + _score;
    }

    public void InitiateGameWin()
    {
        _GameWin = true;
        _winText.SetActive(true);
        _ending1Text.SetActive(true);
        _restartText.SetActive(true);
    }

}
