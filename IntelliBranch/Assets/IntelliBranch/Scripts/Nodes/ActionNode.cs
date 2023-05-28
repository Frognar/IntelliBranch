using System;

namespace Frognar.IntelliBranch.Nodes {
  public class ActionNode : Node {
    readonly Func<bool> action;

    public ActionNode(Blackboard blackboard, Func<bool> action) : base(blackboard) {
      this.action = action;
    }

    public override bool Execute() {
      return action();
    }
  }
}