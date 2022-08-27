using System;
using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks
{
    public partial struct UniTask
    {
        public static UniTask DelaySeconds
        (
            double            seconds,
            bool              ignoreTimeScale   = false,
            PlayerLoopTiming  delayTiming       = PlayerLoopTiming.Update,
            CancellationToken cancellationToken = default
        )
        {
            return Delay
            (
                delayTimeSpan: TimeSpan.FromSeconds( seconds ),
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming,
                cancellationToken: cancellationToken
            );
        }

        public static UniTask DelaySeconds
        (
            double            seconds,
            DelayType         delayType,
            PlayerLoopTiming  delayTiming       = PlayerLoopTiming.Update,
            CancellationToken cancellationToken = default
        )
        {
            return Delay
            (
                delayTimeSpan: TimeSpan.FromSeconds( seconds ),
                delayType: delayType,
                delayTiming: delayTiming,
                cancellationToken: cancellationToken
            );
        }

        public static UniTask DelaySeconds
        (
            GameObject       gameObject,
            double           seconds,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            return DelaySeconds
            (
                seconds: seconds,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming,
                cancellationToken: gameObject.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask DelaySeconds
        (
            GameObject       gameObject,
            double           seconds,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            return DelaySeconds
            (
                seconds: seconds,
                delayType: delayType,
                delayTiming: delayTiming,
                cancellationToken: gameObject.GetCancellationTokenOnDestroy()
            );
        }

        public static UniTask DelaySeconds
        (
            Component        component,
            double           seconds,
            bool             ignoreTimeScale = false,
            PlayerLoopTiming delayTiming     = PlayerLoopTiming.Update
        )
        {
            return DelaySeconds
            (
                gameObject: component.gameObject,
                seconds: seconds,
                ignoreTimeScale: ignoreTimeScale,
                delayTiming: delayTiming
            );
        }

        public static UniTask DelaySeconds
        (
            Component        component,
            double           seconds,
            DelayType        delayType,
            PlayerLoopTiming delayTiming = PlayerLoopTiming.Update
        )
        {
            return DelaySeconds
            (
                gameObject: component.gameObject,
                seconds: seconds,
                delayType: delayType,
                delayTiming: delayTiming
            );
        }
    }
}