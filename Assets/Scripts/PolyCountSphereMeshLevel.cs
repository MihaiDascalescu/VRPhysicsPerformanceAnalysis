using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolyCountSphereMeshLevel : MonoBehaviour
{ 
    #region TestCases
    public enum LevelTypes
    {
        Blank,
        LowPolySphereColliderFiveHundredObjects = 1,
        LowPolySphereColliderOneThousandObjects = 2,
        LowPolySphereColliderTwoThousandObjects = 3,
        LowPolySphereColliderThreeThousandObjects = 4 ,
        LowPolySphereColliderFourThousandObjects = 5,
        LowPolySphereColliderFiveThousandObjects = 6,
        LowPolySphereColliderSevenThousandObjects = 7,
        LowPolySphereColliderTenThousandObjects = 8,
        LowPolyMeshColliderFiveHundredObjects = 9,
        LowPolyMeshColliderOneThousandObjects = 10,
        LowPolyMeshColliderTwoThousandObjects = 11,
        LowPolyMeshColliderThreeThousandObjects = 12 ,
        LowPolyMeshColliderFourThousandObjects = 13,
        LowPolyMeshColliderFiveThousandObjects = 14,
        LowPolyMeshColliderSevenThousandObjects = 15,
        LowPolyMeshColliderTenThousandObjects = 16,
        MediumPolySphereColliderFiveHundredObjects = 17,
        MediumPolySphereColliderOneThousandObjects = 18,
        MediumPolySphereColliderTwoThousandObjects = 19,
        MediumPolySphereColliderThreeThousandObjects = 20,
        MediumPolySphereColliderFourThousandObjects = 21,
        MediumPolySphereColliderFiveThousandObjects = 22,
        MediumPolySphereColliderSevenThousandObjects = 23,
        MediumPolySphereColliderTenThousandObjects = 24,
        MediumPolyMeshColliderFiveHundredObjects = 25,
        MediumPolyMeshColliderOneThousandObjects = 26,
        MediumPolyMeshColliderTwoThousandObjects = 27,
        MediumPolyMeshColliderThreeThousandObjects = 28 ,
        MediumPolyMeshColliderFourThousandObjects = 29,
        MediumPolyMeshColliderFiveThousandObjects = 30,
        MediumPolyMeshColliderSevenThousandObjects = 31,
        MediumPolyMeshColliderTenThousandObjects = 32,
        HighPolySphereColliderFiveHundredObjects = 33,
        HighPolySphereColliderOneThousandObjects = 34,
        HighPolySphereColliderTwoThousandObjects = 35,
        HighPolySphereColliderThreeThousandObjects = 36,
        HighPolySphereColliderFourThousandObjects = 37,
        HighPolySphereColliderFiveThousandObjects = 38,
        HighPolySphereColliderSevenThousandObjects = 39,
        HighPolySphereColliderTenThousandObjects = 40,
        HighPolyMeshColliderFiveHundredObjects = 41,
        HighPolyMeshColliderOneThousandObjects = 42,
        HighPolyMeshColliderTwoThousandObjects = 43,
        HighPolyMeshColliderThreeThousandObjects = 44 ,
        HighPolyMeshColliderFourThousandObjects = 45,
        HighPolyMeshColliderFiveThousandObjects = 46,
        HighPolyMeshColliderSevenThousandObjects = 47,
        HighPolyMeshColliderTenThousandObjects = 48,
    }
    #endregion
    // Start is called before the first frame update
    private LevelTypes levelType;

   

    private GameObject[] gameObjectsToBeInstantiated;

    
    [SerializeField] private GameObject lowPolyBallSphereCollider;
    [SerializeField] private GameObject mediumPolyBallSphereCollider;
    [SerializeField] private GameObject highPolyBallSphereCollider;
    
    [SerializeField] private GameObject lowPolyBallMeshCollider;
    [SerializeField] private GameObject mediumPolyBallMeshCollider;
    [SerializeField] private GameObject highPolyBallMeshCollider;
 

    private Vector3 randomPosition;
   
    private void Start()
    {
        Random.InitState(0);
    }

    public void OnLevelChanged(int levelIndex)
    {
        switch (levelIndex)
        {
            case (int)LevelTypes.LowPolySphereColliderFiveHundredObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
                
                InstantiateAtRandomPostion(0,5,lowPolyBallSphereCollider);
              
                break;
            case (int)LevelTypes.LowPolySphereColliderOneThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
              
                InstantiateAtRandomPostion(0,5,lowPolyBallSphereCollider);
               
                break;
            case (int)LevelTypes.LowPolySphereColliderTwoThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
    
                InstantiateAtRandomPostion(0,5,lowPolyBallSphereCollider);
            
                break;
            case (int)LevelTypes.LowPolySphereColliderThreeThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
              
                InstantiateAtRandomPostion(0,5,lowPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.LowPolySphereColliderFourThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
                
                InstantiateAtRandomPostion(0,5,lowPolyBallSphereCollider);
               
                break;
            case (int)LevelTypes.LowPolySphereColliderFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
               
                InstantiateAtRandomPostion(0,5,lowPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.LowPolySphereColliderSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
              
                InstantiateAtRandomPostion(0,5,lowPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.LowPolySphereColliderTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
            
                InstantiateAtRandomPostion(0,5,lowPolyBallSphereCollider);
                
                break;
             case (int)LevelTypes.LowPolyMeshColliderFiveHundredObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
         
                InstantiateAtRandomPostion(0,5,lowPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.LowPolyMeshColliderOneThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
        
                InstantiateAtRandomPostion(0,5,lowPolyBallMeshCollider);
               
                break;
            case (int)LevelTypes.LowPolyMeshColliderTwoThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
               
                InstantiateAtRandomPostion(0,5,lowPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.LowPolyMeshColliderThreeThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
             
                InstantiateAtRandomPostion(0,5,lowPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.LowPolyMeshColliderFourThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
               
                InstantiateAtRandomPostion(0,5,lowPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.LowPolyMeshColliderFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
           
                InstantiateAtRandomPostion(0,5,lowPolyBallMeshCollider);
               
                break;
            case (int)LevelTypes.LowPolyMeshColliderSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
             
                InstantiateAtRandomPostion(0,5,lowPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.LowPolyMeshColliderTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
           
                InstantiateAtRandomPostion(0,5,lowPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.MediumPolySphereColliderFiveHundredObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
               
                InstantiateAtRandomPostion(0,5,mediumPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.MediumPolySphereColliderOneThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
                
                InstantiateAtRandomPostion(0,5,mediumPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.MediumPolySphereColliderTwoThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
                
                InstantiateAtRandomPostion(0,5,mediumPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.MediumPolySphereColliderThreeThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
               
                InstantiateAtRandomPostion(0,5,mediumPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.MediumPolySphereColliderFourThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
                
                InstantiateAtRandomPostion(0,5,mediumPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.MediumPolySphereColliderFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
                
                InstantiateAtRandomPostion(0,5,mediumPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.MediumPolySphereColliderSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
               
                InstantiateAtRandomPostion(0,5,mediumPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.MediumPolySphereColliderTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
                
                InstantiateAtRandomPostion(0,5,mediumPolyBallSphereCollider);
                
                break;
             case (int)LevelTypes.MediumPolyMeshColliderFiveHundredObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
              
                InstantiateAtRandomPostion(0,5,mediumPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.MediumPolyMeshColliderOneThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
             
                InstantiateAtRandomPostion(0,5,mediumPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.MediumPolyMeshColliderTwoThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
              
                InstantiateAtRandomPostion(0,5,mediumPolyBallMeshCollider);
               
                break;
            case (int)LevelTypes.MediumPolyMeshColliderThreeThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
               
                InstantiateAtRandomPostion(0,5,mediumPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.MediumPolyMeshColliderFourThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
               
                InstantiateAtRandomPostion(0,5,mediumPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.MediumPolyMeshColliderFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
          
                InstantiateAtRandomPostion(0,5,mediumPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.MediumPolyMeshColliderSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
             
                InstantiateAtRandomPostion(0,5,mediumPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.MediumPolyMeshColliderTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
           
                InstantiateAtRandomPostion(0,5,mediumPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.HighPolySphereColliderFiveHundredObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
               
                InstantiateAtRandomPostion(0,5,highPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.HighPolySphereColliderOneThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
                
                InstantiateAtRandomPostion(0,5,highPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.HighPolySphereColliderTwoThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
                
                InstantiateAtRandomPostion(0,5,highPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.HighPolySphereColliderThreeThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
               
                InstantiateAtRandomPostion(0,5,highPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.HighPolySphereColliderFourThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
                
                InstantiateAtRandomPostion(0,5,highPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.HighPolySphereColliderFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
                
                InstantiateAtRandomPostion(0,5,highPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.HighPolySphereColliderSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
               
                InstantiateAtRandomPostion(0,5,highPolyBallSphereCollider);
                
                break;
            case (int)LevelTypes.HighPolySphereColliderTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
                
                InstantiateAtRandomPostion(0,5,highPolyBallSphereCollider);
                
                break;
             case (int)LevelTypes.HighPolyMeshColliderFiveHundredObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
              
                InstantiateAtRandomPostion(0,5,highPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.HighPolyMeshColliderOneThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
             
                InstantiateAtRandomPostion(0,5,highPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.HighPolyMeshColliderTwoThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
              
                InstantiateAtRandomPostion(0,5,highPolyBallMeshCollider);
               
                break;
            case (int)LevelTypes.HighPolyMeshColliderThreeThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
               
                InstantiateAtRandomPostion(0,5,highPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.HighPolyMeshColliderFourThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
               
                InstantiateAtRandomPostion(0,5,highPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.HighPolyMeshColliderFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
          
                InstantiateAtRandomPostion(0,5,highPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.HighPolyMeshColliderSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
             
                InstantiateAtRandomPostion(0,5,highPolyBallMeshCollider);
                
                break;
            case (int)LevelTypes.HighPolyMeshColliderTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
           
                InstantiateAtRandomPostion(0,5,highPolyBallMeshCollider);
                
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
