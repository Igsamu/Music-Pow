using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallsCreation : MonoBehaviour
{
    public GameObject objetoPrefab;

    public Transform player;

    public float velocidadLanzamiento = 10f;

    private Vector3[] vectorArray;
    private int previousRandomIndex = -1;

    private float[] floatArray;

    public Animator animator;

    public string WinAlso;

    private void Start()
    {
        float[] floatArray = {12f,12f,14,14f,16f,16f,20f,20f,20.4f,20.4f,24.7f,24.7f,25.2f,25.6f,25.9f,25.9f,26.3f,26.6f,27f,27.4f,27.3f,28.1f,28.5f,28.9f,28.9f,31f,31f,33.1f,33.1f,37.5f,37.5f,37.9f,37.9f,37.9f,42.4f,
        42.9f,43.3f,43.7f,44.1f,44.5f,44.9f,45.3f,45.7f,46.1f,46.5f,48.7f,48.7f,50.7f,50.7f,54.6f,54.6f,54.6f,55.1f,55.1f,55.1f,58.8f,59.3f,59.7f,62f,63.4f,63.9f,64.3f,67.3f,67.5f,67.7f,70.2f,71.6f,72.7f,72.7f,74f,74f,
        75f,75.1f,75.2f,75.3f,75.4f,75.5f,75.6f,75.7f,75.8f,75.9f,76f,76.1f,76.5f,77f,77.5f,78f,78.5f,79f,79.5f};
        for (int i = 0; i <= floatArray.Length - 1; i++)
        {
            LanzarEnSegundos(floatArray[i]);
        }

        Invoke("WinGame", 85f);

        vectorArray = new Vector3[8];

        vectorArray[0] = new Vector3(-3f, -6f, 0);
        vectorArray[1] = new Vector3(3f, -6f, 0);
        vectorArray[2] = new Vector3(-3f, 6f, 0);
        vectorArray[3] = new Vector3(3f, 6f, 0);
        vectorArray[4] = new Vector3(7f, 2f, 0);
        vectorArray[5] = new Vector3(8f, -2f, 0);
        vectorArray[6] = new Vector3(-7f, 2f, 0);
        vectorArray[7] = new Vector3(-7f, -2f, 0);
    }

    private int GetUniqueRandomIndex()
    {
        int randomIndex = UnityEngine.Random.Range(0, vectorArray.Length);

        while (randomIndex == previousRandomIndex)
        {
            randomIndex = UnityEngine.Random.Range(0, vectorArray.Length);
        }
        previousRandomIndex = randomIndex;

        return randomIndex;
    }

    private Vector3 aleatoryVector()
    {
        // Generar un indice aleatorio
        int randomIndex = GetUniqueRandomIndex();

        randomIndex = UnityEngine.Random.Range(0, vectorArray.Length);

        // Obtener el Vector3 correspondiente al indice
        Vector3 randomVector = vectorArray[randomIndex];
        return randomVector;
    }

    private void LanzarEnSegundos(float segundos)
    {
        Invoke("LanzarObjeto", segundos);
    }

    private void LanzarObjeto()
    {
        Vector3 spawnPosition = aleatoryVector(); //Se recoge el vector aleatorio
        GameObject objeto = Instantiate(objetoPrefab, spawnPosition, Quaternion.identity); //Se isntancia el objeto
        Vector3 direccion = (player.position - spawnPosition).normalized; //Se recoge la posición del jugador
        Rigidbody2D rb = objeto.GetComponent<Rigidbody2D>(); //Se recoge el RigidBody del objeto creado
        rb.velocity = direccion * velocidadLanzamiento; //Se lanza el ojeto a la dirección del jugador y se multiplica por la velocidad de lanzamiento
    }

    private void WinGame()
    {
        animator.Play("WinTransicion");
        WinAlso = "Also";
        PlayerPrefs.SetString("WinAlso", WinAlso);
        Invoke("LoadMenu", 2);
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}