﻿using System;

namespace Frognar.IntelliBranch {
  public class DecisionNode : Node {
    readonly Func<bool> decision;
    readonly Node trueNode;
    readonly Node falseNode;

    public DecisionNode(Func<bool> decision, Node trueNode, Node falseNode) {
      this.decision = decision;
      this.trueNode = trueNode;
      this.falseNode = falseNode;
    }

    public override bool Execute() {
      return decision()
        ? trueNode.Execute()
        : falseNode.Execute();
    }
  }
}