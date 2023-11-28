using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] GameObject[] fishPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTrans;
    [SerializeField] float maxTrans;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FishSpawn());
    }

    IEnumerator FishSpawn(){
        while(true){
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(fishPrefab[Random.Range(0, fishPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
