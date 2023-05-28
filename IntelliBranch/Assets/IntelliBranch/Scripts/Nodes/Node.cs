namespace Frognar.IntelliBranch.Nodes {
  public abstract class Node {
    protected Blackboard blackboard;

    protected Node(Blackboard blackboard) {
      this.blackboard = blackboard;
    }

    public abstract bool Execute();
  }
}