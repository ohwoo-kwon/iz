using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            SceneManager.LoadScene("scenario01");
        }
    }

    public void MoveToEndingCredit()
    {
        SceneManager.LoadScene("endingcredit");
    }

    public void MoveToCity()
    {
        SceneManager.LoadScene("City");
    }

    public void MoveToScenario02()
    {
        SceneManager.LoadScene("scenario02");
    }

    public void MoveToHome()
    {
        SceneManager.LoadScene("Home");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
