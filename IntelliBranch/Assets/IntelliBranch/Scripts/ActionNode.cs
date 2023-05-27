using System;

namespace Frognar.IntelliBranch {
  public class ActionNode : Node {
    readonly Func<bool> action;

    public ActionNode(Func<bool> action) {
      this.action = action;
    }

    public override bool Execute() {
      return action();
    }
  }
}