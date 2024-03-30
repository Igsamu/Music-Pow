using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheFinalCountdownBalls : MonoBehaviour
{
    public GameObject objetoPrefab;
    public GameObject objetoPrefab2;
    public GameObject objetoPrefab3;
    public GameObject its;
    public GameObject the;
    public GameObject final;
    public GameObject count;
    public GameObject down;

    public Transform player;

    public float velocidadLanzamiento = 10f;

    private Vector3[] vectorArray;
    private int previousRandomIndex = -1;

    private float[] floatArray;
    private float[] floatArray2;
    private float[] floatArray3;
    private float[] guitarSoloArray;
    private float[] Rift1Array;
    private float[] Rift2Array;
    private float[] itsArray;
    private float[] theArray;
    private float[] finalArray;
    private float[] countArray;
    private float[] downArray;

    public Animator animator;

    public string WinCountDown;

    private void Start()
    {
        // Rift 1

        float[] rift1Array = { 13.9f, 22f, 30f,38f,54.9f,63f,120f,128.2f,169f,177f,230f,238f,254.6f,262.6f,279f,287.2f};
        float[] floatArray = { 0f, 0.1f, 0.2f, 0.6f, 1.2f, 1.9f, 2.1f, 2.3f, 2.4f, 2.7f, 4f, 4.1f, 4.3f, 4.7f, 5.2f, 5.9f, 6.1f, 6.3f, 6.6f, 6.8f, 7f, 7.3f };

        for (int i = 0; i <= rift1Array.Length -1; i++)
        {
            for (int j = 0; j <= floatArray.Length-1; j++)
            {
                LanzarEnSegundos2(rift1Array[i] + floatArray[j]);
            }
        }

        // Rift 2

        float[] rift2Array = { 46.6f, 71.1f, 185.3f, 246.2f, 270.4f, 295.3f };
        float[] floatArray2 = { 0f, 0.15f, 0.3f, 0.9f, 1.1f, 1.3f, 1.5f, 1.7f, 2.0f, 2.3f, 2.8f, 3.3f, 4.3f, 4.7f, 5.1f, 5.3f, 5.4f };

        for (int i = 0; i <= rift2Array.Length - 1; i++)
        {
            for (int j = 0; j <= floatArray2.Length - 1; j++)
            {
                LanzarEnSegundos2(rift2Array[i] + floatArray2[j]);
            }
        }

        float[] floatArray3 = {81.7f,82.2f,82.7f,83.2f,83.7f,84.2f,84.7f,87.4f,87.8f,88.2f,88.5f,88.7f,89.3f,91.6f,91.9f,92.3f,92.7f,93.4f,95.7f,96f,96.7f,97.2f,97.5f,99.8f,100f,100.8f,101.1f,101.5f,103.8f,104.1f,104.5f,
        104.8f,105.1f,105.6f,105.9f,106.3f,108f,108.2f,108.6f,109.2f,110.2f,110.6f,111.2f,112.2f,112.5f,113f,113.2f,113.9f,114.2f,114.7f,115f,136.4f, 136.6f, 137.1f, 137.4f, 137.7f, 138.1f, 138.8f, 139.3f, 140.5f, 140.8f,
        141.1f, 141.6f, 142.3f, 144.6f, 144.8f, 145.2f, 145.7f, 146.0f, 146.8f, 148.5f, 148.8f, 149.3f, 149.7f, 150.2f, 151.3f, 152.7f, 153.0f, 153.4f, 153.7f, 154.0f, 154.5f, 154.8f, 155.3f, 156.8f, 157.0f, 157.4f, 
        157.8f, 158.1f, 158.6f, 159.2f, 159.7f, 160.1f, 160.9f, 161.2f, 161.5f, 161.9f, 162.3f, 163.0f, 163.3f, 163.7f,229.5f, 231.4f, 231.5f, 233.4f, 235.3f, 235.5f, 237.6f, 239.3f, 239.6f,241.7f, 243.7f, 243.9f, 
        245.7f, 246.7f, 247.8f, 248.2f, 248.4f, 248.5f, 248.7f, 249.3f, 249.8f,281.1f, 281.4f, 281.8f, 282.2f, 282.5f, 283.0f, 289.4f, 289.7f, 290.1f, 290.4f, 290.8f, 291.3f};

        for (int i =0; i<=floatArray3.Length - 1; i++)
        {
            LanzarEnSegundos(floatArray3[i]);
        }

        //Guitar Solo

        float[] guitarSoloArray = { 196.8f, 196.9f, 197.0f, 197.1f, 197.2f, 197.3f, 197.4f, 197.5f, 197.6f, 197.7f, 197.8f, 197.9f, 198.0f, 198.1f, 198.2f, 198.3f, 198.4f, 198.5f, 198.6f, 198.7f, 198.8f, 198.9f, 199.0f,
        199.1f, 199.2f, 199.3f, 199.4f, 199.5f, 199.6f, 199.7f, 199.8f, 199.9f, 200.0f, 200.1f, 200.2f, 200.3f, 200.4f, 200.5f, 200.6f, 200.7f, 200.8f, 200.9f, 201.0f, 201.1f, 201.2f, 201.3f, 201.4f, 201.5f, 201.6f,
        201.7f, 201.8f, 201.9f, 202.0f, 202.1f, 202.2f, 202.3f, 202.4f, 202.5f, 202.6f, 202.7f, 202.8f, 202.9f, 203.0f, 203.1f, 203.2f, 203.3f, 203.4f, 203.5f, 203.6f, 203.7f, 203.8f, 203.9f, 204.0f, 204.1f, 204.2f,
        204.3f, 204.4f, 204.5f, 204.6f, 204.7f, 204.8f, 204.9f, 205.0f,205.7f, 205.9f, 206.0f, 206.3f, 206.8f, 207.0f, 207.5f, 208.0f, 208.5f, 209.0f,209.5f, 209.7f, 209.9f, 210.1f, 210.3f, 210.5f, 210.7f, 210.9f, 211.1f, 
        211.3f, 211.5f,213.1f, 213.2f, 213.3f, 213.4f, 213.5f, 213.6f, 213.7f, 213.8f, 213.9f, 214.0f, 214.1f, 214.2f, 214.3f, 214.4f, 214.5f, 214.6f, 214.7f, 214.8f, 214.9f, 215.0f, 215.1f, 215.2f, 215.3f, 215.4f, 215.5f,
        215.6f, 215.7f, 215.8f, 215.9f, 216.0f, 216.1f, 216.2f, 216.3f, 216.4f, 216.5f, 216.6f, 216.7f, 216.8f, 216.9f, 217.0f, 217.1f, 217.2f, 217.3f, 217.4f, 217.5f, 217.6f, 217.7f, 217.8f, 217.9f, 218.0f, 218.1f, 
        218.2f, 218.3f, 218.4f, 218.5f, 218.6f, 218.7f, 218.8f, 218.9f, 219.0f, 219.1f, 219.2f, 219.3f, 219.4f, 219.5f, 219.6f, 219.7f, 219.8f, 219.9f, 220.0f, 220.7f, 220.9f, 221.0f, 221.3f, 221.8f, 222.0f, 222.5f, 
        223.0f, 223.5f, 224.0f, 224.5f, 224.7f, 224.9f, 225.1f, 225.3f, 225.5f, 225.7f, 225.9f, 226.1f, 226.3f, 226.5f, 226.7f, 226.9f, 227.1f, 227.3f, 227.5f, 227.7f, 227.9f, 228.1f, 228.3f, 228.5f, 228.7f, 228.9f, 
        229.1f, 229.3f, 229.5f};

        for (int i = 0; i<= guitarSoloArray.Length -1 ; i++)
        {
            LanzarEnSegundos3(guitarSoloArray[i]);
        }

        //Letters

        float[] itsArray = { 117.6f,166.6f,252.5f,276.6f,293.2f,301.1f};

        for (int i = 0;i<= itsArray.Length -1 ; i++)
        {
            LanzarEnSegundosits(itsArray[i]);
        }

        float[] theArray = {118f,126.2f,167.1f,175.1f,183.4f,244.4f,252.6f,260.8f,269f,277f,285.2f,293.4f,301.5f};

        for (int i = 0; i <= theArray.Length - 1; i++)
        {
            LanzarEnSegundosthe(theArray[i]);
        }
        float[] finalArray = { 118.3f,126.4f,167.3f,175.4f,183.6f,185.6f,244.6f,252.8f,261f,269.2f,271.2f,277.2f,285.4f,293.6f,295.6f,301.7f};

        for (int i = 0; i <= finalArray.Length - 1; i++)
        {
            LanzarEnSegundosfinal(finalArray[i]);
        }
        float[] countArray = { 119.3f,127.5f,168.3f,176.4f,184.5f,186.6f,245.7f,253.9f,262f,270.2f,272.2f,278.4f,286.5f,294.7f,296.7f,302.8f};

        for (int i = 0; i <= countArray.Length - 1; i++)
        {
            LanzarEnSegundoscount(countArray[i]);
        }
        float[] downArray = { 119.9f,128f,168.7f,176.9f,185.1f,187.1f,246.2f,254.4f,262.5f,270.7f,272.7f,278.9f,287f,295.2f,297.3f,303.4f};

        for (int i = 0; i <= downArray.Length - 1; i++)
        {
            LanzarEnSegundosdown(downArray[i]);
        }


        Invoke("WinGame", 308f);

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
    private void LanzarEnSegundosits(float segundos)
    {
        Invoke("Lanzarits", segundos);
    }
    private void LanzarEnSegundosthe(float segundos)
    {
        Invoke("Lanzarthe", segundos);
    }
    private void LanzarEnSegundosfinal(float segundos)
    {
        Invoke("Lanzarfinal", segundos);
    }
    private void LanzarEnSegundoscount(float segundos)
    {
        Invoke("Lanzarcount", segundos);
    }
    private void LanzarEnSegundosdown(float segundos)
    {
        Invoke("Lanzardown", segundos);
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
    private void LanzarObjeto3()
    {
        Vector3 spawnPosition = aleatoryVector(); //Se recoge el vector aleatorio
        GameObject objeto = Instantiate(objetoPrefab3, spawnPosition, Quaternion.identity); //Se isntancia el objeto
        Vector3 direccion = (player.position - spawnPosition).normalized; //Se recoge la posición del jugador
        Rigidbody2D rb = objeto.GetComponent<Rigidbody2D>(); //Se recoge el RigidBody del objeto creado
        rb.velocity = direccion * velocidadLanzamiento; //Se lanza el ojeto a la dirección del jugador y se multiplica por la velocidad de lanzamiento
    }
    private void Lanzarits()
    {
        Vector3 spawnPosition = aleatoryVector(); //Se recoge el vector aleatorio
        GameObject objeto = Instantiate(its, spawnPosition, Quaternion.identity); //Se isntancia el objeto
        Vector3 direccion = (player.position - spawnPosition).normalized; //Se recoge la posición del jugador
        Rigidbody2D rb = objeto.GetComponent<Rigidbody2D>(); //Se recoge el RigidBody del objeto creado
        rb.velocity = direccion * velocidadLanzamiento; //Se lanza el ojeto a la dirección del jugador y se multiplica por la velocidad de lanzamiento
    }
    private void Lanzarthe()
    {
        Vector3 spawnPosition = aleatoryVector(); //Se recoge el vector aleatorio
        GameObject objeto = Instantiate(the, spawnPosition, Quaternion.identity); //Se isntancia el objeto
        Vector3 direccion = (player.position - spawnPosition).normalized; //Se recoge la posición del jugador
        Rigidbody2D rb = objeto.GetComponent<Rigidbody2D>(); //Se recoge el RigidBody del objeto creado
        rb.velocity = direccion * velocidadLanzamiento; //Se lanza el ojeto a la dirección del jugador y se multiplica por la velocidad de lanzamiento
    }
    private void Lanzarfinal()
    {
        Vector3 spawnPosition = aleatoryVector(); //Se recoge el vector aleatorio
        GameObject objeto = Instantiate(final, spawnPosition, Quaternion.identity); //Se isntancia el objeto
        Vector3 direccion = (player.position - spawnPosition).normalized; //Se recoge la posición del jugador
        Rigidbody2D rb = objeto.GetComponent<Rigidbody2D>(); //Se recoge el RigidBody del objeto creado
        rb.velocity = direccion * velocidadLanzamiento; //Se lanza el ojeto a la dirección del jugador y se multiplica por la velocidad de lanzamiento
    }
    private void Lanzarcount()
    {
        Vector3 spawnPosition = aleatoryVector(); //Se recoge el vector aleatorio
        GameObject objeto = Instantiate(count, spawnPosition, Quaternion.identity); //Se isntancia el objeto
        Vector3 direccion = (player.position - spawnPosition).normalized; //Se recoge la posición del jugador
        Rigidbody2D rb = objeto.GetComponent<Rigidbody2D>(); //Se recoge el RigidBody del objeto creado
        rb.velocity = direccion * velocidadLanzamiento; //Se lanza el ojeto a la dirección del jugador y se multiplica por la velocidad de lanzamiento
    }
    private void Lanzardown()
    {
        Vector3 spawnPosition = aleatoryVector(); //Se recoge el vector aleatorio
        GameObject objeto = Instantiate(down, spawnPosition, Quaternion.identity); //Se isntancia el objeto
        Vector3 direccion = (player.position - spawnPosition).normalized; //Se recoge la posición del jugador
        Rigidbody2D rb = objeto.GetComponent<Rigidbody2D>(); //Se recoge el RigidBody del objeto creado
        rb.velocity = direccion * velocidadLanzamiento; //Se lanza el ojeto a la dirección del jugador y se multiplica por la velocidad de lanzamiento
    }

    private void WinGame()
    {
        animator.Play("WinTransicion");
        WinCountDown = "CountDown";
        PlayerPrefs.SetString("WinCountDown", WinCountDown);
        Invoke("LoadMenu", 2);
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
