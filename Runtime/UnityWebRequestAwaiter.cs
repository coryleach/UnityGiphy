using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace Gameframe.Giphy
{
  public class UnityWebRequestAwaiter : INotifyCompletion
  {
    private readonly UnityWebRequestAsyncOperation asyncOp;
    private Action _continuation;

    public UnityWebRequestAwaiter(UnityWebRequestAsyncOperation asyncOp)
    {
      this.asyncOp = asyncOp;
      asyncOp.completed += OnRequestCompleted;
    }

    public bool IsCompleted { get { return asyncOp.isDone; } }

    public void GetResult()
    {
      do
      {
        //Block until operation is completed
      } while (!IsCompleted);
    }

    public void OnCompleted(Action continuation)
    {
      this._continuation = continuation;
    }

    private void OnRequestCompleted(AsyncOperation obj)
    {
      _continuation();
    }
  }

  public static class UnityWebRequestExtensionMethods
  {
    public static UnityWebRequestAwaiter GetAwaiter(this UnityWebRequestAsyncOperation asyncOp)
    {
      return new UnityWebRequestAwaiter(asyncOp);
    }
  }
}