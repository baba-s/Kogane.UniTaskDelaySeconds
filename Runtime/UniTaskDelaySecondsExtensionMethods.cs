using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// UniTask.DelaySeconds に関する拡張メソッドを管理するクラス
    /// </summary>
    public static class UniTaskDelaySecondsExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 指定された秒数待機します
        /// </summary>
        public static UniTask DelaySeconds
        (
            this GameObject   self,
            double            seconds,
            bool              ignoreTimeScale   = false,
            PlayerLoopTiming  delayTiming       = PlayerLoopTiming.Update,
            CancellationToken cancellationToken = default
        )
        {
            return UniTask.DelaySeconds
            (
                gameObject: self,
                seconds: seconds,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming,
                cancellationToken: cancellationToken
            );
        }

        /// <summary>
        /// 指定された秒数待機します
        /// </summary>
        public static UniTask DelaySeconds
        (
            this Component    self,
            double            seconds,
            bool              ignoreTimeScale   = false,
            PlayerLoopTiming  delayTiming       = PlayerLoopTiming.Update,
            CancellationToken cancellationToken = default
        )
        {
            return UniTask.DelaySeconds
            (
                component: self,
                seconds: seconds,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming,
                cancellationToken: cancellationToken
            );
        }

        /// <summary>
        /// 指定された秒数待機します
        /// </summary>
        public static UniTask DelaySeconds
        (
            this GameObject   self,
            double            seconds,
            DelayType         delayType,
            PlayerLoopTiming  delayTiming       = PlayerLoopTiming.Update,
            CancellationToken cancellationToken = default
        )
        {
            return UniTask.DelaySeconds
            (
                gameObject: self,
                seconds: seconds,
                delayType: delayType,
                delayTiming: delayTiming,
                cancellationToken: cancellationToken
            );
        }

        /// <summary>
        /// 指定された秒数待機します
        /// </summary>
        public static UniTask DelaySeconds
        (
            this Component    self,
            double            seconds,
            DelayType         delayType,
            PlayerLoopTiming  delayTiming       = PlayerLoopTiming.Update,
            CancellationToken cancellationToken = default
        )
        {
            return UniTask.DelaySeconds
            (
                component: self,
                seconds: seconds,
                delayType: delayType,
                delayTiming: delayTiming,
                cancellationToken: cancellationToken
            );
        }
    }
}