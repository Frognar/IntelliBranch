using System.Collections.Generic;
using System.Linq;

namespace Frognar.IntelliBranch {
  public class SelectorNode : Node {
    readonly IEnumerable<Node> nodes;

    public SelectorNode(IEnumerable<Node> nodes) {
      this.nodes = nodes;
    }

    public override bool Execute() {
      return nodes.Any(node => node.Execute());
    }
  }
}