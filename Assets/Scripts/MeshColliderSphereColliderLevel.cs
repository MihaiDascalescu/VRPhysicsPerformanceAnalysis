using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class MeshColliderSphereColliderLevel : MonoBehaviour
{
    #region TestCases
    public enum LevelTypes
    {
        Blank,
        PhysicsSphereColliderFiveHundredObjects = 1,
        PhysicsSphereColliderOneThousandObjects = 2,
        PhysicsSphereColliderTwoThousandObjects = 3,
        PhysicsSphereColliderThreeThousandObjects = 4 ,
        PhysicsSphereColliderContinousDetectionFiveHundredObjects = 5,
        PhysicsSphereColliderContinousDetectionOneThousandObjects = 6,
        PhysicsSphereColliderContinousDetectionTwoThousandObjects = 7,
        PhysicsSphereColliderContinousDetectionThreeThousandObjects = 8,
        PhysicsMeshColliderDiscreteFiveHundredObjects = 9,
        PhysicsMeshColliderOneThousandObjects = 10,
        PhysicsMeshColliderTwoThousandObjects = 11,
        PhysicsMeshColliderThreeThousandObjects = 12 ,
        PhysicsMeshColliderContinousDetectionFiveHundredObjects = 13,
        PhysicsMeshColliderContinousDetectionOneThousandObjects = 14,
        PhysicsMeshColliderContinousDetectionTwoThousandObjects = 15,
        PhysicsMeshColliderContinousDetectionThreeThousandObjects = 16,
        PhysicsSphereColliderFourThousandObjects = 17,
        PhysicsSphereColliderFiveThousandObjects = 18,
        PhysicsSphereColliderSevenThousandObjects = 19,
        PhysicsSphereColliderTenThousandObjects = 20,
        PhysicsSphereColliderContinousDetectionFourThousandObjects = 21,
        PhysicsSphereColliderContinousDetectionFiveThousandObjects = 22,
        PhysicsSphereColliderContinousDetectionSevenThousandObjects = 23,
        PhysicsSphereColliderContinousDetectionTenThousandObjects = 24,
        PhysicsMeshColliderFourThousandObjects = 25,
        PhysicsMeshColliderFiveThousandObjects = 26,
        PhysicsMeshColliderSevenThousandObjects = 27,
        PhysicsMeshColliderTenThousandObjects = 28,
        PhysicsMeshColliderContinousDetectionFourThousandObjects = 29,
        PhysicsMeshColliderContinousDetectionFiveThousandObjects = 30,
        PhysicsMeshColliderContinousDetectionSevenThousandObjects = 31,
        PhysicsMeshColliderContinousDetectionTenThousandObjects = 32,
    }
    
    #endregion
    
    private LevelTypes levelType;
    
    private GameObject[] gameObjectsToBeInstantiated;

    [SerializeField] private GameObject ballSphereCollider;
    [SerializeField] private GameObject ballMeshCollider;
    
    private Vector3 randomPosition;
    private Rigidbody ballSphereColliderRb;
    private Rigidbody ballMeshColliderRb;
    private void Start()
    {
        Random.InitState(0);
        ballMeshColliderRb = ballMeshCollider.GetComponent<Rigidbody>();
        ballSphereColliderRb = ballSphereCollider.GetComponent<Rigidbody>();
        OnLevelChanged(4);
    }

    public void OnLevelChanged(int levelIndex)
    {
        switch (levelIndex)
        {
            case (int)LevelTypes.PhysicsSphereColliderFiveHundredObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
              
                break;
            case (int)LevelTypes.PhysicsSphereColliderOneThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
               
                break;
            case (int)LevelTypes.PhysicsSphereColliderTwoThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
            
                break;
            case (int)LevelTypes.PhysicsSphereColliderThreeThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderContinousDetectionFiveHundredObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
               
                break;
            case (int)LevelTypes.PhysicsSphereColliderContinousDetectionOneThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderContinousDetectionTwoThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderContinousDetectionThreeThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
             case (int)LevelTypes.PhysicsMeshColliderDiscreteFiveHundredObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderOneThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
               
                break;
            case (int)LevelTypes.PhysicsMeshColliderTwoThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderThreeThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderContinousDetectionFiveHundredObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderContinousDetectionOneThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
               
                break;
            case (int)LevelTypes.PhysicsMeshColliderContinousDetectionTwoThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderContinousDetectionThreeThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderFourThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderFiveThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderSevenThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderContinousDetectionFourThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderContinousDetectionFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderContinousDetectionSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
            case (int)LevelTypes.PhysicsSphereColliderContinousDetectionTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
                ballSphereColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballSphereCollider);
                
                break;
             case (int)LevelTypes.PhysicsMeshColliderFourThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderFiveThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderSevenThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
               
                break;
            case (int)LevelTypes.PhysicsMeshColliderTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Discrete;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderContinousDetectionFourThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderContinousDetectionFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderContinousDetectionSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
            case (int)LevelTypes.PhysicsMeshColliderContinousDetectionTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
                ballMeshColliderRb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                InstantiateAtRandomPostion(0,5,ballMeshCollider);
                
                break;
        }
    }

 

    private void InstantiateAtRandomPostion(float startLimit, float endLimit, GameObject objectToInstantiate)
    {
        for (int i = 0; i < gameObjectsToBeInstantiated.Length; i++)
        {
            randomPosition = new Vector3(Random.Range(startLimit, endLimit), 5,
                Random.Range(startLimit, endLimit));
            gameObjectsToBeInstantiated[i] = Instantiate(objectToInstantiate, randomPosition, Quaternion.identity);
            
        }
    }
    private void DestroyInstantiatedAtRandomPostion()
    {
        if (gameObjectsToBeInstantiated != null)
        {
            for (int i = 0; i < gameObjectsToBeInstantiated.Length; i++)
            {
                Destroy(gameObjectsToBeInstantiated[i]);
            }
        }
    }

    
}
