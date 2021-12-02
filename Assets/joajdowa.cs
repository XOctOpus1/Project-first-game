using UnityEngine;
using UnityEngine.SceneManagement;

public class joajdowa : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }
}
