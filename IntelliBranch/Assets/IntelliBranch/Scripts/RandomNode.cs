﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Frognar.IntelliBranch {
  public class RandomNode : Node {
    readonly List<Node> nodes;
    readonly Random random;

    public RandomNode(IEnumerable<Node> nodes) {
      this.nodes = nodes.ToList();
      random = new Random();
    }

    public override bool Execute() {
      return nodes[random.Next(nodes.Count)].Execute();
    }
  }
}