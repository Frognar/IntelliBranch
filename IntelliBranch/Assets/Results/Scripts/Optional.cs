using System;

namespace Frognar.Results {
  public readonly struct Optional<T> {
    readonly T value;
    public Result<T> Value => HasValue ? value : new InvalidOperationException("Optional has no value.");
    public bool HasValue { get; }

    public Optional(T value) : this(value, true) {
    }

    Optional(T value, bool hasValue) {
      this.value = value;
      HasValue = hasValue;
    }

    public static Optional<T> None { get; } = new(default, false);
    public static implicit operator Optional<T>(T result) => new(result);
    public static bool operator true(in Optional<T> result) => result.HasValue;
    public static bool operator false(in Optional<T> result) => result.HasValue == false;
  }
}