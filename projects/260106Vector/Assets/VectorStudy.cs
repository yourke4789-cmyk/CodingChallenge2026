using System;
using UnityEngine;

public class VectorStudy : MonoBehaviour
{
    public Vector3 vectorA = new Vector3(2, 4, 6);
    public Vector3 vectorB = new Vector3(3, 5, 7);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void Aake()
    {
        //Vector3 a = new Vector3(3, 6, 9);
        //a = a * 10; // (3*10, 6*10, 9 *10)
    }

    public void aaaa()
    {
        Vector3 A = vectorA.normalized; // 새롭게 단위 벡터를 만드는 것(어딘가에 담아내는 용도로 사용하는 것) 
        float B = vectorA.magnitude;
        float C = Vector3.Dot(vectorA, vectorB);
        Vector3 d = Vector3.Cross(vectorA, vectorB);

    }

    public void quaternion()
    {
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 60, 0));
        // 오일러 값으로 표현하는 Vector값에서 쿼터니언(Quaternion) 값을 생성 할 수 있다.
        // (0. 60, 0) 회전을 표현하는 쿼터니언 회전 데이터를 생성하는 코드이다.

        Vector3 eulerRotation = rotation.eulerAngles;
        // 쿼터니언(Quaternion) 타입의 회전값을 Vector3 타입의 오일러 각으로 변환환 변수 eulerAngles(오일러 각도)제공합니다.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
