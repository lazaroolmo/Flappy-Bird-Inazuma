using UnityEngine;

public class BoladeArroz : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            ScoreBoardManager scoreBoardManager = FindAnyObjectByType<ScoreBoardManager>();
            if (scoreBoardManager) scoreBoardManager.IncreaseScore(1);
            Destroy(this.gameObject);
        }

    }
}

