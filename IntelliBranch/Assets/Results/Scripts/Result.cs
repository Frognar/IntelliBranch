using System;

namespace Frognar.Results {
  public readonly struct Result<T> {
    readonly T value;
    readonly Exception error;
    bool IsSuccessful { get; }
    public T Value => IsSuccessful ? value : throw error;
    
    public Result(T value) {
      this.value = value;
      error = default;
      IsSuccessful = true;
    }

    public Result(Exception error) {
      value = default;
      this.error = error;
      IsSuccessful = false;
    }

    public static implicit operator Result<T>(T result) => new(result);
    public static implicit operator Result<T>(Exception error) => new(error);
    public static bool operator true(in Result<T> result) => result.IsSuccessful;
    public static bool operator false(in Result<T> result) => result.IsSuccessful == false;
  }
}