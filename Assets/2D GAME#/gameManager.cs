using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string SceneName;

    public void RestartGame()
    {

        SceneManager.LoadScene(SceneName);

    }
}
