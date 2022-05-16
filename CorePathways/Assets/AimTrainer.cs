using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AimTrainer : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;

    private float minValue = -20;
    private float maxValue = 20;

    public int enemiesLeftToKill = 5;

    [SerializeField] TextMeshProUGUI m_Object;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnNew();

        
        if(enemiesLeftToKill == 1)
        {
            m_Object.text = "Eliminate " + enemiesLeftToKill + " more agent to leave!";
        }
        else
        {
            m_Object.text = "Eliminate " + enemiesLeftToKill + " more agents to leave!";
        }

        if(enemiesLeftToKill <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void InstantiatePrefab()
    {
        //Instantiate(prefab, new Vector3(Random.Range(minValue, maxValue), 1, Random.Range(minValue, maxValue)), Quaternion.identity);
    }

    void SpawnNew()
    {
        if(one.gameObject.GetComponent<AimTrainingBot>().getHealth() == 0)
        {
            one.SetActive(false);
            enemiesLeftToKill = 4;
            two.SetActive(true);
        }
        if (two.gameObject.GetComponent<AimTrainingBot>().getHealth() <= 0)
        {
            two.SetActive(false);
            enemiesLeftToKill--;
            three.SetActive(true);
        }
        if (three.gameObject.GetComponent<AimTrainingBot>().getHealth() <= 0)
        {
            three.SetActive(false);
            enemiesLeftToKill--;
            four.SetActive(true);
        }
        if (four.gameObject.GetComponent<AimTrainingBot>().getHealth() <= 0)
        {
            four.SetActive(false);
            enemiesLeftToKill--;
            five.SetActive(true);
        }
        if (five.gameObject.GetComponent<AimTrainingBot>().getHealth() <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
