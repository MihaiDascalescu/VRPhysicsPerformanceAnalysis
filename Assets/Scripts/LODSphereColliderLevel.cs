using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LODSphereColliderLevel : MonoBehaviour
{
     #region TestCases
    public enum LevelTypes
    {
        Blank,
        LowPolyLODFiveHundredObjects = 1,
        LowPolyLODOneThousandObjects = 2,
        LowPolyLODTwoThousandObjects = 3,
        LowPolyLODThreeThousandObjects = 4 ,
        LowPolyLODFourThousandObjects = 5,
        LowPolyLODFiveThousandObjects = 6,
        LowPolyLODSevenThousandObjects = 7,
        LowPolyLODTenThousandObjects = 8,
        MediumPolyLODFiveHundredObjects = 9,
        MediumPolyLODOneThousandObjects = 10,
        MediumPolyLODTwoThousandObjects = 11,
        MediumPolyLODThreeThousandObjects = 12,
        MediumPolyLODFourThousandObjects = 13,
        MediumPolyLODFiveThousandObjects = 14,
        MediumPolyLODSevenThousandObjects = 15,
        MediumPolyLODTenThousandObjects = 16,
        HighPolyLODFiveHundredObjects = 17,
        HighPolyLODOneThousandObjects = 18,
        HighPolyLODTwoThousandObjects = 19,
        HighPolyLODThreeThousandObjects = 20,
        HighPolyLODFourThousandObjects = 21,
        HighPolyLODFiveThousandObjects = 22,
        HighPolyLODSevenThousandObjects = 23,
        HighPolyLODTenThousandObjects = 24,
        
    }
    #endregion
    // Start is called before the first frame update
    private LevelTypes levelType;

   

    private GameObject[] gameObjectsToBeInstantiated;

    
    [SerializeField] private GameObject lowPolyBallLOD;
    [SerializeField] private GameObject mediumPolyBallLOD;
    [SerializeField] private GameObject highPolyBallLOD;


    private Vector3 randomPosition;
   
    private void Start()
    {
        Random.InitState(0);
    }

    public void OnLevelChanged(int levelIndex)
    {
        switch (levelIndex)
        {
            case (int)LevelTypes.LowPolyLODFiveHundredObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
                
                InstantiateAtRandomPostion(0,5,lowPolyBallLOD);
              
                break;
            case (int)LevelTypes.LowPolyLODOneThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
              
                InstantiateAtRandomPostion(0,5,lowPolyBallLOD);
               
                break;
            case (int)LevelTypes.LowPolyLODTwoThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
    
                InstantiateAtRandomPostion(0,5,lowPolyBallLOD);
            
                break;
            case (int)LevelTypes.LowPolyLODThreeThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
              
                InstantiateAtRandomPostion(0,5,lowPolyBallLOD);
                
                break;
            case (int)LevelTypes.LowPolyLODFourThousandObjects:
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
                
                InstantiateAtRandomPostion(0,5,lowPolyBallLOD);
               
                break;
            case (int)LevelTypes.LowPolyLODFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
               
                InstantiateAtRandomPostion(0,5,lowPolyBallLOD);
                
                break;
            case (int)LevelTypes.LowPolyLODSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
              
                InstantiateAtRandomPostion(0,5,lowPolyBallLOD);
                
                break;
            case (int)LevelTypes.LowPolyLODTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
            
                InstantiateAtRandomPostion(0,5,lowPolyBallLOD);
                
                break;
            case (int)LevelTypes.MediumPolyLODFiveHundredObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
               
                InstantiateAtRandomPostion(0,5,mediumPolyBallLOD);
                
                break;
            case (int)LevelTypes.MediumPolyLODOneThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
                
                InstantiateAtRandomPostion(0,5,mediumPolyBallLOD);
                
                break;
            case (int)LevelTypes.MediumPolyLODTwoThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
                
                InstantiateAtRandomPostion(0,5,mediumPolyBallLOD);
                
                break;
            case (int)LevelTypes.MediumPolyLODThreeThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
               
                InstantiateAtRandomPostion(0,5,mediumPolyBallLOD);
                
                break;
            case (int)LevelTypes.MediumPolyLODFourThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
                
                InstantiateAtRandomPostion(0,5,mediumPolyBallLOD);
                
                break;
            case (int)LevelTypes.MediumPolyLODFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
                
                InstantiateAtRandomPostion(0,5,mediumPolyBallLOD);
                
                break;
            case (int)LevelTypes.MediumPolyLODSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
               
                InstantiateAtRandomPostion(0,5,mediumPolyBallLOD);
                
                break;
            case (int)LevelTypes.MediumPolyLODTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
                
                InstantiateAtRandomPostion(0,5,mediumPolyBallLOD);
                
                break;
            case (int)LevelTypes.HighPolyLODFiveHundredObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[500];
               
                InstantiateAtRandomPostion(0,5,highPolyBallLOD);
                
                break;
            case (int)LevelTypes.HighPolyLODOneThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[1000];
                
                InstantiateAtRandomPostion(0,5,highPolyBallLOD);
                
                break;
            case (int)LevelTypes.HighPolyLODTwoThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[2000];
                
                InstantiateAtRandomPostion(0,5,highPolyBallLOD);
                
                break;
            case (int)LevelTypes.HighPolyLODThreeThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[3000];
               
                InstantiateAtRandomPostion(0,5,highPolyBallLOD);
                
                break;
            case (int)LevelTypes.HighPolyLODFourThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[4000];
                
                InstantiateAtRandomPostion(0,5,highPolyBallLOD);
                
                break;
            case (int)LevelTypes.HighPolyLODFiveThousandObjects:
               
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[5000];
                
                InstantiateAtRandomPostion(0,5,highPolyBallLOD);
                
                break;
            case (int)LevelTypes.HighPolyLODSevenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[7500];
               
                InstantiateAtRandomPostion(0,5,highPolyBallLOD);
                
                break;
            case (int)LevelTypes.HighPolyLODTenThousandObjects:
                
                DestroyInstantiatedAtRandomPostion();
                gameObjectsToBeInstantiated = new GameObject[10000];
                
                InstantiateAtRandomPostion(0,5,highPolyBallLOD);
                
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
