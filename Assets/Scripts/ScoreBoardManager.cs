using UnityEngine;
using TMPro;

public class ScoreBoardManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SeguidordePuntos.Instancia.IrAlCheckpoint();
        scoreBoardText.text = SeguidordePuntos.Instancia.puntos_actuales.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] TMP_Text scoreBoardText;

    public void IncreaseScore(int amount)
    {
        SeguidordePuntos.Instancia.puntos_actuales += amount;
        scoreBoardText.text = SeguidordePuntos.Instancia.puntos_actuales.ToString();
    }

}
