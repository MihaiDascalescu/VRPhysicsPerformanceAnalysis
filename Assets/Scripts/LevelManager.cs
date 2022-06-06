using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    public enum LevelTypes
    {
        Blank,
        PhysicsOneObject = 1,
        PhysicsTenObjects = 2,
        PhysicsFiftyObjects = 3,
        PhysicsOneHundredObjects = 4 ,
        PhysicsPostProcessingOneObject = 5,
        PhysicsPostProcessingTenObjects = 6,
        PhysicsPostProcessingFiftyObjects = 7,
        PhysicsPostProcessingOneHundredObjects = 8
    }
    // Start is called before the first frame update
    private LevelTypes levelType;

    private GameObject[,] positionMatrix;
    
    [SerializeField] private GameObject objectToInstantiate;
    [SerializeField] private GameObject postProcessing;
    void Start()
    {
        OnLevelChanged(6);
    }

   
    public void OnLevelChanged(int levelIndex)
    {
        switch (levelIndex)
        {
            case (int)LevelTypes.PhysicsOneObject:
                DestroyInstantiatedObjects(1,1);
                InstantiateObjectsAtPosition(1,1);
                postProcessing.SetActive(false);
                break;
            case (int)LevelTypes.PhysicsTenObjects:
                DestroyInstantiatedObjects(10,10);
                InstantiateObjectsAtPosition(10,10);
                postProcessing.SetActive(false);
                break;
            case (int)LevelTypes.PhysicsFiftyObjects:
                DestroyInstantiatedObjects(50,50);
                InstantiateObjectsAtPosition(50,50);
                postProcessing.SetActive(false);
                break;
            case (int)LevelTypes.PhysicsOneHundredObjects:
                DestroyInstantiatedObjects(100,100);
                InstantiateObjectsAtPosition(100,100);
                postProcessing.SetActive(false);
                break;
            case (int)LevelTypes.PhysicsPostProcessingOneObject:
                DestroyInstantiatedObjects(1,1);
                InstantiateObjectsAtPosition(1,1);
                postProcessing.SetActive(true);
                break;
            case (int)LevelTypes.PhysicsPostProcessingTenObjects:
                DestroyInstantiatedObjects(10,10);
                InstantiateObjectsAtPosition(10,10);
                postProcessing.SetActive(true);
                break;
            case (int)LevelTypes.PhysicsPostProcessingFiftyObjects:
                DestroyInstantiatedObjects(50,50);
                InstantiateObjectsAtPosition(50,50);
                postProcessing.SetActive(true);
                break;
            case (int)LevelTypes.PhysicsPostProcessingOneHundredObjects:
                DestroyInstantiatedObjects(100,100);
                InstantiateObjectsAtPosition(100,100);
                postProcessing.SetActive(true);
                break;
        }
    }

    private void InstantiateObjectsAtPosition(int columnLength, int rowLength)
    {
        positionMatrix = new GameObject[columnLength, rowLength];
        for (int i = 0; i < columnLength; i++)
        {
            for (int j = 0; j < rowLength; j++)
            {
                positionMatrix[i, j] = Instantiate(objectToInstantiate, new Vector3(i, 10, j), Quaternion.identity);
            }
        }
    }

    private void DestroyInstantiatedObjects(int columnLength, int rowLength)
    {
        if (positionMatrix != null)
        {
            for (int i = 0; i < columnLength; i++)
            {
                for (int j = 0; j < rowLength; j++)
                {
                    Destroy(positionMatrix[i,j]);
                }
            }
        }
    }
}
