using UnityEngine;

public class ScriptPractical3 : MonoBehaviour
{
    public int randomNumber;
    public GameObject someObject;

    private void Update()
    {
        Randomeizer();
    }

    void Randomeizer()
    {
        randomNumber = Random.Range(1, 100); //[1;99)
        Debug.Log(randomNumber);

        if (randomNumber == 3)
        {
            Debug.Log("Проверка условия!");
        }
    }
}