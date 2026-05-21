using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectCoins : MonoBehaviour
{
    public void ButtonClick()
    {
        SceneManager.LoadScene("CollectCoins");
    }
}