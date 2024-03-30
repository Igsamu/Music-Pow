using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallsCreation2 : MonoBehaviour
{
    public GameObject objetoPrefab;
    public GameObject objetoPrefab2;

    public Transform player;

    public float velocidadLanzamiento = 10f;

    private Vector3[] vectorArray;
    private int previousRandomIndex = -1;

    private float[] floatArray;
    private float[] floatArray2;

    public Animator animator;

    public string WinBee;

    private void Start()
    {
        //La cancion empieza en el segundo 5.

        float segundos = 4.9f;

        for (int i = 0; i <= 600; i++)
        {      
            segundos += 0.1f;
            segundos = Mathf.Round(segundos * Mathf.Pow(10, 1)) / Mathf.Pow(10, 1);
            LanzarEnSegundos(segundos);
        }
        
        float[] floatArray = {0.2f,0.8f,1.2f,1.6f,2.4f,2.7f,3.1f,3.5f,3.8f,4f,4.2f,4.6f,4.9f,5.3f,5.6f,6f,6.5f,6.8f,7.2f,7.9f,8.2f,8.4f,8.5f,8.7f,8.9f,9.1f,9.5f,9.8f,10.2f,10.6f,11f,11.4f,11.7f,12.1f,12.9f,13.7f,14.5f,
        15.2f,15.9f,17.7f,18f,18.3f,19f,19.7f,20.3f,20.5f,20.6f,20.8f,21f,21.2f,21.6f,22f,22.4f,22.8f,23.2f,23.5f,24.3f,24.9f,25.1f,26.5f,25.8f,26.2f,26.6f,26.9f,27.3f,28.5f,28.8f,28.9f,29.2f,29.4f,29.7f,29.9f,30.1f,
        30.3f,30.6f,30.8f,31f,31.2f,31.4f,31.6f,31.8f,33.4f,33.9f,34.1f,34.2f,34.4f,34.6f,34.8f,35.2f,35.4f,35.6f,35.8f,36f,36.1f,36.3f,37.1f,39.4f,40.2f,40.4f,40.7f,41f,41.5f,41.7f,42f,42.4f,42.9f,43.2f,43.6f,44f,44.3f,
        44.7f,45f,45.4f,46f,46.2f,46.6f,47f,47.5f,47.7f,48.1f,48.5f,48.9f,49.2f,50f,50.4f,50.8f,51.5f,52f,52.3f,52.6f,53f,53.4f,53.8f,47.2f,54.5f,56f,57.6f,58.8f,59.2f};
        for (int i = 0; i <= floatArray.Length - 1; i++)
        {
            LanzarEnSegundos2(floatArray[i]+5f);
        }

        Invoke("WinGame", 66f);

        //Designo un vector a cada array

        vectorArray = new Vector3[8];

        vectorArray[0] = new Vector3(-3f, -6f, 0);
        vectorArray[1] = new Vector3(3f, -6f, 0);
        vectorArray[2] = new Vector3(-3f, 6f, 0);
        vectorArray[3] = new Vector3(3f, 6f, 0);
        vectorArray[4] = new Vector3(7f, 2f, 0);
        vectorArray[5] = new Vector3(7f, -2f, 0);
        vectorArray[6] = new Vector3(-7f, 2f, 0);
        vectorArray[7] = new Vector3(-7f, -2f, 0);
    }

    private int GetUniqueRandomIndex()
    {
        int randomIndex = UnityEngine.Random.Range(0, vectorArray.Length);

        while(randomIndex == previousRandomIndex)
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
    private void LanzarEnSegundos2(float segundos)
    {
        Invoke("LanzarObjeto2", segundos);
    }
    private void LanzarEnSegundos3(float segundos)
    {
        Invoke("LanzarObjeto3", segundos);
    }

    private void LanzarObjeto()
    {
        Vector3 spawnPosition = aleatoryVector(); //Se recoge el vector aleatorio
        GameObject objeto = Instantiate(objetoPrefab, spawnPosition, Quaternion.identity); //Se isntancia el objeto
        Vector3 direccion = (player.position - spawnPosition).normalized; //Se recoge la posición del jugador
        Rigidbody2D rb = objeto.GetComponent<Rigidbody2D>(); //Se recoge el RigidBody del objeto creado
        rb.velocity = direccion * velocidadLanzamiento; //Se lanza el ojeto a la dirección del jugador y se multiplica por la velocidad de lanzamiento
    }
    private void LanzarObjeto2()
    {
        Vector3 spawnPosition = aleatoryVector(); //Se recoge el vector aleatorio
        GameObject objeto = Instantiate(objetoPrefab2, spawnPosition, Quaternion.identity); //Se isntancia el objeto
        Vector3 direccion = (player.position - spawnPosition).normalized; //Se recoge la posición del jugador
        Rigidbody2D rb = objeto.GetComponent<Rigidbody2D>(); //Se recoge el RigidBody del objeto creado
        rb.velocity = direccion * velocidadLanzamiento; //Se lanza el ojeto a la dirección del jugador y se multiplica por la velocidad de lanzamiento
    }

    private void WinGame()
    {
        animator.Play("WinTransicion");
        WinBee = "Bee";
        PlayerPrefs.SetString("WinBee", WinBee);
        Invoke("LoadMenu", 2);
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
