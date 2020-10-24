using UnityEngine.SceneManagement;
using UnityEngine;

public class Retry : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
