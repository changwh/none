using UnityEngine;
using System.Collections;

public class SwipeTutorial : MonoBehaviour {

    private Vector2 center;
    private WorldToScreen  die;

    void OnSwipe(SwipeGesture gesture)
    {
        //  完整的滑动数据
        Vector2 move = gesture.Move;
        //  滑动的速度
        float velocity = gesture.Velocity;
        //  大概的滑动方向
        FingerGestures.SwipeDirection direction = gesture.Direction;
        Debug.Log("Swipe gesture detected at " + gesture.Position + ". It was sent by " + gesture.Recognizer.name);
    }
}
