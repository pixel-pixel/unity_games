using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Level
{
    public bool isFinished = false;
    public bool win = false;
}

[CreateAssetMenu]
public class DBLevels : ScriptableObject
{
    public Level[] levels;

    public Level CurrentLevel()
    {
        var currentIndex = SceneManager.GetActiveScene().buildIndex-1;
        return levels[currentIndex];
    }
}