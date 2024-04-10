using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] string _nextLevelName;

    Slimes[] _slimes;

    void OnEnable()
    {
        _slimes = FindObjectsOfType<Slimes>();

    }

    // Update is called once per frame
    void Update()
    {
        if (MonstersAreAllDead())
            GoToNextLevel();
    }

    public void GoToNextLevel()
    {
        Debug.Log("Go to level " + _nextLevelName);
        SceneManager.LoadScene(_nextLevelName);
    }

    bool MonstersAreAllDead()
    {
        foreach (var slimes in _slimes)
        {
            if (slimes.gameObject.activeSelf)
                return false;
        }

        return true;
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game");
    }
}
