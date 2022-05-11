using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager2 : MonoBehaviour {

    [SerializeField]
    private GameObject item2;
    // Start is called before the first frame update
    void Start() {     

       StartCoroutine(Creatitem2Routine());
    }

    // Update is called once per frame
    void Update() {
        
    }

    IEnumerator Creatitem2Routine()
    {
        while(true)
        {
            Creatitem2();
            yield return new WaitForSeconds(5);
        }
    }

    private void Creatitem2()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f, 1.0f),1.1f,0));
        pos.z = 0.0f;
        Instantiate(item2,pos,Quaternion.identity);
    }

}
