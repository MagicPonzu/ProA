using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, -0.00002f);

        // transformを取得
        Transform myTransform = this.transform;
 
        // ワールド座標を基準に、座標を取得
        Vector3 worldPos = myTransform.position;
        float z = worldPos.z;

        if(z < -0.003f) {
            Destroy(this.gameObject);
        }
    }
}
