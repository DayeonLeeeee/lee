using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {

    [SerializeField]
    private GameObject item;
    // Start is called before the first frame update
    void Start() {     

       StartCoroutine(CreatitemRoutine());
    }

    // Update is called once per frame
    void Update() {
        
    }

    IEnumerator CreatitemRoutine()
    {
        while(true)
        {
            Creatitem();
            yield return new WaitForSeconds(2);
        }
    }

    private void Creatitem()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f, 1.0f),1.1f,0));
        pos.z = 0.0f;
        Instantiate(item,pos,Quaternion.identity);
    }

}
