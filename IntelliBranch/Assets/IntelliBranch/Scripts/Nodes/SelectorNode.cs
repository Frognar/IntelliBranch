using System.Collections.Generic;
using System.Linq;

namespace Frognar.IntelliBranch.Nodes {
  public class SelectorNode : Node {
    readonly IEnumerable<Node> nodes;

    public SelectorNode(Blackboard blackboard, IEnumerable<Node> nodes) : base(blackboard) {
      this.nodes = nodes;
    }
    
    public SelectorNode(IEnumerable<Node> nodes) {
      this.nodes = nodes;
    }

    public override bool Execute() {
      return nodes.Any(node => node.Execute());
    }
  }
}