using System;
using System.Collections.Generic;
using Frognar.Results.Scripts;

namespace Frognar.IntelliBranch {
  public class Blackboard {
    readonly Dictionary<string, object> data = new();

    public Result<T> Get<T>(string key) {
      if (data.TryGetValue(key, out object value) == false) {
        return new KeyNotFoundException($"No data found for key '{key}'.");
      }

      if (value is T tValue) {
        return tValue;
      }

      return new InvalidCastException($"Value of type {value.GetType()} cannot be cast to {typeof(T)}");
    }

    public void Set(string key, object value) {
      data[key] = value;
    }
  }
}