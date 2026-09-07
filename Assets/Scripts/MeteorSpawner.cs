using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float tempoEntreMeteoros = 1f;
    public float limiteEsquerda = -6f;
    public float limiteDireita = 6f;
    public float altura = 6f;

    void Start()
    {
        InvokeRepeating(nameof(CriarMeteoro), 0f, tempoEntreMeteoros);
    }

    void CriarMeteoro()
    {
        float posicaoX = Random.Range(limiteEsquerda, limiteDireita);

        Vector3 posicao = new Vector3(posicaoX, altura, 0f);

        Instantiate(meteorPrefab, posicao, Quaternion.identity);
    }
}