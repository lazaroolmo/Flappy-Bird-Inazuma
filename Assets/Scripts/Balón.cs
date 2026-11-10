using UnityEngine;

public class Balón : MonoBehaviour
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
            if (scoreBoardManager) scoreBoardManager.IncreaseScore(3);
            Destroy(this.gameObject); // PARA QUE DESAPAREZCA EL OBJETO
        }

    }
}
