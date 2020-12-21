using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMyGoap 
{
    /// <summary>
    /// 获取世界状态
    /// </summary>
    /// <returns></returns>
    HashSet<KeyValuePair<string, object>> getWorldState();
    /**
	 * Give the planner a new goal so it can figure out 
	 * the actions needed to fulfill it.
	 */
     //创建目标状态
    HashSet<KeyValuePair<string, object>> createGoalState();

    /**
	 * No sequence of actions could be found for the supplied goal.
	 * You will need to try another goal
	 *///规划器规划失败
    void planFailed(HashSet<KeyValuePair<string, object>> failedGoal);

    /**
	 * A plan was found for the supplied goal.
	 * These are the actions the Agent will perform, in order.
	 *///规划器找到当前目标
    void planFound(HashSet<KeyValuePair<string, object>> goal, Queue<GoapBaseAction> actions);

    /**
	 * All actions are complete and the goal was reached. Hooray!
	 */
    void actionsFinished();

    /**
	 * One of the actions caused the plan to abort.
	 * That action is returned.
	 */
    void planAborted(GoapBaseAction aborter);

    /**
	 * Called during Update. Move the agent towards the target in order
	 * for the next action to be able to perform.
	 * Return true if the Agent is at the target and the next action can perform.
	 * False if it is not there yet.
	 */
     //移动角色
    bool moveAgent(GoapBaseAction nextAction);
}
