
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public Path path;
    public int pathPositon;

    public int steps;
    bool isMoving;
    public Timer timer;

    private void Update()
    {
        if (!isMoving)
        {
            Debug.Log(pathPositon);
            if (pathPositon + steps < path.fieldsList.Count)
            {
                Move();
            }
            else {Debug.Log("High Number on Dice! Once again"); }
            if (pathPositon == path.fieldsList.Count-1) 
            {
                GlobalV.timeResult = timer.result;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("You win");  
            }
        }
            
    }

    void Move()
    {
        if (!isMoving)
        {
            isMoving = true;
            while (steps > 0)
            {
                Vector3 nextPosition = path.fieldsList[pathPositon + 1].position;
                nextPosition = new Vector3 (nextPosition.x, nextPosition.y+0.2f, nextPosition.z);
                while (MoveToNext(nextPosition))
                {
                   continue;
                }
                steps--;
                pathPositon++;
            }
           
            isMoving = false;
        }
    }

    bool MoveToNext(Vector3 finishPointPosition)
    {
       return finishPointPosition!= (transform.position = Vector3.MoveTowards(transform.position,finishPointPosition,0.0002f*Time.deltaTime));
    }
}
