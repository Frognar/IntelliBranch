using Frognar.Results;

namespace Frognar.IntelliBranch.Nodes {
  public abstract class Node {
    protected Optional<Blackboard> blackboard;

    protected Node(Blackboard blackboard) {
      this.blackboard = blackboard;
    }

    protected Node() {
      blackboard = Optional<Blackboard>.None;
    }

    public abstract bool Execute();
  }
}