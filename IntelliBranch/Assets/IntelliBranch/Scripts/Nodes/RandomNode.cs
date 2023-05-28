using System;
using System.Collections.Generic;
using System.Linq;

namespace Frognar.IntelliBranch.Nodes {
  public class RandomNode : Node {
    readonly List<Node> nodes;
    readonly Random random;

    public RandomNode(Blackboard blackboard, IEnumerable<Node> nodes) : base(blackboard) {
      this.nodes = nodes.ToList();
      random = new Random();
    }
    
    public RandomNode(IEnumerable<Node> nodes) {
      this.nodes = nodes.ToList();
      random = new Random();
    }

    public override bool Execute() {
      return nodes[random.Next(nodes.Count)].Execute();
    }
  }
}