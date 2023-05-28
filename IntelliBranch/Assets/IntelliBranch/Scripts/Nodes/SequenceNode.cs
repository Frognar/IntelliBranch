using System.Collections.Generic;
using System.Linq;

namespace Frognar.IntelliBranch.Nodes {
  public class SequenceNode : Node {
    readonly IEnumerable<Node> nodes;

    public SequenceNode(IEnumerable<Node> nodes) {
      this.nodes = nodes;
    }

    public override bool Execute() {
      return nodes.All(node => node.Execute());
    }
  }
}